using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("7 Condicionais If e Else");

        int idade = 17;
        int acompanhantes = 0;
        if (idade >= 18) {
            Console.WriteLine("O usuario é MAIOR de idade! ");
        
        }
        else
        {
            if (acompanhantes > 0)
            {
                Console.WriteLine("O usuario menor de idade está acompanhado");
            }
            else
            {
                Console.WriteLine("O usuario é MENOR de idade e não tem acompanhante!");
            }
            
        }



        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}