using System;

namespace Revisao
{
    class Program
    {
        /*Faça um programa que receba um número indefinido de 
        valores e ao fim da execução, mostre a média de todas 
        as entradas;*/

        //Ex 1 static void Main(string[] args)
        //{
        //    double media = 0;
        //    double totalEntradas = 0;
        //    double somatorio = 0;
        //    double entrada = 0;

        //    Console.WriteLine("Insira um valor: (0 para sair)");
        //    entrada = Convert.ToDouble(Console.ReadLine());

        //    while (entrada > 0) 
        //    {
        //        totalEntradas++;
        //        somatorio += entrada;
        //        Console.WriteLine("Insira um valor: (0 para sair)");
        //        entrada = Convert.ToDouble(Console.ReadLine());
        //    }

        //    //para não cair em uma indeterminação matemática (divisão por zero)
        //    if(totalEntradas > 0) 
        //    {
        //        media = somatorio / totalEntradas;
        //        Console.WriteLine("A média é:"+media);
        //    }



        //}

        //Ex 2 static void Main(string[] args) 
        //{            
        //    string[] nomes = new string[5];

        //    for(int i = 0; i <nomes.Length; i++) 
        //    {
        //        nomes[i] = Console.ReadLine();
        //    }

        //    foreach (string nome in nomes) 
        //    {
        //        bool mostrarPalavra = false;
        //        foreach(char letra in nome) 
        //        {
        //            if(letra == 'c') 
        //            {
        //                mostrarPalavra = true;
        //            }
        //        }
        //        if (mostrarPalavra) 
        //        {
        //            Console.WriteLine(nome);
        //        }
        //    }
        //}
        
        static void Main(string[] args) 
        {
            string texto = string.Empty;
            string letrasA = string.Empty;
            string entrada = Console.ReadLine();
            int contadorDeA = 0;

            //acumular os textos
            while (entrada != string.Empty) 
            {
                texto += entrada;
                foreach (char letra in entrada) 
                {
                    if (letra == 'a')
                    {
                        letrasA += letra.ToString();
                        contadorDeA++;
                    }
                }
                entrada = Console.ReadLine();
            }
            Console.WriteLine("Todas as letras a's: " + letrasA);
            Console.WriteLine("Total de letras a:" + contadorDeA);
        }
    }
}
