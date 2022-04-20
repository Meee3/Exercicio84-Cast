using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaoExercicio91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algortimo para ler 50 números e armazenar em um vetor VET,
            //verificar e escrever se existem números repetidos no VET e em que posições se encontram

            #region Versão Simplificada
            //const int tamanhoVetorFixo = 5;
            ////int[] VET = new int[tamanhoVetorFixo];
            //int[] VET = { 1, 2, 3, 3, 5, 5 };
            //Random random = new Random();
            //int[] numerosRepetidos = new int[tamanhoVetorFixo];
            //int[] numerosPosicoes = new int[tamanhoVetorFixo];

            //Console.WriteLine(VET.Length);
            //for (int i = 0; i < VET.Length; i++)
            //{
            //    //VET[i] = random.Next(11);

            //}

            //for (int i = 0; i < tamanhoVetorFixo; i++)
            //{
            //    if (VET[i + 1] >= tamanhoVetorFixo)
            //    {

            //    }
            //    if (VET[i] == VET[i + 1])
            //    {
            //        numerosRepetidos[i] = VET[i];
            //        numerosPosicoes[i] = i;
            //    }
            //}



            ////Exibe
            //Console.WriteLine("tcharamm");

            //foreach (int item in numerosRepetidos)
            //{
            //    if (item > 0)
            //    {
            //        Console.WriteLine("Numeros Repetidos " + item);

            //    }
            //}

            //foreach (int item in numerosPosicoes)
            //{
            //    if (item > 0)
            //    {
            //        Console.WriteLine("Numeros Posição " + item);

            //    }
            //}

            #endregion

            #region Versão com 50 números

            const int tamanhoVetorFixo = 50;
            int[] VET = new int[tamanhoVetorFixo];
            Random random = new Random();
            int[] numerosRepetidos = new int[tamanhoVetorFixo];
            int[] numerosPosicoes = new int[tamanhoVetorFixo];

            Console.WriteLine(VET.Length);

            for (int i = 0; i < VET.Length; i++)
            {
                VET[i] = random.Next(11);

            }

            for (int i = 0; i < VET.Length; i++)
            {
                Console.WriteLine(i);

                if (VET[i] == VET[i + 1])
                {
                    numerosRepetidos[i] = VET[i];
                    numerosPosicoes[i] = i;
                }
                if ((i + i) >= VET.Length)
                {
                    break;
                }
            }


       


            //Exibe
            Console.WriteLine("tcharamm");

            Console.WriteLine(  "Número(s) Repetidos: ");

            for (int i = 0; i < numerosRepetidos.Length; i++)
            {
                if(numerosRepetidos[i] > 0)
                {
                    Console.Write("[" + numerosRepetidos[i]+"] ");

                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Número Posições");


            for (int i = 0; i < numerosPosicoes.Length; i++)
            {
                if (numerosPosicoes[i] > 0)
                {
                    Console.Write("[" + numerosPosicoes[i] + "] ");

                }
            }

            #endregion

        }
    }
}
