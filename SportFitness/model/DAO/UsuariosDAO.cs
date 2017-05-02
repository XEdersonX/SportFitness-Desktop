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
    class UsuariosDAO : UsuariosTO, ICadastro
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
                cmd.CommandText = "insert into usuarios(nome, senha, isAdmin) values(@nome, @senha, @isAdmin); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@senha", this.Senha);
                cmd.Parameters.AddWithValue("@isAdmin", this.IsAdmin);
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

                cmd.CommandText = "update usuarios set nome=@nome, senha = @senha, isAdmin = @isAdmin where id_login=@id_login";
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@id_login", this.Id);
                cmd.Parameters.AddWithValue("@senha", this.Senha);
                cmd.Parameters.AddWithValue("@isAdmin", this.IsAdmin);
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

        #region Update para verificar a senha
        public void updateVerificaSenha()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "update usuarios set nome=@nome, isAdmin = @isAdmin where id_login=@id_login";
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@id_login", this.Id);
                cmd.Parameters.AddWithValue("@isAdmin", this.IsAdmin);
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

                cmd.CommandText = "delete from usuarios where id_login=@id_login";
                cmd.Parameters.AddWithValue("@id_login", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o usuário  " + this.Id);
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * from usuarios " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        #endregion

        #region Método para retornar os dados do usuário
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from usuarios " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuarios usuario = new Usuarios();
                usuario.Id = Convert.ToInt16(dr["id_login"]);
                usuario.Nome = dr["nome"].ToString();
                usuario.Senha = dr["senha"].ToString();
                usuario.IsAdmin = dr["isAdmin"].ToString();
                dados.Add(usuario);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}