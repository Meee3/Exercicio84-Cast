using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaoExercicio90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algortimo para ler um vetor de 30 números. Após isto,
            //ler mais um número qualquer, calcular e escrever quantas vezes esse número aparece no vetor

            const int tamanhoVetorFixo = 30;
            int[] vetor = new int[tamanhoVetorFixo];
            Random random = new Random();
            int resultado = 0;
            Console.WriteLine("Bora, Digite o seu número da sorte!");
            int numeroDaSorte = int.Parse(Console.ReadLine());
            Console.WriteLine("(Dica você vai acertar mais se for de 0 a 10)");
            

            for(int i = 0; i < tamanhoVetorFixo; i++)
            {
                vetor[i] = random.Next(11); 
            }

            for(int i = 0; i < tamanhoVetorFixo; i++)
            {
                if (numeroDaSorte == vetor[i])
                {
                    resultado++;
                }
            }

            Console.WriteLine("Maravilha, Sabe quanto você acertou?");
            Console.WriteLine("Tudo isto: " + resultado);
        }
    }
}
