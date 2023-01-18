//obs: nesse projeto foi adicionado uma letra na frente do 10 pois se não o C# Adicionaria nosso projeto logo após o 1
using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Executando o PROJETO 13 - Utilizando Break");

        //*
        //**
        //***
        //****
        //*****

        for(int contadorDeLinhas = 0; contadorDeLinhas < 10; contadorDeLinhas++)
        {
            for (int contadorDeColunas = 0; contadorDeColunas < 10; contadorDeColunas++)
            {
                Console.Write("*");
                if (contadorDeColunas >= contadorDeLinhas)
                {
                    break;
                }
            }

        }


        Console.WriteLine(@"
Tecle ENTER para fechar! ");
        Console.ReadLine();
    }
}
