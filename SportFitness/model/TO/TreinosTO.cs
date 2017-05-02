using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class TreinosTO
    {
        public int Id { set; get; }
        public int IdAluno { set; get; }
        public int IdExercicio { set; get; }
        public int Repeticoes { set; get; }
        public int Intervalo { set; get; }
        public int NumSerie { set; get; }
        public char LetraTreino { set; get; }
        public string nomeExercicio { set; get; }
        public string nomeGrupo { set; get; }
    }
}
