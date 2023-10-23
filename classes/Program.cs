using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {

        private class jogadorpower
        {
            private int power = 12;
        }

        public class jogador
        {
            public int energia = 100;
            public bool vivo = true;
        }

        static void Main()
        {
            jogador j1 = new jogador();
            jogador j2 = new jogador();
            jogadorpower j3 = new jogadorpower();
            // "new" reserva um espaço na memoria para o objeto, cada objeto de casse é diferente um do outro na memoria 

            Console.WriteLine("jnergia do jogador 1: {0} e está {1}", j1.energia, j1.vivo);
            Console.WriteLine("jnergia do jogador 2 está: {0}", j2.vivo);
            //  Console.WriteLine("jnergia do jogador 2 está: {0}", j3.); classe privada nao posso usar suas variaveis 

        }
    }
}
