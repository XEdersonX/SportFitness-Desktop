using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class AlunosTO
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public char Sexo { set; get; }
        public string Email { set; get; }
        public string TelefoneRes { set; get; }
        public string TelefoneCel { set; get; }
        public string DataNasc { set; get; }
        public string Cpf { set; get; }
        public int IdCidade { set; get; }
        public string Cep { set; get; }
        public string Endereco { set; get; }
        public string Bairro { set; get; }
        public string Observacao { set; get; }
        public string Senha { set; get; }
        public int IdUsuario { set; get; }
    }
}