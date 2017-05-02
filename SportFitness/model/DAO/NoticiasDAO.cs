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

namespace SportFitness.model
{
    class NoticiasDAO : NoticiasTO, ICadastro
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
                cmd.CommandText = "insert into noticias(data, titulo, texto, idUsuario) values(@data, @titulo, @texto, @idUsuario); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@data", this.Data);
                cmd.Parameters.AddWithValue("@titulo", this.Titulo);
                cmd.Parameters.AddWithValue("@texto", this.Texto);
                cmd.Parameters.AddWithValue("@idUsuario", this.IdUsuario);

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

                cmd.CommandText = "update noticias set data=@data, titulo=@titulo, texto=@texto, idUsuario=@idUsuario where id_noticia=@id_noticia";
                cmd.Parameters.AddWithValue("id_noticia", this.Id);
                cmd.Parameters.AddWithValue("@data", this.Data);
                cmd.Parameters.AddWithValue("@titulo", this.Titulo);
                cmd.Parameters.AddWithValue("@texto", this.Texto);
                cmd.Parameters.AddWithValue("@idUsuario", this.IdUsuario);

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

                cmd.CommandText = "delete from noticias where id_noticia=@id_noticia";
                cmd.Parameters.AddWithValue("@id_noticia", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir a noticia " + this.Id);
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * from noticias " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar os dados da notícia
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from noticias " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Noticias not = new Noticias();

                not.Id = Convert.ToInt16(dr["id_noticia"]);
                not.Data = dr["data"].ToString();
                not.Titulo = dr["titulo"].ToString();
                not.Texto = dr["texto"].ToString();
                not.IdUsuario = Convert.ToInt16(dr["idUsuario"]);

                dados.Add(not);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}
