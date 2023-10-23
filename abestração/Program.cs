using System;


class Veiculo // base
{
    public int velatual;

    private int velmax;

    protected bool ligado;


    public  Veiculo(int velmax)
    {

        velatual = 0;
        this.velmax = velmax;
        ligado = false;


    }
    public bool getligado() { return ligado; }
    public int getvelmax() { return velmax; }   
}




class Carro:Veiculo // derivada de veiuculo
{
    public string nome;
    public Carro(string nome, int vm):base(vm)
    {
        this.nome = nome;
        ligado=true;





    }

}




class aula36 // main
{

    public static void Main() {

        Carro carro = new Carro("bonitao", 120);
        Console.WriteLine("Nome: {0}", carro.nome);
        Console.WriteLine("Nome: {0}", carro.velatual);
        Console.WriteLine("Nome: {0}", carro.getvelmax());
        Console.WriteLine("Nome: {0}", carro.getligado());



    }
}


