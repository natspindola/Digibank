using Digibank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digibank.Classes
{
    class Pessoa
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Senha { get; private set; }
        public IConta Conta { get; set; }
    }
}
