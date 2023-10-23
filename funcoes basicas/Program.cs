using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes_basicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerarPreco(-20);
            Console.ReadLine();



        }
        static void GerarPreco(int preco)
        {

            // ABS FUNCÃO PARA MODULO, EXISTEM VARIAS PARA NUMEROS



            int precoabs = Math.Abs(preco);
            int valorfinal = precoabs + (2 * precoabs);
            Console.WriteLine("valor final" + valorfinal);


        }


    }
}
