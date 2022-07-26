using System;

namespace RevisaoFuncoesProcedures
{
    class Program
    {/*Faça um programa usando função, que mostre a 
       média dos valores de um vetor de 10 posições.*/
        //static double[] CalcularMedia(double[] valores) 
        //{
        //    double media = 0;
        //    double somatorio = 0;
        //    for (int i = 0; i < valores.Length; i++)
        //    {
        //        somatorio += valores[i];
        //    }
        //    media = somatorio / valores.Length;
        //    Console.WriteLine("A média é:"+media);
        //    return valores;
        //}
        //static double[] PreencherVetor(double[] valores)
        //{
        //    Random random = new Random();
        //    for (int i=0; i< valores.Length; i++) 
        //    {
        //        valores[i] = random.NextDouble()*10;
        //    }
        //    return valores;
        //}
        //static void Main(string[] args)
        //{
        //    double[] valores = new double[10];
        //    valores = PreencherVetor(valores);
        //    CalcularMedia(valores);
        //}
      
        static void Main(string[] args) 
        {
            int tamanho = 10;
            double[] v1 = new double[tamanho];
            double[] v2 = new double[tamanho];
            double[] resposta;
            v1 = PreencherVetor(v1);
            v2 = PreencherVetor(v2);
            resposta = MultiplicarVetores(v1, v2);
            MostrarValoresVetor(resposta);
        }
        static void MostrarValoresVetor(double[] v1) 
        {
            for (int i = 0; i < v1.Length; i++)
            {
                Console.WriteLine($"Resultado:{i} = {v1[i]}");
            }
        }
        static double[] MultiplicarVetores(double[] v1, double[] v2) 
        {
            double[] resposta = new double[v1.Length];
            for (int i=0; i < v1.Length; i++) 
            {
                resposta[i] = v1[i] * v2[i];
            }
            return resposta;
        }
        static double[] PreencherVetor(double[] valores)
        {
            Random random = new Random();
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = random.NextDouble() * 10;
            }
            return valores;
        }
    }
}
