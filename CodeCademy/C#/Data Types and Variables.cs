Creating Variables with Types
When we use data in our programs, it’s good practice to save them in a variable. A variable is basically like a box in our computer memory where we can store values used in our code.

In C#, data types and variables are closely intertwined. Remember how C# is strongly-typed? Every time we declare a variable, we have to specify what kind of data type that variable is going to hold.

using System;

namespace Form
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Variables
      string name = "Shadow";
      string breed = "Golden Retriever";

      int age = 5;

      double weight = 65.22;

      bool spayed = true;
      // Print variables to the console
      Console.WriteLine(name);
      Console.WriteLine(breed);
      Console.WriteLine(age);
      Console.WriteLine(weight);
      Console.WriteLine(spayed);


    }
  }
}


Handling Errors
When you program, you’ll come across a lot of errors. And that’s ok! And when you’re first starting to learn a strongly-typed language, they can be pretty common.

using System;

namespace BugSquasher
{
  class Program
  {
    static void Main(string[] args)
    {
      double number = 38498.3222;

      string dinosaur = "Barney";

      double locks = 293.000;

      bool is_yes = true;

      string band = "The Low Anthem";

    }
  }
}


Converting Data Types
Because variables have to be strictly typed, there may be some circumstances where we want to change the type of data a variable is storing. This strategy is known as data type conversion.

using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int
      int faveNumber = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(faveNumber);

    }
  }
}


Numerical Data Types
In C#, there are several ways of representing numerical data. Your usage of each will depend on your application. When choosing a data type, think about the following questions:

Do I need a whole number or do I need something that will represent a fraction, or a decimal? If I want to use a decimal, how precise do I need to be? Depending on your application, whether it’s a hobby project or building a B2B financial services software, you’ll need a different data type. Is performance a factor? Most times, choosing a data type that takes up less memory will result in faster applications.

using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of pizza shops
      int pizzaShops = 4332;

      // Number of employees
      int totalEmployees = 86928;

      // Revenue
      double revenue = 390819.28;

      // Log the values to the console:
      Console.WriteLine(pizzaShops);
      Console.WriteLine(totalEmployees);
      Console.WriteLine(revenue);
   	}
  }
}


Arithmetic Operators
So what can we do with numerical data? A first step is to write expressions using arithmetic operators.

Arithmetic operators include:

addition +
subtraction -
multiplication *
division /

using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      // Your Age
      int userAge = 25;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge/jupiterYears; 

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge/jupiterYears;

      // Log calculations to console  
      Console.WriteLine(newJupiterAge);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(journeyToJupiter);
      Console.WriteLine(jupiterAge);
      Console.WriteLine(jupiterYears);
      Console.WriteLine(userAge);


    }
  }
}


Operator Shortcuts
Often we need to update a variable in our program. We can do so by modifying that variable using an arithmetic expression, then re-saving it to the same variable name:

using System;

namespace MakingProgress
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare steps variable
      int steps = 0;

      // Two steps forward 
      steps += 2;

      // One step back 
      steps -= 1;

      // Print result to the console
      Console.WriteLine(steps);
    }
  }
}


Modulo
One arithmetic operator that we haven’t covered yet and may be less familiar is a modulo. A modulo returns a remainder, what is left over when we divide a number by another number.

using System;

namespace ClassTeams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of students
      int students = 18;

      // Number of students in a group
      int groupSize = 5;

      // Does groupSize go evenly into students?
      Console.WriteLine(students % groupSize);

    }
  }
}


Built-In Methods
So how do we do more advanced mathematical operations? For example, how would we perform a square root on a number if the program doesn’t recognize a square root symbol?

There are several built-in methods that we can use to manipulate numerical data and perform more complex mathematical calculations. Here are a few:

Math.Abs()—will find the absolute value of a number. Example: Math.Abs(-5) returns 5.
Math.Sqrt()—will find the square root of a number. Example: Math.Sqrt(16) returns 4.
Math.Floor()—will round the given double or decimal down to the nearest whole number. Example: Math.Floor(8.65) returns 8.
Math.Min()—returns the smaller of two numbers. Example: Math.Min(39, 12) returns 12.

