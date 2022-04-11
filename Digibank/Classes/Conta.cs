using Digibank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digibank.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public double ConsultaSalto()
        {
            throw new NotImplementedException();
        }

        public void Deposita(double valor)
        {
            throw new NotImplementedException();
        }

        public string GetCodigoDoBanco()
        {
            throw new NotImplementedException();
        }

        public string GetNumeroAgencia()
        {
            throw new NotImplementedException();
        }

        public string GetNumeroConta()
        {
            throw new NotImplementedException();
        }

        public bool Saca(double valor)
        {
            throw new NotImplementedException();
        }
    }
}
