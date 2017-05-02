using MySql.Data.MySqlClient;
using sportFitness;
using SportFitness.model;
using SportFitness.model.DAO;
using SportFitness.model.TO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.DAO
{
    class GrupoMuscularDAO : GrupoMuscularTO, ICadastro
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
                cmd.CommandText = "insert into grupoMuscular(nome) values(@nome); select @@IDENTITY;";
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

                cmd.CommandText = "update grupoMuscular set nome=@nome where id_grupoMuscular=@id_grupoMuscular";
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@id_grupoMuscular", this.Id);
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

                cmd.CommandText = "delete from grupoMuscular where id_grupoMuscular=@id_grupoMuscular";
                cmd.Parameters.AddWithValue("@id_grupoMuscular", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o grupo muscular " + this.Id);
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * from grupoMuscular " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar os dados do Grupo Muscular
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from grupoMuscular " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                GrupoMuscular grupo = new GrupoMuscular();
                grupo.Id = Convert.ToInt16(dr["id_grupoMuscular"]);
                grupo.Nome = dr["nome"].ToString();
                dados.Add(grupo);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}
