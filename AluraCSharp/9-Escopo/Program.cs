using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("8 Condicionais If e Else - Pate 2");

        int idade = 17;
        int acompanhantes = 0;
        bool acompanhado = acompanhantes > 1;

        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
            Console.WriteLine(textoAdicional);
        }

        else
        {
            textoAdicional = "João não está acompanhado";
            Console.WriteLine(textoAdicional);
        }

        Console.WriteLine(@"


            ");


        if (idade >= 18 || acompanhantes > 1) // O "OU" no C# é representado por dois pipes || , no caso a condição "E" é representado por &&
        {
            Console.WriteLine("O usuario pode entrar ");

        }
        else
        {

            Console.WriteLine("O usuario não pode entrar");

        }


        //Trabalhando com Booleanos:
        bool entrada = true;
        if (entrada)
        {
            Console.WriteLine("pode entrar");
        }

        Console.WriteLine(@"
        ");


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}