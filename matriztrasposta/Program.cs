using System;

namespace matriztrasposta
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Al=0, Ac=1;
            int[,] A, At;

            Console.WriteLine("\t\t\t=============== Matriz trasposta ================");

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

            A = new int[Al, Ac];
            At = new int[Al, Ac];

            for (int i = 0; i < Al; ++i)
            {
                for (int j = 0; j < Ac; ++j)
                {
                    Console.Write("\nDigite o valor da matriz A[{0},{1}] >> ", i + 1, j + 1);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\nO valor da matriz A = \n");

            for (int i = 0; i < Al; ++i)
            {
                Console.Write("|");
                for (int j = 0; j < Ac; ++j)
                {
                    Console.Write("\t" + A[i, j]+"\t|");
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i < Al; ++i)
            {
                for (int j = 0; j < Ac; ++j)
                {
                    if (i != Al + 1 - 1 && j != Ac + 1 - 1)
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
                for (int j = 0; j < Ac; ++j)
                {
                    Console.Write("\t" + At[i, j]+"\t|");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();


        }
    }
}