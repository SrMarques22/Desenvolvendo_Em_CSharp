using System;

class Programa_IR
{

    /*
    O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as regras de alíquota. Ele descobriu no site da receita o seguinte:

De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.
    */

    static void Main(string[] args)
    {

        double salario;
        

        //double salario = 3300.0;
        while (true) {

            Console.WriteLine("Digite seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario == 999) {
                break;
            }
        

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("O IR é de 7%, pode deduzi da declaração o valor de R$ 142.00");
            }
            if(salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("O IR é de 15% e pode deduzir R$ 350,00");
            }
            if(salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("O IR é de 22.5% e pode deduzir R$ 636,00");
            }
            if (salario >= 4664.01)
            {
                Console.WriteLine("Você tem que dar muito dinheiro para o governo! ");
            }
            if(salario <= 1899)
            {
                Console.WriteLine("Você não precisa declarar Imposto de Renda! ");

            }


        }


        Console.WriteLine("Tecle ENTER para fechar! ");
        Console.ReadLine();
    }
}


/*
 Exite uma forma de fazer varias condições IFs dentro do C# que é utilizando o comando SWITCH, segue exemplo abaixo:


using System;

class Programa
{
    static void Main(String[] args)
    {
        int mes = 13;

        switch (mes)
        {
            case 1:
                Console.WriteLine("O mês é Janeiro");
                break;
            case 2:
                Console.WriteLine("O mês é Fevereiro");
                break;
            case 3:
                Console.WriteLine("O mês é Março");
                break;
            case 4:
                Console.WriteLine("O mês é Abril");
                break;
            case 5:
                Console.WriteLine("O mês é Maio");
                break;
            case 6:
                Console.WriteLine("O mês é Junho");
                break;
            case 7:
                Console.WriteLine("O mês é Julho");
                break;
            case 8:
                Console.WriteLine("O mês é Agosto");
                break;
            case 9:
                Console.WriteLine("O mês é Setembro");
                break;
            case 10:
                Console.WriteLine("O mês é Outubro");
                break;
            case 11:
                Console.WriteLine("O mês é Novembro");
                break;
            case 12:
                Console.WriteLine("O mês é Dezembro");
                break;
            default:
                Console.WriteLine("Mês inválido");
                break;
        }
        Console.ReadLine();
    }
}
 
 */