using System.Diagnostics.CodeAnalysis;

namespace Lab2_3
{
    internal class Program
    {
        static Random radomize = new Random();


        static void Start()
        {
            int OchkiPlayer = 0;
            int OchkiRobot = 0;
            int win = 0;
            int livemax = 5;
            for (int round = 1; round <= 3; round++)
            {
                if (Round(round, 1, 11, 5, ref OchkiPlayer, ref OchkiRobot, livemax, 5))
                {
                    win++;
                }
            }
            livemax = 23;
            if (win == 3 && Continue())
            {
                win = 0;
                for (int round = 1; round <= 2; round++)
                {
                    if (Round(round, 11, 101, 23, ref OchkiPlayer, ref OchkiRobot, livemax, 10))
                    {
                        win++;
                    }
                }
            }
        }
        static bool Round(int roundcount, int min, int max, int lives, ref int OchkiPlayer, ref int OchkiRobot, int livemax, int scoreperlife)
        {

            int lvl1 = radomize.Next(min, max);
            int ostatok = 0;
            Console.WriteLine($"Round number {roundcount}");
            Console.WriteLine($"Number of your lives = {lives}");
            Console.WriteLine("Your task is to guess number from 1 to 10.Each wrong guess will take one of your lives.Each round refreshs number of your lives");
            Console.WriteLine("////////////////////////////////////");
            while (lives > 0)
            {
                Console.WriteLine("////////////////////////////////////");
                Console.WriteLine(lvl1);
                Console.WriteLine("Put in your guess");

                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == lvl1)
                {
                    if (roundcount == 3)
                        Console.WriteLine("You guessed the number");
                    Console.WriteLine("////////////////////////////////////");
                    Console.WriteLine("You won this round");
                    Console.WriteLine("////////////////////////////////////");
                    ostatok = 5 * lives;
                    OchkiPlayer += ostatok;
                    lives = 5;


                    Console.WriteLine($"Очки гравця = {OchkiPlayer} Очки комп'ютера = {OchkiRobot}");

                    return true;

                }
                else
                {
                    Console.WriteLine("You didn't guess the number");
                    lives--;
                    Console.WriteLine("Do you want to get a hint,you can check is your number greater or smaller than guessed.But it will cost you 1 live(1-yes,anyother number-no)");
                    Console.WriteLine("////////////////////////////////////");

                    if (lives > 1 && Hint())
                    {

                        if (guess > lvl1)
                        {
                            Console.WriteLine("////////////////////////////////////");
                            Console.WriteLine("Your number is greater than guessed");
                        }
                        else
                        {
                            Console.WriteLine("Your number is less than guessed");
                        }
                        lives--;


                    }
                    Console.WriteLine($"You have {lives} lives left");
                    Console.WriteLine("////////////////////////////////////");

                }


            }
            OchkiRobot += scoreperlife * livemax;
            Console.WriteLine($"Очки гравця = {OchkiPlayer} Очки комп'ютера = {OchkiRobot}");
            return false;
        }
        static bool Hint()
        {
            Console.WriteLine("Do you want to get a hint?It will cost you 1 live(1-yes.anyother - no)");
            return Convert.ToInt32(Console.ReadLine()) == 1;
        }
        static bool Restart()
        {
            Console.WriteLine("Do you want to play again?(1-yes,any other number-no)");
            return Convert.ToInt32(Console.ReadLine()) == 1;
        }
        static bool Continue()
        {
            Console.WriteLine("Do you want to continue to the next level?(1-yes,any other number-no)");
            return Convert.ToInt32(Console.ReadLine()) == 1;
        }
        static void Main(string[] args)
        {
            do
            {
                Start();
            } while (Restart());


        }
    }
}

