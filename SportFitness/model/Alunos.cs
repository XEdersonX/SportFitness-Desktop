using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SportFitness.model.DAO;
using sportFitness;

namespace SportFitness.model
{
    class Alunos : AlunosDAO
    {
        public static ArrayList listaAluno(string nome)
        {
            ArrayList dados = new ArrayList();

            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);

            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select id_aluno as id, nome from alunos where nome like '%" + nome + "%' order by nome", cn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Alunos a = new Alunos();
                a.Id = Convert.ToInt16(dr["id"]);
                a.Nome = dr["nome"].ToString();
                dados.Add(a);
            }

            dr.Close();
            cn.Close();
            return dados;
        }

        public ArrayList calcIdade(int id)
        {
            ArrayList dados = new ArrayList();

            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);

            cn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT TIMESTAMPDIFF(YEAR, CONCAT(SUBSTR(dataNasc, 7, 4), '-', SUBSTR(dataNasc, 4, 2), '-', SUBSTR(dataNasc, 1, 2)), CURDATE()) AS age, dataNasc FROM alunos WHERE id_aluno = " + id, cn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dados.Add(dr["age"].ToString());
            }

            dr.Close();
            cn.Close();
            return dados;
        }
    }
}