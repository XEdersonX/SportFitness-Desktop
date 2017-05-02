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
    class PlanoTreinoDAO : PlanoTreinoTO, ICadastro
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
                cmd.CommandText = "insert into planoTreino(idAluno, idTreinador, idObjetivo, dataInicio, vezesSemana, situacao) values(@idAluno, @idTreinador, @idObjetivo, @dataInicio, @vezesSemana, @situacao); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@idAluno", this.IdAluno);
                cmd.Parameters.AddWithValue("@idTreinador", this.IdTreinador);
                cmd.Parameters.AddWithValue("@idObjetivo", this.IdObjetivo);
                cmd.Parameters.AddWithValue("@dataInicio", this.DataInicio);
                cmd.Parameters.AddWithValue("@vezesSemana", this.VezesSemana);
                cmd.Parameters.AddWithValue("@situacao", this.Situacao);

                cn.Open();
                this.Id = Convert.ToInt16(cmd.ExecuteScalar());
                cn.Close();
            }
            catch(Exception ex)
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

                cmd.CommandText = "update planoTreino set idAluno=@idAluno, idTreinador=@idTreinador, idObjetivo=@idObjetivo, dataInicio=@dataInicio, vezesSemana=@vezesSemana, situacao=@situacao where id_planoTreino=@id_planoTreino";
                cmd.Parameters.AddWithValue("@id_planoTreino", this.Id);
                cmd.Parameters.AddWithValue("@idAluno", this.IdAluno);
                cmd.Parameters.AddWithValue("@idTreinador", this.IdTreinador);
                cmd.Parameters.AddWithValue("@idObjetivo", this.IdObjetivo);
                cmd.Parameters.AddWithValue("@dataInicio", this.DataInicio);
                cmd.Parameters.AddWithValue("@vezesSemana", this.VezesSemana);
                cmd.Parameters.AddWithValue("@situacao", this.Situacao);

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

        #region Update para realizar a exclusao lógica
        public void updateDelete()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "update planoTreino set situacao = 0 where id_planoTreino=@id_planoTreino";
                cmd.Parameters.AddWithValue("@id_planoTreino", this.Id);

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

                cmd.CommandText = "delete from planoTreino where id_planoTreino=@id_planoTreino";
                cmd.Parameters.AddWithValue("@id_planoTreino", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o plano de treino " + this.Id);
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

        #region Select com INNER JOIN
        public DataTable selectAll(string options = "")
        {
            //MySqlDataAdapter da = new MySqlDataAdapter("Select * from planoTreino Inner join fichaTreino on planoTreino.id_planoTreino = fichaTreino.idPlanoTreino join fichaDetalhe on fichaTreino.id_fichaTreino = fichaDetalhe.idFichaTreino;" + options, dbConnection.Conecta);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from planoTreino Inner join fichaTreino on planoTreino.id_planoTreino = fichaTreino.idPlanoTreino join fichaDetalhe on fichaTreino.id_fichaTreino = fichaDetalhe.idFichaTreino join alunos on planoTreino.idAluno = alunos.id_aluno WHERE planoTreino.situacao = 1 group by id_planoTreino order by id_planoTreino;" + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Select para realizar pesquisa
        public DataTable selectPesquisa(string options = "")
        {
            //MySqlDataAdapter da = new MySqlDataAdapter("Select * from planoTreino Inner join fichaTreino on planoTreino.id_planoTreino = fichaTreino.idPlanoTreino join fichaDetalhe on fichaTreino.id_fichaTreino = fichaDetalhe.idFichaTreino;" + options, dbConnection.Conecta);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from planoTreino Inner join fichaTreino on planoTreino.id_planoTreino = fichaTreino.idPlanoTreino join fichaDetalhe on fichaTreino.id_fichaTreino = fichaDetalhe.idFichaTreino join alunos on planoTreino.idAluno = alunos.id_aluno" + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Select
        public DataTable select(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from planoTreino " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar os dados do plano treino
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from planoTreino " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PlanoTreino plano = new PlanoTreino();

                plano.Id = Convert.ToInt16(dr["id_planoTreino"]);
                plano.IdAluno = Convert.ToInt16(dr["idAluno"]);
                plano.IdTreinador = Convert.ToInt16(dr["idTreinador"]);
                plano.IdObjetivo = Convert.ToInt16(dr["idObjetivo"]);
                plano.DataInicio = dr["dataInicio"].ToString();
                plano.VezesSemana = Convert.ToInt16(dr["vezesSemana"]);
                plano.Situacao = Convert.ToBoolean(dr["situacao"]);

                dados.Add(plano);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Select para verificar o nome do treino
        public DataTable verificacaoNomeTreino(string options = "")
        {
            //MySqlDataAdapter da = new MySqlDataAdapter("Select * from planoTreino Inner join fichaTreino on planoTreino.id_planoTreino = fichaTreino.idPlanoTreino join fichaDetalhe on fichaTreino.id_fichaTreino = fichaDetalhe.idFichaTreino;" + options, dbConnection.Conecta);
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT f.nomeFicha, p.idAluno, p.situacao, f.situacao FROM planoTreino p INNER JOIN fichaTreino f on p.id_planoTreino = f.idPlanoTreino " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Select para verificar o nome do aluno
        public DataTable verificacaoNomeAluno(string options = "")
        {
            //MySqlDataAdapter da = new MySqlDataAdapter("Select * from planoTreino Inner join fichaTreino on planoTreino.id_planoTreino = fichaTreino.idPlanoTreino join fichaDetalhe on fichaTreino.id_fichaTreino = fichaDetalhe.idFichaTreino;" + options, dbConnection.Conecta);
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM planoTreino " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

    }
}
