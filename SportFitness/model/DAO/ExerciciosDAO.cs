using MySql.Data.MySqlClient;
using sportFitness;
using SportFitness.model.TO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.DAO
{
    class ExerciciosDAO : ExerciciosTO, ICadastro
    {
        #region Insert
        public void insert()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into exercicios(idGrupoMuscular, nome) values(@idGrupoMuscular, @nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@idGrupoMuscular", this.IdGrupoMuscular);
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cn.Open();
                this.Id = Convert.ToInt16(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

                cmd.CommandText = "update exercicios set idGrupoMuscular = @idGrupoMuscular, nome = @nome where id_exercicio=@id_exercicio";
                cmd.Parameters.AddWithValue("@id_exercicio", this.Id);
                cmd.Parameters.AddWithValue("@idGrupoMuscular", this.IdGrupoMuscular);
                cmd.Parameters.AddWithValue("@nome", this.Nome);
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

                cmd.CommandText = "delete from exercicios where id_exercicio=@id_exercicio";
                cmd.Parameters.AddWithValue("@id_exercicio", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o exercício  " + this.Id);
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

        #region Select com INNER JOIN para listar os alunos na dataGrid
        public DataTable select(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from exercicios " + options + " INNER JOIN grupoMuscular ON exercicios.idGrupoMuscular = grupoMuscular.id_grupoMuscular", dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Select da pesquisa do sistema
        public DataTable selectPesquisa(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from exercicios INNER JOIN grupoMuscular ON exercicios.idGrupoMuscular = grupoMuscular.id_grupoMuscular " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar os dados do exercicio
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from exercicios " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Exercicios exe = new Exercicios();

                exe.Id = Convert.ToInt16(dr["id_exercicio"]);
                exe.IdGrupoMuscular = Convert.ToInt16(dr["idGrupoMuscular"]);
                exe.Nome = dr["nome"].ToString();

                dados.Add(exe);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}
