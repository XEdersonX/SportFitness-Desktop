using sportFitness;
using SportFitness.model.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SportFitness.model.DAO
{
    class PalavrasProibidasDAO : PalavrasProibidasTO, ICadastro
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * from palavrasProibidas " + options, dbConnection.Conecta);
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

    }
}
