## --- TicTacToe Challenge ---

##### 1. create method that sets playing field --> SetField()
    
        static void Main(string[] args)
                {
                    SetField();
                    Console.Read();
                }

            private static void SetField()
            {
                Console.WriteLine("     |     |");
                // TODO replace numbers with variables
                Console.WriteLine($"  {1}  |  {3}  |  {2} ");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |");
                // TODO replace numbers with variables
                Console.WriteLine($"  {3}  |  {4}  |  {5} ");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |");
                // TODO replace numbers with variables
                Console.WriteLine($"  {7}  |  {8}  |  {9} ");
                Console.WriteLine("     |     |");
            }

##### 2. Create the playfield

    // the playfield type char is the most resource efficient
        static char[,] matrix = new char[3, 3]
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

##### 3. Replace the variables for the matrix indexes from SetField()

    private static void SetField()
        {
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
        }

#### 4. User input
We create the variables (int the Main()) for the players and a bool to check if the input is correct.

    int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;

##### 5. Create the do-while loop 
Set it to true since we want the code to run as long as the program runs.

##### 6. Set the player to 1 or 2 with if statement

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

##### EnterXorO()
This method sets the character X or O to each player. 
1. Create a char variable playerSign with an empty char ' '
2. Set X and O to the players
3. Switch statement that sets the correct playerSign in the matrix

    public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (playerSign == 2)
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
