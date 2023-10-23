using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUTURA_DE_ESCOLHA_IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args) {

            string nome = "";
            Console.WriteLine("DIGITE O SEU NOME");
            nome = Console.ReadLine();

            if (nome == "willian")
            {
                Console.WriteLine("seu nome é");
                Console.WriteLine(nome);
            }
            else
            {
                Console.WriteLine("CODIGO NAO ACEITO, VOLTE AO COMEÇO");
            }






            Console.ReadLine();
        }
    }
}
