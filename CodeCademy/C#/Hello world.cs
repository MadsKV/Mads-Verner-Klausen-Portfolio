Run Some C#
Time to run some C# yourself! 

There are two panels here: a text editor containing some C# code and a console, or terminal, that shows output. When you run the code, you’ll see some text printed to the console. 

using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Mads Verner Klausen");    
     }
  }
}
 

Getting Input
We can also read input from a user. The command Console.ReadLine() captures text that a user types into the console. 

using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}


Comments
Ironically, an essential tool in programming is the ability to tell a computer to ignore a part of a program. Text written in a program but not run by the computer is called a comment. In C#, anything after a // or between /* and */ is a comment. In spoken word we call these symbols “forward slashes” and “asterisks”.

using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      //Ask's for age?
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      //Tells you your age after input
      Console.WriteLine($"You are {input} years old!");
    }
  }
}


