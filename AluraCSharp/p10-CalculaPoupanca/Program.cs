//obs: nesse projeto foi adicionado uma letra na frente do 10 pois se não o C# Adicionaria nosso projeto logo após o 1
using System;

class Programa { 

    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;

        //Rendimento de 0.5% (0.005) a.M
        
        int mes = 1;
        
        while(mes <= 12){

            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês "+ mes + " Seu montante é: " + investimento);
            mes = mes + 1;

        }
        Console.WriteLine(@"
Tecle ENTER para fechar! ");
        Console.ReadLine();
    }
}
