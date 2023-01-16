class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");
        int idade; //Preciso colocar o tipo de variavel antes, nesse caso, "int" para inteiro. 
        idade = 27; // Se eu quisesse colocar o valor da idade como 3 x 2 ele traria o valor também
        Console.WriteLine(idade);

        idade = 10 + 4;
        Console.WriteLine(idade);

        idade = 280;
        Console.WriteLine(idade);

        idade = 8;
        Console.Write(idade); //Nesse caso como exemplo, usamos apenas Write
                                //a impressão sairá na mesma linha sem nova linha

        Console.WriteLine("Tecle ENTER para fechar");
        Console.ReadLine();

    }
}