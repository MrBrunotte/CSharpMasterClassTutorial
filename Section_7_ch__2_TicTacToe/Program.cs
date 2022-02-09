using System;

namespace Section_7_ch__2_TicTacToe
{
    class Program
    {
        // the playfield type char is the most resource efficient
        static char[,] matrix =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;

            SetField();

            // Run code as long as the program runs
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                SetField();

                #region
                // Check winning condition
                #endregion
                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((matrix[0,0] == playerChar) && (matrix[0,1] == playerChar) && (matrix[0,2] == playerChar))
                        || ((matrix[1, 0] == playerChar) && (matrix[1, 1] == playerChar) && (matrix[1, 2] == playerChar))
                        || ((matrix[2, 0] == playerChar) && (matrix[2, 1] == playerChar) && (matrix[2, 2] == playerChar))
                        || ((matrix[0, 0] == playerChar) && (matrix[1, 0] == playerChar) && (matrix[2, 0] == playerChar))
                        || ((matrix[0, 1] == playerChar) && (matrix[1, 1] == playerChar) && (matrix[2, 1] == playerChar))
                        || ((matrix[0, 2] == playerChar) && (matrix[2, 1] == playerChar) && (matrix[2, 2] == playerChar))
                        || ((matrix[0, 0] == playerChar) && (matrix[1, 1] == playerChar) && (matrix[2, 2] == playerChar))
                        || ((matrix[0, 2] == playerChar) && (matrix[1, 1] == playerChar) && (matrix[2, 0] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                            Console.WriteLine("\nPlayer 2 has won!");
                        else
                            Console.WriteLine("\nPlayer 1 has won!");

                        Console.WriteLine("Please any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nIt's a draw...Play again?");
                        Console.WriteLine("Please any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }
                #region
                // test if field is already taken
                do
                {
                    Console.Write($"\nPlayer {player}: Choose your field! ");
                    try
                    {
                    input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (matrix[0,0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (matrix[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (matrix[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (matrix[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (matrix[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (matrix[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (matrix[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (matrix[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (matrix[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nIncorrect input, please use another field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
                #endregion



            } while (true);
        }

        public static void ResetField()
        {

            char[,] matrixInitial =
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
            };

            matrix = matrixInitial;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |");
            // TODO replace numbers with variables
            Console.WriteLine($"  {matrix[0,0]}  |  {matrix[0, 1]}  |  {matrix[0, 2]} ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            // TODO replace numbers with variables
            Console.WriteLine($"  {matrix[1,0]}  |  {matrix[1,1]}  |  {matrix[1,2]} ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            // TODO replace numbers with variables
            Console.WriteLine($"  {matrix[2,0]}  |  {matrix[2, 1]}  |  {matrix[2, 2]} ");
            Console.WriteLine("     |     |");
            turns++;
        }
        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1: matrix[0, 0] = playerSign; break;
                case 2: matrix[0, 1] = playerSign; break;
                case 3: matrix[0, 2] = playerSign; break;
                case 4: matrix[1, 0] = playerSign; break;
                case 5: matrix[1, 1] = playerSign; break;
                case 6: matrix[1, 2] = playerSign; break;
                case 7: matrix[2, 0] = playerSign; break;
                case 8: matrix[2, 1] = playerSign; break;
                case 9: matrix[2, 2] = playerSign; break;
            }
        }
    }
}
