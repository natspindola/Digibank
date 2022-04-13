using Digibank.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digibank.Contratos
{
    public interface IConta
    {
        void Deposita(double valor);
        bool Saca(double valor);
        double ConsultaSalto();
        string GetCodigoDoBanco();
        string GetNumeroAgencia();
        string GetNumeroDaConta();
        List<Extrato> Extrato();
    }
}
