using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class NoticiasTO
    {
        public int Id { set; get; }
        public string Data { set; get; }
        public string Titulo { set; get; }
        public string Texto { set; get; }
        public int IdUsuario { set; get; }
    }
}
