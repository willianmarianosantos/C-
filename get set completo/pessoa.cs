

class Pessoa
{

    // private string nome = "will";

    // public string Nome { get; set; } // nao encontra a classe privada ?


    public string Nome { get; private set; } = "will";  // funciona perfeitamente
     //get {return nome;}   // obter informação
     //  set {nome = value;} // enviar informação
     //}



    private int salarioa = 5;
    public int  salariob = 20;



    public Pessoa(int salarioa)
    {
        
        Console.WriteLine(salarioa = 2 + salariob + this.salarioa);
        
     }


}

