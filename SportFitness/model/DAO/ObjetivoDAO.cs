using sportFitness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportFitness.model.TO;
using MySql.Data.MySqlClient;
using System.Collections;

namespace SportFitness.model.DAO
{
    class ObjetivoDAO : ObjetivoTO, ICadastro
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
                cmd.CommandText = "insert into objetivo(nome) values(@nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", this.Nome);

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

                cmd.CommandText = "update objetivo set nome=@nome where id_objetivo=@id_objetivo";
                cmd.Parameters.AddWithValue("@id_objetivo", this.Id);
                cmd.Parameters.AddWithValue("@nome", this.Nome);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception ex)
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

                cmd.CommandText = "delete from objetivo where id_objetivo=@id_objetivo";
                cmd.Parameters.AddWithValue("@id_objetivo", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o objetivo " + this.Id);
                }
            }
            catch(Exception ex)
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * from objetivo " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar os dados do objetivo
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from objetivo " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Objetivo obj = new Objetivo();

                obj.Id = Convert.ToInt16(dr["id_objetivo"]);
                obj.Nome = dr["nome"].ToString();

                dados.Add(obj);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}
