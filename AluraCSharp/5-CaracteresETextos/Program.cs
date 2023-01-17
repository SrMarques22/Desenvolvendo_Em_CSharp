using System;
using System.ComponentModel;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 Caracteres e Textos");

        char letra = 'a'; //Em casos de tipo CHAR deve se usar aspas simples
        Console.WriteLine(letra);

        //Curiosidade: Existe um pdrão de tabela ASCII no qual podemos ver qual
        //é o código que representa cada letra e caracter, a mespa pode ser
        //analisada aqui https://web.fe.up.pt/~ee96100/projecto/Tabela%20ascii.htm
        //vamos ver no exemplo abaixo que o código 65 representa um A maiusculo.

        letra = (char)65 ; //Lembrando que para que a conversão funcione,
                          //deve ser colocado o (char) e o resultado será um A Maiusculo.
        Console.WriteLine(letra);

        List<char> lista = new List<char>();
        lista.Add((char)76);
        lista.Add((char)117);
        lista.Add((char)105);
        lista.Add((char)115);

        lista.Add((char)95);

        lista.Add((char)77);
        lista.Add((char)101);

        lista.Add((char)95);

        lista.Add((char)82);
        lista.Add((char)101);
        lista.Add((char)115);
        lista.Add((char)112);
        lista.Add((char)101);
        lista.Add((char)105);
        lista.Add((char)116);
        lista.Add((char)97);



        foreach (char a in lista)
        {
            Console.Write(a);
           

        }
        
        Console.WriteLine("");
        string primeiraFrase = "Alura - Cursos de TI ";
        Console.WriteLine(primeiraFrase + "2023");

        string segundaFrase = @"lista de códigos: 
- Python 
- C# 
- Java";
        //Dessa fora no exemplo acima, quando adicionamos o @ no inicio do valor da variavel em string, ele considera a formação no qual a gente deixa as
        //informações.
        Console.WriteLine(segundaFrase);

        Console.ReadLine();


        Console.WriteLine("Tecle Enter para sair");
        Console.ReadLine();
    }
}