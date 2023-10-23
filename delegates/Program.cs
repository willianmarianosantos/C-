namespace delegates;







public class Jogador
{
    public int energia = 100;
    public bool vivo = true;
}

static void Main()
{
    Jogador j1 = new Jogador();
    Console.WriteLine("Energia do Jogador 1: {0}", j1.energia);

}

