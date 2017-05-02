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
    class TreinadoresDAO : TreinadoresTO, ICadastro
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
                cmd.CommandText = "insert into treinadores(nome, email, telefoneRes, telefoneCel, dataNasc, cpf, cep, endereco, bairro, observacao) values(@nome, @email, @telefoneRes, @telefoneCel, @dataNasc, @cpf, @cep, @endereco, @bairro, @observacao); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@telefoneRes", this.TelefoneRes);
                cmd.Parameters.AddWithValue("@telefoneCel", this.TelefoneCel);
                cmd.Parameters.AddWithValue("@dataNasc", this.DataNasc);
                cmd.Parameters.AddWithValue("@cpf", this.Cpf);
                cmd.Parameters.AddWithValue("@cep", this.Cep);
                cmd.Parameters.AddWithValue("@endereco", this.Endereco);
                cmd.Parameters.AddWithValue("@bairro", this.Bairro);
                cmd.Parameters.AddWithValue("@observacao", this.Observacao);
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

                cmd.CommandText = "update treinadores set nome=@nome, email = @email, telefoneRes = @telefoneRes, telefoneCel = @telefoneCel, dataNasc = @dataNasc, cpf = @cpf, cep = @cep, endereco = @endereco, bairro = @bairro, observacao = @observacao where id_treinador=@id_treinador";
                cmd.Parameters.AddWithValue("@id_treinador", this.Id);
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@telefoneRes", this.TelefoneRes);
                cmd.Parameters.AddWithValue("@telefoneCel", this.TelefoneCel);
                cmd.Parameters.AddWithValue("@dataNasc", this.DataNasc);
                cmd.Parameters.AddWithValue("@cpf", this.Cpf);
                cmd.Parameters.AddWithValue("@cep", this.Cep);
                cmd.Parameters.AddWithValue("@endereco", this.Endereco);
                cmd.Parameters.AddWithValue("@bairro", this.Bairro);
                cmd.Parameters.AddWithValue("@observacao", this.Observacao);
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

                cmd.CommandText = "delete from treinadores where id_treinador=@id_treinador";
                cmd.Parameters.AddWithValue("@id_treinador", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o treinador  " + this.Id);
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * from treinadores " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Select para verificar o Email
        public DataTable selectVerificacaoEmail(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from treinadores " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar os dados do treinador
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from treinadores " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Treinadores trein = new Treinadores();
                trein.Id = Convert.ToInt16(dr["id_treinador"]);
                trein.Nome = dr["nome"].ToString();
                trein.Email = dr["email"].ToString();
                trein.TelefoneRes = dr["telefoneRes"].ToString();
                trein.TelefoneCel = dr["telefoneCel"].ToString();
                trein.DataNasc = dr["dataNasc"].ToString();
                trein.Cpf = dr["cpf"].ToString();
                trein.Cep = dr["cep"].ToString();
                trein.Endereco = dr["endereco"].ToString();
                trein.Bairro = dr["bairro"].ToString();
                trein.Observacao = dr["observacao"].ToString();
                dados.Add(trein);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}