using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");
        double salario; //Variavel com pontos flutuante
        salario = 300.10;
        Console.WriteLine(salario);

        double valor;
        valor = 7.0 / 5; //OBS: Nesse caso, para que a variavel com Ponto Flutuante
                         //identifique o resultado deve conter um valor com virgula
                         //inserimos ao invés de 7/5 o valor 7.0 /5.
        Console.WriteLine(valor);

        Console.WriteLine("Tecle ENTER para fechar");
        Console.ReadLine();
    }
}