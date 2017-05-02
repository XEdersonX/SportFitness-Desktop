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
    class FrequenciaDAO : FrequenciaTO, ICadastro
    {
        #region Delete
        public void delete()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Insert
        public void insert()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Select
        public DataTable select(string options = "")
        {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT f.id_frequencia, a.nome, t.nomeFicha, f.data, f.duracao FROM frequencia f INNER JOIN fichaTreino t ON f.idTreino = t.id_fichaTreino INNER JOIN alunos a ON f.idAluno = a.id_aluno " + options, dbConnection.Conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
        }
        #endregion

        #region Método para realizar pesquisa
        //Metodo para realizar pesquisa
        public DataTable selectPesquisa(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT f.id_frequencia, a.nome, t.nomeFicha, f.data, f.duracao FROM frequencia f INNER JOIN fichaTreino t ON f.idTreino = t.id_fichaTreino INNER JOIN alunos a ON f.idAluno = a.id_aluno " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Update
        public void update()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Método para retornar os dados da notícia
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from frequencia " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Frequencia not = new Frequencia();

                not.Id = Convert.ToInt16(dr["id_frequencia"]);
                not.Data = dr["data"].ToString();
                not.Hora = dr["hora"].ToString();
                not.IdAluno = Convert.ToInt16(dr["idAluno"]);
                not.IdTreino = Convert.ToInt16(dr["idTreino"]);

                dados.Add(not);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion
    }
}
