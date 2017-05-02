using sportFitness;
using SportFitness.model.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;

namespace SportFitness.model.DAO
{
    class CidadesDAO : CidadesTO, ICadastro
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

            MySqlCommand cmd = new MySqlCommand("select * from cidades " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cidades cid = new Cidades();
                cid.Id = Convert.ToInt16(dr["id_cidade"]);
                cid.IdEstado = Convert.ToInt16(dr["idEstado"]);
                cid.Nome = dr["nome"].ToString();
               
                dados.Add(cid);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}
