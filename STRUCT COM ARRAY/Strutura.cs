struct Carro
{

    public string marca="";
    public string modelo="";
    public string cor="";


    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void Print()
    {
        Console.WriteLine("Marca..:{0}", this.marca);
        Console.WriteLine("Modelo.:{0}", this.modelo);
        Console.WriteLine("Cor....:{0}", this.cor);
    }

}

 class Program
 {

        public static void Main(string[] args)
        {


          Carro c1=new("fiat", "palio", "azul");

          // c1.marca = "fiat";
          // c1.modelo = "palio";
          // c1.cor = "preto";

          c1.Print();


         }

}





