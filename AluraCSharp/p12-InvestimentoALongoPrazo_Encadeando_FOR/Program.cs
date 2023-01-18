//obs: nesse projeto foi adicionado uma letra na frente do 10 pois se não o C# Adicionaria nosso projeto logo após o 1
using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Executando o pROJETO 12 - Investimento a Longo Prazo - ENCADEAMENTO FOR");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;

           
        }
        Console.WriteLine("Depois de 5 anos você terá RS: "+ investimento);

        Console.WriteLine(@"
Tecle ENTER para fechar! ");
        Console.ReadLine();
    }
}
