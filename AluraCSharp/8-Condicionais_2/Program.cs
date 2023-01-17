using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("8 Condicionais If e Else - Pate 2");

        int idade = 17;
        int acompanhantes = 0;
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
        if(entrada)
        {
            Console.WriteLine("pode entrar");
        }




        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}