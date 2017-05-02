using sportFitness;
using SportFitness.model.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace SportFitness.model.DAO
{
    class FichaDetalheDAO : FichaDetalheTO, ICadastro
    {
        #region Obter o próximo ID auto-incremento no mysql
        public int getIdFichaDetalhe()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = dbConnection.Conecta;
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("Select Auto_Increment from information_schema.tables where table_schema = 'SportFitness' and table_name = 'fichaDetalhe'", cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            int id_fichaDetalhe = 0;

            while (dr.Read())
            {
                id_fichaDetalhe = Convert.ToInt16(dr.GetString(0)) - 1;
            }

            return id_fichaDetalhe;
        }
        #endregion

        #region Select com INNER JOIN para listar na dataGrid
        public DataTable altFicha(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from fichaDetalhe inner join exercicios on fichaDetalhe.idExercicio = exercicios.id_exercicio inner join grupoMuscular on exercicios.idGrupoMuscular = grupoMuscular.id_grupoMuscular " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Insert
        public void insert()
        {
            MySqlConnection cn = new MySqlConnection();

           
                FichaTreino fichaTreino = new FichaTreino();
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into fichaDetalhe(idFichaTreino, idExercicio, series, repeticoes, carga) values(@idFichaTreino, @idExercicio, @series, @repeticoes, @carga); select @@IDENTITY;";
                //cmd.Parameters.AddWithValue("@idFichaTreino", fichaTreino.getIdFichaTreino());
                cmd.Parameters.AddWithValue("@idFichaTreino", this.IdFichaTreino);
            //cmd.Parameters.AddWithValue("@idFichaTreino", this.IdFichaTreino);
            cmd.Parameters.AddWithValue("@idExercicio", this.IdExercicio);
                cmd.Parameters.AddWithValue("@series", this.Series);
                cmd.Parameters.AddWithValue("@repeticoes", this.Repeticoes);
                cmd.Parameters.AddWithValue("@carga", this.Carga);

                cn.Open();
                this.Id = Convert.ToInt16(cmd.ExecuteScalar());
                cn.Close();
          
        }
        #endregion

        #region Update
        public void update()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "update fichaDetalhe set idFichaTreino=@idFichaTreino, idExercicio=@idExercicio, series=@series, repeticoes=@repeticoes, carga=@carga where id_fichaDetalhe=@id_fichaDetalhe";
                cmd.Parameters.AddWithValue("@id_fichaDetalhe", this.Id);
                cmd.Parameters.AddWithValue("@idFichaTreino", this.IdFichaTreino);
                cmd.Parameters.AddWithValue("@idExercicio", this.IdExercicio);
                cmd.Parameters.AddWithValue("@series", this.Series);
                cmd.Parameters.AddWithValue("@repeticoes", this.Repeticoes);
                cmd.Parameters.AddWithValue("@carga", this.Carga);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Delete
        public void delete()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "delete from fichaDetalhe where id_fichaDetalhe=@id_fichaDetalhe";
                cmd.Parameters.AddWithValue("@id_fichaDetalhe", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir a ficha detalhe " + this.Id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Select
        public DataTable select(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_fichaDetalhe, idFichaTreino, idExercicio, g.nome as grupoMuscular, e.nome as exercicio, series, repeticoes, carga FROM fichadetalhe f INNER JOIN exercicios e ON f.idExercicio = e.id_exercicio INNER JOIN grupoMuscular g ON g.id_grupoMuscular = e.idGrupoMuscular " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar os dados da ficha detalhe
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from fichaDetalhe " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                FichaDetalhe ficha = new FichaDetalhe();

                ficha.Id = Convert.ToInt16(dr["id_fichaDetalhe"]);
                ficha.IdFichaTreino = Convert.ToInt16(dr["idFichaTreino"]);
                ficha.IdExercicio = Convert.ToInt16(dr["idExercicio"]);
                ficha.Series = Convert.ToInt16(dr["series"]);
                ficha.Repeticoes = Convert.ToInt16(dr["repeticoes"]);
                ficha.Carga = Convert.ToInt16(dr["carga"]);

                dados.Add(ficha);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Select para verificar o nome do exercicio
        public DataTable verificaTreino(string options = "")
        {
            //MySqlDataAdapter da = new MySqlDataAdapter("Select * from planoTreino Inner join fichaTreino on planoTreino.id_planoTreino = fichaTreino.idPlanoTreino join fichaDetalhe on fichaTreino.id_fichaTreino = fichaDetalhe.idFichaTreino;" + options, dbConnection.Conecta);
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM fichaDetalhe d INNER JOIN fichaTreino f ON d.idFichaTreino = f.id_fichaTreino INNER JOIN planoTreino p ON p.id_planoTreino = f.idPlanoTreino " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

    }
}
