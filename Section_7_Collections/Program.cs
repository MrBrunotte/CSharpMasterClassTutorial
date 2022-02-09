using System;

namespace Section_7_Collections
{
    class Program
    {
        /* ------ TicTacToe Challenge ------
         * What do I need?
         *  Playing field - Matrix
         *  
         * 
         */
        // create the matrix
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        static void Main(string[] args)
        {
            PrintMatrix();
            

            Console.Read();
        }

        private static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} | ");
                }
                Console.WriteLine();
            }
        }
    }
}
