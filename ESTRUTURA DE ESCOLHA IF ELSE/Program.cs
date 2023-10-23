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



            // OPERADORES LOGICOS 
            // E/AND = &&  
            // OU/OR = ||  



            string nome = "";
            Console.WriteLine("DIGITE O SEU NOME");
            nome = Console.ReadLine();

            if (nome == "willian") //SE
            {
                Console.WriteLine("seu nome é");
                Console.WriteLine(nome);
            }
            else if ( nome == "seidao"    )  //
            {
                Console.WriteLine("quase");
            }

            else //SE NÃO
            {
                Console.WriteLine("CODIGO NAO ACEITO, VOLTE AO COMEÇO");
            }
            Console.ReadLine();
        }
    }
}
