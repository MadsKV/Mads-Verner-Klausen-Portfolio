using System;
using System.Timers;

namespace GuessANumber
{
    class Program
    {
        //Creates a random color picker.
        private static Random _random = new Random();

        public static Timer aTimer { get; private set; }
        static void Main(string[] args)
        {

            while (true) // Continue the game untill the user does want to anymore...
            {
                Console.Clear();
                //Calls the random color picker.
                ColorPicker.RandomColor();
                Random random = new Random();
                int guess = 0;
                string welcome = "Guess a number between 1 and 100";
                string border = ("---------------------------------------------------------");
                GetTimer.SetTimer();
                DateTime startTid = DateTime.Now;
                Console.WriteLine(border);
                Console.WriteLine("HURRY! Game Started at {0:HH:mm:ss.fff}", "[" + startTid + "]");
                int num = random.Next(1, 100);
                Console.WriteLine(welcome);
                Console.WriteLine(border);
                int i = 0;

                while (guess != num)
                {
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess > num)
                        {
                            Console.WriteLine("Too High, Number is lower then " + guess);
                        }
                        else
                        {
                            Console.WriteLine("Too Low, Number is higher then " + guess);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Guess must be a number");
                        i--;
                    }
                    i++;
                }
                Console.Clear();
                Console.WriteLine(border);
                Console.WriteLine("Congrats, it took you " + i + " tries");
                DateTime slutTid = DateTime.Now;
                Console.WriteLine("Fast Enough? Game Started at {0:HH:mm:ss.fff}", "["+ startTid +"]");
                TimeSpan duration = slutTid - startTid;
                Console.WriteLine("Woah your fast! Time from start to end " + "["+ duration.ToString(@"mm\:ss") + "]");
                Console.WriteLine(border);

                while (true) // Continue asking until a correct answer is given.
                {
                    Console.Write("\n\nDo you want to play again [Y/N] or [YES/NO]?");
                    string answer = Console.ReadLine();
                    if (answer == "Y" || answer== "YES" || answer == "yes" || answer == "Yes")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N" || answer == "NO" || answer == "no" || answer == "No")
                        return; // Exit the Main-method.
                }
            }
        }
    }
}
