using System;

class Programa
{

    static void Main(string[] args)
    {
        double salario = 30000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;//convertemos o double em inteiro
        Console.WriteLine(salarioInteiro);

        long x = 200000000000000000; //Para valores muito grandes temos que usar o long
        Console.WriteLine(x);                               //ao invés do int.

        short y = 1500; //Pra trabalhar com numeros menórias até 16 bits
        Console.WriteLine(y);

        double a = 30.0;
        Console.WriteLine("O valor é "+ (int)a + " !");

        float altura = 1.62f;// no c# geralmente usamos o double ao invés do Float, e para que ele
        Console.WriteLine(altura);          // funcione, deve por um f minusculo no final do valo.

        Console.WriteLine("Tecle Enter para encerrar");
        Console.ReadLine();
    }
}