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
using System.Windows.Forms;

namespace SportFitness.model.DAO
{
    class FichaTreinoDAO : FichaTreinoTO, ICadastro
    {
        #region Obter o próximo ID auto-incremento no mysql do plano de treino
        public int getIdPlanoTreino()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = dbConnection.Conecta;
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("Select Auto_Increment from information_schema.tables where table_schema = 'SportFitness' and table_name = 'planoTreino'", cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            int id_planoTreino = 0;

            while (dr.Read())
            {
                id_planoTreino = Convert.ToInt16(dr.GetString(0)) - 1;
            }

            return id_planoTreino;
        }
        #endregion

        #region Obter o próximo ID auto-incremento no mysql da ficha de treino
        public int getIdFichaTreino()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = dbConnection.Conecta;
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("Select Auto_Increment from information_schema.tables where table_schema = 'SportFitness' and table_name = 'fichaTreino'", cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            int id_fichaTreino = 0;

            while (dr.Read())
            {
                id_fichaTreino = Convert.ToInt16(dr.GetString(0)) - 1;
            }

            return id_fichaTreino;
        }
        #endregion

        #region insertIdPlanoTreino
        public void insertIdPlanoTreino()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = dbConnection.Conecta;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;

            int id_planoTreino = getIdPlanoTreino();
            int id_fichaTreino = getIdFichaTreino();

            cmd.CommandText = "update fichaTreino set idPlanoTreino=@idPlanoTreino where id_fichaTreino=@id_fichaTreino";
            cmd.Parameters.AddWithValue("@id_fichaTreino", id_fichaTreino);
            cmd.Parameters.AddWithValue("@idPlanoTreino", id_planoTreino);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        #endregion

        #region Insert
        public void insert()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "insert into fichaTreino(nomeFicha, idPlanoTreino, numeroTreinosRealizados, situacao) values(@nomeFicha, @idPlanoTreino, @numeroTreinosRealizados, @situacao); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nomeFicha", this.NomeFicha);
                cmd.Parameters.AddWithValue("@idPlanoTreino", this.IdPlanoTreino);
                cmd.Parameters.AddWithValue("@numeroTreinosRealizados", this.NumeroTreinosRealizados);
                cmd.Parameters.AddWithValue("@situacao", this.Situacao);

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

                cmd.CommandText = "update fichaTreino set situacao=@situacao where id_fichaTreino=@id_fichaTreino";
                cmd.Parameters.AddWithValue("@id_fichaTreino", this.Id);
                //cmd.Parameters.AddWithValue("@idPlanoTreino", this.IdPlanoTreino);
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

        #region Delete
        public void delete()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "delete from fichaTreino where id_fichaTreino=@id_fichaTreino";
                cmd.Parameters.AddWithValue("@id_fichaTreino", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir a ficha de treino " + this.Id);
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

        public void updateDelete()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "update fichaTreino set situacao = 0 where idPlanoTreino=@idPlanoTreino";
                cmd.Parameters.AddWithValue("@idPlanoTreino", this.IdPlanoTreino);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        #region Select
        public DataTable select(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from fichaTreino " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region Select para retornar o id do ultimo plano de treino
        public int selectUltimoId()
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = dbConnection.Conecta;
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT id_planoTreino FROM planoTreino ORDER BY id_planoTreino DESC LIMIT 1", cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            int id_fichaTreino = 0;

            while (dr.Read())
            {
                id_fichaTreino = Convert.ToInt16(dr.GetString(0)) - 1;
            }

            return id_fichaTreino;
        }
        #endregion

        #region Método para retornar os dados da ficha de treino
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from fichaTreino " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                FichaTreino ficha = new FichaTreino();

                ficha.Id = Convert.ToInt16(dr["id_fichaTreino"]);
                //ficha.IdPlanoTreino = Convert.ToInt16(dr["idPlanoTreino"]);
                ficha.NomeFicha = Convert.ToChar(dr["nomeFicha"]);
                ficha.NumeroTreinosRealizados = Convert.ToInt16(dr["numeroTreinosRealizados"]);
                ficha.Situacao = Convert.ToBoolean(dr["situacao"]);

                dados.Add(ficha);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Método para retornar os dados da ficha de treino
        public ArrayList selectArrayback(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from fichaTreino " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                FichaTreino ficha = new FichaTreino();

                ficha.Id = Convert.ToInt16(dr["id_fichaTreino"]);
                ficha.IdPlanoTreino = Convert.ToInt16(dr["idPlanoTreino"]);
                ficha.NomeFicha = Convert.ToChar(dr["nomeFicha"]);
                ficha.NumeroTreinosRealizados = Convert.ToInt16(dr["numeroTreinosRealizados"]);
                ficha.Situacao = Convert.ToBoolean(dr["situacao"]);

                dados.Add(ficha);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Método para retornar os dados do aluno
        //Metodo para retornar os dados do aluno
        public ArrayList selectArray1(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from fichaTreino where idPlanoTreino=" + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                FichaTreino ficha = new FichaTreino();
                ficha.Id = Convert.ToInt16(dr["id_fichaTreino"]);
                ficha.NomeFicha = Convert.ToChar(dr["nomeFicha"].ToString());
                //alunos.IdUsuario = Convert.ToInt16(dr["idUsuario"]);
                dados.Add(ficha);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}
