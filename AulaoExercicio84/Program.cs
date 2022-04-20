using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaoExercicio84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me diz o tamanho do Vetor, meu filho");
            int tamanhoVetor = int.Parse(Console.ReadLine());

            int[] vetorA = new int[tamanhoVetor];
            int[] vetorB = new int[tamanhoVetor];
            int[] vetorC = new int[tamanhoVetor];


            //adicionando valores nos Vetores A e B
            Console.WriteLine("Pois Bem meu filho(a), vamos adicionar valores nos vetores!!!");
            Console.WriteLine("(Para Agilizar vou adicionar o dobro do valor do VetorA no VetorB!!!)");
            for(int i = 0; i < tamanhoVetor; i++)
            {
                vetorA[i] = int.Parse(Console.ReadLine());
                vetorB[i] = vetorA[i] * 2;
            }

            foreach(int i in vetorA)
            {
                Console.Write("VetorA = ["+ i+ "]" + " ");
            }
            Console.WriteLine();
            foreach (int i in vetorB)
            {
                Console.Write("VetorB = [" + i + "]" + " ");
            }

           for(int i = 0; i < tamanhoVetor; i++)
            {
                vetorC[i] += (vetorA[i] + vetorB[i]);
            }
            Console.WriteLine();
            foreach (int i in vetorC)
            {
                Console.Write("VetorC = [" + i + "]" + " ");
                
            }
            Console.WriteLine();
        }
    }
}
