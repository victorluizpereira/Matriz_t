using System;

namespace matriztrasposta
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declarando as variáveis e matrizes.
            int Al=0, Ac=1;
            int[,] A, At;

            Console.WriteLine("\t\t\t=============== Matriz trasposta ================");
            
            /*  Enquanto a matriz não for quadrática (i e j iguais ex. [4x4]) repita */
            while (Al != Ac)
            {
                Console.Write("\n\nDigite o valor da linha da matriz A[x,] >> ");
                Al = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nDigite o valor da coluna da matriz A[,x] >> ");
                Ac = Convert.ToInt32(Console.ReadLine());

                if(Al != Ac){
                    Console.WriteLine("\nValor inválido a matriz deve ser quadrática" +
                                      " para efetuar a trasposição !!\n");
                }
            }

            A = new int[Al, Ac];        // Iniciando as matrizes
            At = new int[Al, Ac];

            for (int i = 0; i < Al; ++i)
            {
                for (int j = 0; j < Ac; ++j)        // Atribuindo os valores para a matriz A[,]
                {
                    Console.Write("\nDigite o valor da matriz A[{0},{1}] >> ", i + 1, j + 1);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\nO valor da matriz A = \n");

            for (int i = 0; i < Al; ++i)
            {
                Console.Write("|");
                for (int j = 0; j < Ac; ++j)                // Imprimindo a matriz A[,] via console
                {
                    Console.Write("\t" + A[i, j]+"\t|");
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i < Al; ++i)
            {
                for (int j = 0; j < Ac; ++j)                    // Passando os valores da matriz A[,] para a matriz At[,]
                {                                               // de forma transposta, no qual os valores diagonais
                    if (i != Al + 1 - 1 && j != Ac + 1 - 1)     // se invertem.
                    {
                        At[j, i] = A[i, j];
                    }else{
                        At[i, j] = A[i, j]; 
                    }
                }
            }

            Console.WriteLine("\nA matriz trasposta de A é ..");
            Console.WriteLine("At = \n");   

            for (int i = 0; i < Al; ++i)
            {
                Console.Write("|");
                for (int j = 0; j < Ac; ++j)                    // Imprimindo a matriz transposta At[,]
                {
                    Console.Write("\t" + At[i, j]+"\t|");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();


        }
    }
}
