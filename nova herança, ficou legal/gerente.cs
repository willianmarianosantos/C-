using System;

class Gerente : Imposto
{
   public override void valealimetancao(double salario)
    {
        Console.WriteLine("Desconto gerente do vale alimentação R$ " + salario * 0.2);




    }




}