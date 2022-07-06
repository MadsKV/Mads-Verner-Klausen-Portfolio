class Program
{
    static void Main()
    {
        for (int j = 1; j <= 100; j++)
        {
            if (j % 3 == 0 && j%5==0)
            { Console.WriteLine("fizzbuzz"); }
            else if (j % 3 == 0)
            { Console.WriteLine("fizz"); }
            else if (j % 5 == 0)
            { Console.WriteLine("Buzz"); }
            else { Console.WriteLine(j); }
        }
        Console.ReadLine();
    }
}