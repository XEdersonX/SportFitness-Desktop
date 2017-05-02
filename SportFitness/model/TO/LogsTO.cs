using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class LogsTO
    {

        public int Id { set; get; }
        public int IdUsuario { set; get; }
        public int IdAcao { set; get; }
        public string Data { set; get; }
        public string Hora { set; get; }

    }
}
