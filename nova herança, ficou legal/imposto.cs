using System;

class Imposto
{

    // metodos
    public virtual void  valealimetancao(Double salario)
    {
        Console.WriteLine("Desconto padrao do vale alimentação R$ "+salario * 0.1);


    }
    public virtual void valetransporte(Double salario)
    {
        Console.WriteLine("Desconto padrao do vale transporte R$ " + salario * 0.06);


    }


}