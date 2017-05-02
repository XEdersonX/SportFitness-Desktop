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
    class Treinos : TreinosDAO
    {
        public static ArrayList listaLetras(string id)
        {
            ArrayList dados = new ArrayList();

            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);

            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select DISTINCT letraTreino as letra from treinos where idAluno = " + id + " order by letra DESC", cn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Treinos treino = new Treinos();
                treino.LetraTreino = Convert.ToChar(dr["letra"]);
                dados.Add(treino);
            }
            return dados;
        }

        public static ArrayList selectExercicios(string options = "")
        {
            ArrayList dados = new ArrayList();

            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);

            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select t.repeticoes, t.intervalo as carga, t.numSerie, e.nome as nomeExercicio, e.grupoMuscular as nomeGrupo from treinos as t inner join alunos as a on t.idAluno = a.id_aluno inner join exercicios as e on t.idExercicio = e.id_exercicio " + options, cn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Treinos treino = new Treinos();
                treino.Repeticoes = Convert.ToInt16(dr["repeticoes"]);
                treino.Intervalo = Convert.ToInt16(dr["carga"]);
                treino.NumSerie = Convert.ToInt16(dr["numSerie"]);
                treino.nomeExercicio = dr["nomeExercicio"].ToString();
                treino.nomeGrupo = dr["nomeGrupo"].ToString();
                dados.Add(treino);
            }
            return dados;
        }
    }
}
