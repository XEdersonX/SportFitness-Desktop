using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class UsuariosTO
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public string Senha { set; get; }
        public string IsAdmin { set; get; }
    }
}