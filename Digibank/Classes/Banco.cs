using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digibank.Classes
{
    public abstract class Banco
    {
        public Banco()
        {
            this.NomeDoBanco = "Digibank";
            this.CodigoDoBanco = "027";
        }

        public string NomeDoBanco { get; private set; }
        public string CodigoDoBanco { get; private set; }
    }
}
