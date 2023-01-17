using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6 Atribuição de Variaveis");

        int idade = 30;
        int idadeAna = idade;
        Console.WriteLine(idadeAna);


        // Dados quanto as funções do tipo PRIMITIVO:

        //bool	1 byte	true e false
        //byte    1 byte  0 a 255
        //sbyte   1 byte  -128 a 127
        //short   2 bytes - 32768 a 32767
        //ushort  2 bytes 0 a 65535
        //int 4 bytes - 2147483648 a 2147483647
        //uint    4 bytes 0 a 4294967295
        //long    8 bytes - 9223372036854775808L a 9223372036854775807L
        //ulong   8 bytes 0 a 18446744073709551615
        //float   4 bytes Números até 10 elevado a 38.Exemplo: 10.0f, 12.5f
        //double  8 bytes Números até 10 elevado a 308.Exemplo: 10.0, 12.33
        //decimal 16 bytes Números com até 28 casas decimais. Exemplo: 10.991m, 33.333m
        //char    2 bytes Caracteres delimitados por aspas simples. Exemplo: 'a', 'ç'. 'o'.



        Console.WriteLine("Tecle para fechar !");
        Console.ReadLine(); 
    }
}
