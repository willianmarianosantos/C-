using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_E_OUTROS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;
            int c = 200;

            // SE MULHER && IDADE => 25 -> ENTRA NA FESTA DE GRAÇA


            //se 
            if (a < b || a > c)  { Console.WriteLine(" É verdade"); }


            else if (a > c) { Console.WriteLine("Executou else if"); }


            // se não
            else  {  Console.WriteLine(" E MENTIRA "); }


            Console.ReadLine();     






        }
    }
}
