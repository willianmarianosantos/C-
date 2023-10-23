using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nova_herança
{
    class Program
    {

        public static void Main(string[] args)
        {



            // instancia gerente
            Imposto salariog = new Gerente();
            salariog.valealimetancao(100);
            Console.WriteLine("----------------");

            // instancia atendente
            Imposto salarioA = new Atendente();
            salarioA.valealimetancao(100);
            Console.WriteLine("-----------------");

            // instancia estagiario
            Estagiario will=new Estagiario();
            will.salario = 9.90;
            will.mensagem();
            




        }
    }
}