using sportFitness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportFitness.model.TO;
using System.Collections;
using MySql.Data.MySqlClient;

namespace SportFitness.model.DAO
{
    class EstadosDAO : EstadosTO, ICadastro
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
            throw new NotImplementedException();
        }
        #endregion

        #region Update
        public void update()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Método para retornar os dados do aluno
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from estados " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Estados est = new Estados();
                est.Id = Convert.ToInt16(dr["id_estado"]);
                est.Nome = dr["nome"].ToString();
                est.Sigla = dr["sigla"].ToString();

                dados.Add(est);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}