using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      // Use built-in methods and save to variable 
      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

      // Print the lowest number
      Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));


    }
  }
}


Using Documentation
We introduced you to a few common built-in methods, but there are many more out there! Now’s a good time to practice your documentation search skills. Take a moment to look up the following built-in methods to understand their usage:

Math.Pow()
Math.Max()
Math.Ceiling()

using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {

      double numberOne = 6.5;
      double numberTwo = 4;

      // Raise numberOne to the numberTwo power
      Console.WriteLine(Math.Pow(numberOne, numberTwo));

      // Round numberOne up
      Console.WriteLine(Math.Ceiling(numberOne));

      // Find the larger number between numberOne and numberTwo
      Console.WriteLine(Math.Max(numberOne, numberTwo));

    }
  }
}


Building Strings
A string is a group of characters surrounded by quotation marks, like "https://codecademy.com" or "To be or not to be." A string is just a collection of a smaller data type, char, which is a single character like “a” or “?”.

To define a variable as a string, you write the data type, then the variable name. Then set it equal to the value, which is inside of quotation marks :

using System;

namespace PrideAndPrejudice
{
  class Program
  {
    static void Main(string[] args)
    {
      // First string variable
      string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
      // Second string variable
      string firstSpeech = "\My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?";

      // Print variable and newline
      Console.WriteLine(firstSentence);
      Console.WriteLine("\n");
      Console.WriteLine(firstSpeech);
    }
  }
}


String Concatenation
Often, we want to combine strings together, or combine strings with a value that we’ve saved to a variable.

A common way to do is by using string concatenation. String concatenation is when we combine strings using the addition symbol (+), literally adding one string to another.

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time ";
      string middle = "And then this happened ";
      string end = "happy ever after";

      // Concatenate the string and the variables
      string story = beginning + middle + end;

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}


String Interpolation
While string concatenation is easy to read, it can get annoying to write. Another option is string interpolation. String interpolation was introduced in C# 6 and it enables us to insert our variable values and expressions in the middle of a string, without having to worry about spaces and punctuation.

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      // Interpolate the string and the variables
      string story = $"{beginning} there was a kid {middle} and died, after that {end}";

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}


Get Info About Strings
In addition to containing the value of a piece of text, strings also contain information about themselves. It can be useful to know these properties when working with strings. There are several built-in .NET methods that we can use to get more information about strings.

using System;

namespace PasswordCheck
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create password
      string password = "a92301j2add";

      // Get password length
      int passwordLength = password.Length;

      // Check if password uses symbol
      int passwordCheck = password.IndexOf("!");

      // Print results
      Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

    }
  }
}


Get Parts of Strings
We can also use built-in .NET methods to grab parts of strings or specific characters in a string.

using System;

namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";

      // Get first letter
      int charPosition = name.IndexOf("F");
      char firstLetter = name[charPosition];

      // Get last name
      charPosition = name.IndexOf("Abbasi");
      string lastName = name.Substring(charPosition);

      // Print results
      Console.WriteLine($"{firstLetter}. {lastName}");

    }
  }
}


Manipulate Strings
There are also built-in .NET methods that we can use to manipulate text data. Using these methods on a string doesn’t change the string itself, but creates an entirely new one.

using System;

namespace MovieScript
{
  class Program
  {
    static void Main(string[] args)
    {
      // Script line
      string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

      // Get camera directions
      int charPosition = script.IndexOf("Close");
      int length = "Close on".Length;
      string cameraDirections = script.Substring(charPosition, length);

      // Get scene description
      charPosition = script.IndexOf("a portrait");
      string sceneDescription = script.Substring(charPosition);

      // Make camera directions uppercase
      string cameraDirections = cameraDirections.ToUpper();

      // Make scene description lowercase
      string sceneDescription = sceneDescription.ToLower();

      // Print results
      Console.WriteLine = cameraDirections;
      Console.WriteLine = sceneDescription;
    }
  }
}


