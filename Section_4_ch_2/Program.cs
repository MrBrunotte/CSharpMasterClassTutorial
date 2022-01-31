using System;

namespace Section_4_ch_2
{
    /*  Create an application with a score, highscore and a highscorePlayer.
     *  
     *  Create a method which has two parameters, one for the score and one for the playerName.
     *  When ever that method is called, it should be checked if the score of the player is 
     *  higher than the highscore, if so, "New highscore is + " score" and in another line 
     *  "New highscore holder is " + playerName - should be written onto the console, if not 
     *  "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
     *  
     *  Consider which variables are required globally and which ones locally.
     */

    class Program
    {
        // global variables
        static int highScore = 55;
        static string highScoreplayer = "Viggo";

        static void Main(string[] args)
        {
            ScoreCheck(1, "");
            Console.Read();
        }
        
        public static void ScoreCheck(int score, string playerName)
        {
            Console.Write("Enter your name: ");
            playerName = Console.ReadLine();
            Console.Write("Enter you new score: ");
            score = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nCurrent highscore: {highScore} held by: {highScoreplayer}");

            if (score > highScore)
            {
                // update the new highscore and who holds it.
                highScore = score;
                highScoreplayer = playerName;

                Console.WriteLine($"New highscore is {score}!!!!");
                Console.WriteLine($"New highscore holder is {playerName}, CONGRATULATIONS!!!!");
            }
            else if (score == highScore)
            {
                Console.WriteLine($"Your score was: {score}");
                Console.WriteLine($"The current highscore is {highScore}, this is a tie!! ");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highScore} could not be broken");
            }
            Console.WriteLine($"\nNew highscore: {highScore} held by: {highScoreplayer}");
        }
    }
}
