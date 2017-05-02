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
    class LogsDAO: LogsTO, ICadastro
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
                cmd.CommandText = "insert into logs(idUsuario, idAcao, data, hora) values(@idUsuario, @idAcao, @data, @hora); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@idUsuario", this.IdUsuario);
                cmd.Parameters.AddWithValue("@idAcao", this.IdAcao);
                cmd.Parameters.AddWithValue("@data", this.Data);
                cmd.Parameters.AddWithValue("@hora", this.Hora);

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

        #region Select
        public DataTable select(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT l.id_log, l.data, l.hora, u.nome, a.descricao  FROM logs l INNER JOIN usuarios u ON l.idUsuario = u.id_login INNER JOIN acoes a ON l.idAcao = a.id_acao " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para realizar pesquisa
        //Metodo para realizar pesquisa
        public DataTable selectPesquisa(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from logs " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar os dados do log
        //Metodo para retornar os dados do log
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from logs " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Logs logs = new Logs();
                logs.Id = Convert.ToInt16(dr["id_log"]);
                logs.IdAcao = Convert.ToInt16(dr["idAcao"]);
                logs.Data = dr["data"].ToString();
                logs.Hora = dr["hora"].ToString();
                logs.IdUsuario = Convert.ToInt16(dr["idUsuario"]);
                dados.Add(logs);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Traz o maior id do banco do usuario que ta acessando o sistema
        //Traz o maior id do banco do usuario que ta acessando o sistema.
        public ArrayList selectArrayMaxId(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT id_log, idUsuario, idAcao, data, hora FROM logs " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Logs logs = new Logs();
                logs.Id = Convert.ToInt16(dr["id_log"]);
                logs.Data = dr["data"].ToString();
                logs.Hora = dr["hora"].ToString();
                logs.IdUsuario = Convert.ToInt16(dr["idUsuario"]);
                dados.Add(logs);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Update
        public void update()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Delete
        public void delete()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
