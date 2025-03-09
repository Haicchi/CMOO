using System.Diagnostics.CodeAnalysis;

namespace Lab2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int povtor = 0;
            do
            {
                int ostatok = 0;
                int ostatok2 = 0;
                int ochkiplayer = 0;
                int ochkiplayer2 = 0;
                int ochkiRobot = 0;
                int ochkiRobot2 = 0;
                int pochatkovi1 = 5;
                int pochatkovi2 = 23;
                Random radomize = new Random();
                int hint = 0;
                int lvl1 = 0;
                int guess = 0;
                int win1 = 0;
                int roundcount = 1;
                int lvl2 = radomize.Next(11, 101);
                int liveround1 = 5;
                int liveround2 = 23;
                while (roundcount <= 3)
                {
                    lvl1 = radomize.Next(1, 11);
                    liveround1 = 5;
                   
                    do
                    {
                        
                        Console.WriteLine($"Round number {roundcount}");
                        Console.WriteLine($"Number of your lives = {liveround1}");
                        Console.WriteLine("Your task is to guess number from 1 to 10.Each wrong guess will take one of your lives.Each round refreshs number of your lives");
                        Console.WriteLine("////////////////////////////////////");
                        Console.WriteLine("Put in your guess");
                        Console.WriteLine(lvl1);
                        guess = Convert.ToInt32(Console.ReadLine());
                        if (guess == lvl1)
                        {
                            if (roundcount == 3)
                                Console.WriteLine("You guessed the number");
                            Console.WriteLine("////////////////////////////////////");
                            Console.WriteLine("You won this round");
                            Console.WriteLine("////////////////////////////////////");
                           ostatok = 5*liveround1;
                            ochkiplayer += ostatok;
                            liveround1 = 5;

                            win1++;
                            Console.WriteLine($"Очки гравця = {ochkiplayer} Очки комп'ютера = {ochkiRobot}");
                            break;
                           
                        }
                        else
                        {
                            Console.WriteLine("You didn't guess the number");
                            liveround1--;
                            Console.WriteLine("Do you want to get a hint,you can check is your number greater or smaller than guessed.But it will cost you 1 live(1-yes,anyother number-no)");
                            Console.WriteLine("////////////////////////////////////");
                            hint = Convert.ToInt32(Console.ReadLine());
                            if (liveround1 > 1)
                            {
                                if (hint == 1)
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
                                    liveround1--;
                                }
                            }
                            Console.WriteLine($"You have {liveround1} lives left");
                            Console.WriteLine("////////////////////////////////////");
                            if (liveround1 == 0)
                            {
                                int suma = 5 * pochatkovi1;
                                ochkiRobot += suma;
                                Console.WriteLine($"Очки гравця = {ochkiplayer} Очки комп'ютера = {ochkiRobot}");
                            }
                        }
                       
                    } while (liveround1 > 0 || guess == lvl1);
                    roundcount++;
                    Console.WriteLine("END");
                }
                
                Console.WriteLine($"Очки гравця = {ochkiplayer} Очки комп'ютера = {ochkiRobot}");
                if (win1 == 3)
                {
                    Console.WriteLine("You won the game");
                    Console.WriteLine("Do you want to start lvl 2?(1-yes,2-restart lvl 1,any other number stop");
                    int izmen = 0;
                    izmen = Convert.ToInt32(Console.ReadLine());
                    if (izmen == 1)
                    {
                        roundcount = 1;
                        while (roundcount <= 2)
                        {
                            lvl2 = radomize.Next(11, 101);
                            liveround2 = 23;
                            do
                            {

                                Console.WriteLine($"Round number {roundcount}");
                                Console.WriteLine($"Number of your lives = {liveround2}");
                                Console.WriteLine("Your task is to guess number from 10 to 100.Each wrong guess will take one of your lives.Each round refreshs number of your lives");
                                Console.WriteLine("////////////////////////////////////");
                                Console.WriteLine("Put in your guess");
                                Console.WriteLine(lvl2);
                                guess = Convert.ToInt32(Console.ReadLine());
                                if (guess == lvl2)
                                {
                                    if (roundcount == 2)
                                        Console.WriteLine("You guessed the number");
                                    Console.WriteLine("////////////////////////////////////");
                                    Console.WriteLine("You won this round");
                                    Console.WriteLine("////////////////////////////////////");
                                    ostatok2 = 10*liveround2;
                                    ochkiplayer2 += ostatok2;
                                   
                                    liveround2 = 23;

                                    
                                    Console.WriteLine($"Очки гравця = {ochkiplayer} Очки комп'ютера = {ochkiRobot}");
                                    break;

                                }
                                else
                                {
                                    Console.WriteLine("You didn't guess the number");
                                    liveround2--;
                                    Console.WriteLine("Do you want to get a hint,you can check is your number greater or smaller than guessed.But it will cost you 1 live(1-yes,anyother number-no)");
                                    Console.WriteLine("////////////////////////////////////");
                                    hint = Convert.ToInt32(Console.ReadLine());
                                    if (liveround2 > 1)
                                    {
                                        if (hint == 1)
                                        {
                                            if (guess > lvl2)
                                            {
                                                Console.WriteLine("////////////////////////////////////");
                                                Console.WriteLine("Your number is greater than guessed");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Your number is less than guessed");
                                            }
                                            liveround2--;
                                        }
                                    }
                                    if (liveround2 == 0)
                                    {
                                        int suma2 = 10 * pochatkovi2;
                                        ochkiRobot2 += suma2;
                                        Console.WriteLine($"Очки гравця = {ochkiplayer} Очки комп'ютера = {ochkiRobot}");
                                    }

                                    Console.WriteLine($"You have {liveround2} lives left");
                                    Console.WriteLine("////////////////////////////////////");
                                }

                            } while (liveround2 > 0 || guess == lvl2);
                            roundcount++;
                            
                        }
                       
                        Console.WriteLine("END");
                        Console.WriteLine($"Очки гравця = {ochkiplayer+ochkiplayer2},Очки комп'ютера = {ochkiRobot+ochkiRobot2}");
                        Console.WriteLine("If you want to play again type 1 if no type anything");
                        

                    }
                    else if (izmen == 2)
                    {
                        povtor = 1;
                    }
                    else
                    {
                        break;
                    }
                    povtor = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You lost the game");
                    Console.WriteLine("Do you want to restart (1-yes any other number - no)");
                    povtor = Convert.ToInt32(Console.ReadLine());
                    
                }
            } while (povtor==1);
            
        }
    }
}
