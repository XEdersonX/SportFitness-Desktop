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
    class TreinosDAO : TreinosTO, ICadastro
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
                cmd.CommandText = "insert into treinos(idAluno, idExercicio, repeticoes, intervalo, numSerie, letraTreino) values(@idAluno, @idExercicio, @repeticoes, @intervalo, @numSerie, @letraTreino); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@idAluno", this.IdAluno);
                cmd.Parameters.AddWithValue("@idExercicio", this.IdExercicio);
                cmd.Parameters.AddWithValue("@repeticoes", this.Repeticoes);
                cmd.Parameters.AddWithValue("@intervalo", this.Intervalo);
                cmd.Parameters.AddWithValue("@numSerie", this.NumSerie);
                cmd.Parameters.AddWithValue("@letraTreino", this.LetraTreino);
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

                cmd.CommandText = "update treinos set idAluno=@idAluno, idExercicio = @idExercicio, repeticoes = @repeticoes, intervalo = @intervalo, numSerie = @numSerie, letraTreino = @letraTreino where id_treino=@id_treino";
                cmd.Parameters.AddWithValue("@idAluno", this.IdAluno);
                cmd.Parameters.AddWithValue("@id_treino", this.Id);
                cmd.Parameters.AddWithValue("@idExercicio", this.IdExercicio);
                cmd.Parameters.AddWithValue("@repeticoes", this.Repeticoes);
                cmd.Parameters.AddWithValue("@intervalo", this.Intervalo);
                cmd.Parameters.AddWithValue("@numSerie", this.NumSerie);
                cmd.Parameters.AddWithValue("@letraTreino", this.LetraTreino);
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

                cmd.CommandText = "delete from treinos where id_treino=@id_treino";
                cmd.Parameters.AddWithValue("@id_treino", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o Treino  " + this.Id);
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
            MySqlDataAdapter da = new MySqlDataAdapter("select t.repeticoes t.intervalo as carga t.numSerie e.nome e.grupoMuscular from treinos as t inner join alunos as a on t.idAluno = a.idAluno inner join exercicios as e on t.idExercicio = e.id_exercicio " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

    }
}