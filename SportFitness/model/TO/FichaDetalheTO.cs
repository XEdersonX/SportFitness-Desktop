using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class FichaDetalheTO
    {
        public int Id { set; get; }
        public int IdFichaTreino { set; get; }
        public int IdExercicio { set; get; }
        public int Series { set; get; }
        public int Repeticoes { set; get; }
        public int Carga { set; get; }
    }
}
