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
    class AlunosDAO : AlunosTO, ICadastro
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
                cmd.CommandText = "insert into alunos(nome, sexo, email, telefoneRes, telefoneCel, dataNasc, cpf, idCidade, cep, endereco, bairro, observacao, senha, idUsuario) values(@nome, @sexo, @email, @telefoneRes, @telefoneCel, @dataNasc, @cpf, @idCidade, @cep ,@endereco, @bairro, @observacao, @senha, @idUsuario); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@sexo", this.Sexo);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@telefoneRes", this.TelefoneRes);
                cmd.Parameters.AddWithValue("@telefoneCel", this.TelefoneCel);
                cmd.Parameters.AddWithValue("@dataNasc", this.DataNasc);
                cmd.Parameters.AddWithValue("@cpf", this.Cpf);
                cmd.Parameters.AddWithValue("@idCidade", this.IdCidade);
                cmd.Parameters.AddWithValue("@cep", this.Cep);
                cmd.Parameters.AddWithValue("@endereco", this.Endereco);
                cmd.Parameters.AddWithValue("@bairro", this.Bairro);
                cmd.Parameters.AddWithValue("@observacao", this.Observacao);
                cmd.Parameters.AddWithValue("@senha", this.Senha);
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

                cmd.CommandText = "update alunos set nome=@nome, sexo = @sexo,email = @email, telefoneRes = @telefoneRes, telefoneCel = @telefoneCel, dataNasc = @dataNasc,cpf = @cpf, idCidade = @idCidade, cep = @cep, endereco = @endereco, bairro = @bairro, observacao = @observacao, senha = @senha, idUsuario = @idUsuario where id_aluno=@id_aluno";
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@id_aluno", this.Id);
                cmd.Parameters.AddWithValue("@sexo", this.Sexo);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@telefoneRes", this.TelefoneRes);
                cmd.Parameters.AddWithValue("@telefoneCel", this.TelefoneCel);
                cmd.Parameters.AddWithValue("@dataNasc", this.DataNasc);
                cmd.Parameters.AddWithValue("@cpf", this.Cpf);
                cmd.Parameters.AddWithValue("@idCidade", this.IdCidade);
                cmd.Parameters.AddWithValue("@cep", this.Cep);
                cmd.Parameters.AddWithValue("@endereco", this.Endereco);
                cmd.Parameters.AddWithValue("@bairro", this.Bairro);
                cmd.Parameters.AddWithValue("@observacao", this.Observacao);
                cmd.Parameters.AddWithValue("@senha", this.Senha);
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

        #region Update sem a senha
        public void updateVerificaSenha()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "update alunos set nome=@nome, sexo = @sexo, email = @email, telefoneRes = @telefoneRes, telefoneCel = @telefoneCel, dataNasc = @dataNasc,cpf = @cpf, idCidade = @idCidade, cep = @cep, endereco = @endereco, bairro = @bairro, observacao = @observacao, idUsuario = @idUsuario where id_aluno=@id_aluno";
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@id_aluno", this.Id);
                cmd.Parameters.AddWithValue("@sexo", this.Sexo);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@telefoneRes", this.TelefoneRes);
                cmd.Parameters.AddWithValue("@telefoneCel", this.TelefoneCel);
                cmd.Parameters.AddWithValue("@dataNasc", this.DataNasc);
                cmd.Parameters.AddWithValue("@cpf", this.Cpf);
                cmd.Parameters.AddWithValue("@idCidade", this.IdCidade);
                cmd.Parameters.AddWithValue("@cep", this.Cep);
                cmd.Parameters.AddWithValue("@endereco", this.Endereco);
                cmd.Parameters.AddWithValue("@bairro", this.Bairro);
                cmd.Parameters.AddWithValue("@observacao", this.Observacao);
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

                cmd.CommandText = "delete from alunos where id_aluno=@id_aluno";
                cmd.Parameters.AddWithValue("@id_aluno", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o aluno " + this.Id);
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * from alunos " + options + " INNER JOIN cidades ON alunos.idCidade = cidades.id_cidade", dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Select para verificar o Email
        public DataTable selectVerificacaoEmail(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from alunos " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Select da pesquisa do sistema
        //Metodo para realizar pesquisa
        public DataTable selectPesquisa(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from alunos " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Método para retornar o sexo do aluno
        //Método para retornar o sexo do aluno
        public ArrayList selectSexo(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select sexo from alunos " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Alunos alunos = new Alunos();
                alunos.Sexo = Convert.ToChar(dr["sexo"]);
                //alunos.IdUsuario = Convert.ToInt16(dr["idUsuario"]);
                dados.Add(alunos);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Metodo para retornar a data de nascimento do aluno
        //Metodo para retornar a data de nascimento do aluno
        public ArrayList selectDataNasc(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select dataNasc from alunos " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Alunos alunos = new Alunos();
                alunos.DataNasc = dr["dataNasc"].ToString();
                //alunos.IdUsuario = Convert.ToInt16(dr["idUsuario"]);
                dados.Add(alunos);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Método para retornar os dados do aluno
        //Metodo para retornar os dados do aluno
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from alunos " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Alunos alunos = new Alunos();
                alunos.Id = Convert.ToInt16(dr["id_aluno"]);
                alunos.Nome = dr["nome"].ToString();
                alunos.Sexo = Convert.ToChar(dr["sexo"]);
                alunos.Email = dr["email"].ToString();
                alunos.TelefoneRes = dr["telefoneRes"].ToString();
                alunos.TelefoneCel = dr["telefoneCel"].ToString();
                alunos.DataNasc = dr["dataNasc"].ToString();
                alunos.Cpf = dr["cpf"].ToString();
                alunos.IdCidade = Convert.ToInt16(dr["idCidade"]);
                alunos.Cep = dr["cep"].ToString();
                alunos.Endereco = dr["endereco"].ToString();
                alunos.Bairro = dr["bairro"].ToString();
                alunos.Observacao = dr["observacao"].ToString();
                alunos.IdUsuario = Convert.ToInt16(dr["idUsuario"]);
                alunos.Senha = dr["senha"].ToString();
                //alunos.IdUsuario = Convert.ToInt16(dr["idUsuario"]);
                dados.Add(alunos);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

        #region Select do Grafico de sexo dos Alunos
        public static DataTable grafAlunosSexo()
        {
                MySqlDataAdapter da = new MySqlDataAdapter("select count(*) as numero, sexo from alunos group by sexo", dbConnection.Conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
        }
        #endregion

    }
}