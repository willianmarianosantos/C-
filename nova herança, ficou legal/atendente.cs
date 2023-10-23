using System;

class Atendente : Imposto
{
    public override void valealimetancao(double salario)
    {
        Console.WriteLine("Desconto atendente do vale alimentação R$ " + salario * 0.1);




    }




}