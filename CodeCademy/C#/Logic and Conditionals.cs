Boolean Data Types
In C#, we can represent Boolean values using the bool data type. Booleans, unlike numbers or strings, only have two values: true and false.

using System;

namespace BooleanDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
          bool answerOne = true;
          bool answerTwo = false;
        }
    }
}


Comparison Operators
When writing a program, we often need to check if a value is correct or compare two values. Comparison operators allow us to compare values and evaluate their relationship. Rather than evaluating to an integer, they evaluate to boolean values. Expressions that evaluate to boolean values are known as boolean expressions.

using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
        double timeToDinner = 4;
        double distance = 95;
        double rate = 30;


        double tripDuration = distance / rate;

        bool answer = (tripDuration <= timeToDinner);


        Console.WriteLine(answer);
    }
  }
}


Logical Operators
As we saw in the truth table, a Boolean expression that uses logical operators can be as simple as evaluating two boolean values:

using System;

namespace LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;

      bool yourNeeds = (beach && city);
      bool friendNeeds = (beach && hiking);

      bool tripDecision = (yourNeeds && friendNeeds);

      Console.WriteLine(tripDecision);
    }
  }
}



Review
Great job! You just learned about logic and boolean values, including:

How to define variables with a bool data type
How to use comparison operators with different data types to return boolean values
What a truth table is and how to read one
How to use logical operators to compare boolean values and expressions

using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      BOOL TYPE: bool variableName
      COMPARISON OPERATORS: ==, <, >, <=, >=
      LOGICAL OPERATORS: &&, ||, !

      Good luck! */


    }
  }
}



If Statements
Conditional statements are the most commonly used control structures in programming. They rely on the computer being able to reason whether conditions are true or false.

The most basic conditional statement is an if statement. An if statement executes a block of code if specified condition is true.

using System;

namespace IfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int socks = 6;
      if (socks <= 3)
      {
        Console.WriteLine("Time to do laundry!");
      }

    }
  }
}


If...Else... Statements
What if we want another set of instructions to execute if the condition is false? An else clause can be added to an if statement to provide code that will only be executed if the if condition is false.

using System;

namespace IfElseStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int people = 12;
      string weather = "bad";
      if (people <= 10 && weather == "nice")
      {
        Console.WriteLine("SaladMart");
      }
      else
      {
        Console.WriteLine("Soup N Sandwich");
      }

    }
  }
}


Else If Statements
What if we want to handle multiple conditions and have a different thing happen each time? Conditional statements can be chained by combining if and else statements into else if. After an initial if statement, one or more else if blocks can check additional conditions. An optional else block can be added at the end to catch cases that do not match any of the conditions.

using System;

namespace ElseIfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int guests = 4;
      if (guests >= 4)
      {
        Console.WriteLine("Catan");
      }
      else if (guests >= 1)
      {
        Console.WriteLine("Innovation");
      }
      else
      {
        Console.WriteLine("Solitaire");
      }
    }
  }
}


Switch Statements
Using multiple else if statements can get unwieldy pretty quickly. Imagine writing an else if statement for every possible number of guests. And you invited 20 people. You have to write a lot of repetitive code, which is hard to read and prone to errors.

If it’s necessary to evaluate several conditions with their own unique output, a switch statement is the way to go. Switch statements allow for compact control flow structures by evaluating a single expression and executing code blocks based on a matched case.


using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Pick a movie genre?");
      string genre = Console.ReadLine();


      switch(genre)
      {
        case "Drama":
          Console.WriteLine("Citizen Kane");
          break;
        case "Comedy":
          Console.WriteLine("Duck Soup");
          break;
        case "Adventure":
          Console.WriteLine("King Kong");
          break;
        case "Horror":
          Console.WriteLine("	Psycho");
          break;
        case "Science Fiction":
          Console.WriteLine("2001: A Space Odyssey");
          break;
        default:
          Console.WriteLine("No movie found");
          break;
      }
    }
  }
}


Ternary Operators
The ternary operator allows for a compact syntax in the case of binary decisions. Like an if...else statement, it evaluates a single condition and executes one expression if the condition is true and the second expression otherwise.

using System;

namespace TernaryOperator
{
  class Program
  {
    static void Main(string[] args)
    {
      int pepperLength = 2;
      string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";


      Console.WriteLine(message);
    }
  }
}
