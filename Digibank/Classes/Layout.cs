using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digibank.Classes
{
    public class Layout
    {
        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                ");
            Console.WriteLine("            Digite a opção desejada:            ");
            Console.WriteLine("            ==============================      ");
            Console.WriteLine("             1 - Criar Conta                    ");
            Console.WriteLine("            ==============================      ");
            Console.WriteLine("             2 - Entrar com CPF e Senha         ");
            Console.WriteLine("            ==============================      ");
        }
    }
}
