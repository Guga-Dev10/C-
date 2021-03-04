using System;

namespace _11._Matrizes {
    class Program {
        static void Main(string[] args) {

            double[,] Mat = new double[2, 3];

            Console.WriteLine(Mat.Length); // Tamanho da Matriz

            Console.WriteLine(Mat.Rank); // Quantidade de linhas da matriz

            Console.WriteLine(Mat.GetLength(0)); // Mostra o valor da primeira dimensão da matriz (linhas)

            Console.WriteLine(Mat.GetLength(1)); // Mostra o valor da segunda dimensão da matriz (colunas)


            Console.WriteLine();
            Console.WriteLine("Entre com os valores da Linha e Coluna da Matriz: ");
            int L = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            double[,] Matriz = new double[L, C];

            Console.WriteLine();
            Console.WriteLine("Registre os valores da Matriz = ");

            for (int i = 0; i < L; i++) {
                for (int j = 0; j < C; j++) {
                    Matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Dados da matriz");

            for (int i = 0; i < L; i++) {
                for (int j = 0; j < C; j++) {
                    Console.Write(Matriz[i, j]);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Digite um número: ");
            double N = double.Parse(Console.ReadLine());

            for (int i = 0; i < L; i++) {
                for (int j = 0; j < C; j++) {
                    if (Matriz[i,j] == N) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + Matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + Matriz[i - 1, j]);
                        }
                        if (j < L - 1) {
                            Console.WriteLine("Right: " + Matriz[i, j + 1]);
                        }
                        if (i < C - 1) {
                            Console.WriteLine("Down: " + Matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
