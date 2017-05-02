using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class PlanoTreinoTO
    {
        public int Id { set; get; }
        public int IdAluno { set; get; }
        public int IdTreinador { set; get; }
        public int IdObjetivo { set; get; }
        public string DataInicio { set; get; }
        public int VezesSemana { set; get; }
        public Boolean Situacao { set; get; }
    }
}
