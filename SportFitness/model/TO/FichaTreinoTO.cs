using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class FichaTreinoTO
    {
        public int Id { set; get; }
        public int IdPlanoTreino { set; get; }
        public char NomeFicha { set; get; }
        public int NumeroTreinosRealizados { set; get; }
        public Boolean Situacao { set; get; }
    }
}
