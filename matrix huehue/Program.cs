using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_huehue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] produtos = { 5, 10};

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);


            produtos[0] = 12;

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.ReadLine();

        }
    }
}
