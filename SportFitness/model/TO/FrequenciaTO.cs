using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class FrequenciaTO
    {
        public int Id { set; get; }
        public int IdAluno { set; get; }
        public int IdTreino { set; get; }
        public string Data { set; get; }
        public string Hora { set; get; }
    }
}
