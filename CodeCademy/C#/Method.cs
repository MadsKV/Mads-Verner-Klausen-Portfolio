Call a Method
You’ve been using methods since you started learning C#! Commands like Console.WriteLine() and Math.Min() are methods.

Each method has a different behavior: The first method prints something to the console, and the second finds the smallest of two given numbers. We activate a method’s behavior by calling it. In C# we do this by adding parentheses to the end of a method name.

using System;

namespace CallAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      string msg = "Yabba dabba doo!";
      Math.Min(20, 30);

      Console.WriteLine(msg);
      string msg.Substring(0, 1);
    }
  }
}


Capture Output
Like a math function or a factory machine, a method takes input and returns output. We’ve just seen how input works (arguments). Let’s see how output works.

using System;

namespace CaptureOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";
      
      int indexOfSpace = designer.IndexOf(" ");
      
      string secondName = designer.Substring(indexOfSpace);
      
      Console.WriteLine(secondName);
    }
  }
}


Define a Method
Up until now, you’ve been calling built-in methods: methods that are available whenever you use C#. Sometimes you need a custom method for your specific program. In that case, you’ll need to define your own!

using System;

namespace DefineAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
    }
    static void VisitPlanets()
    {
        Console.WriteLine("You visited many new planets");
    }
  }
}


Define Parameters
Remember calling methods with arguments, like Math.Min(3, 4)? Methods that you define can use arguments as well, making them more versatile and useful.

While we are defining our method, we don’t know the actual argument values that will be used when calling the method. But we do know the expected data type and how it will be used. We can use this information to define a parameter, which sort of works like a variable within a method. Imagine it as a placeholder for the actual argument value.

using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(2);
      VisitPlanets(7);
      VisitPlanets(23);
    }
    
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}


A Note on Parameters
One thing to watch for with parameters: they can only be used inside their method!

using System;

namespace ANoteOnParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
      numberOfPlanets();
    }
    
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}


Optional Parameters
To make our functions even more flexible, we can make certain parameters optional. If someone calls your method without all the parameters, the method will assign a default value to those missing parameters.

using System;

namespace OptionalParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
      VisitPlanets();
      VisitPlanets();
    }
    
    static void VisitPlanets(int numberOfPlanets = 0)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}


Named Arguments
Say your method has lots of optional parameters, but you only want to specify one when you call it.

using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(numberOfPlanets: 2);
      VisitPlanets(numberOfPlanets: 2, name: "Mads");
    }
    
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}


Method Overloading
Say you want to use Math.Round(), a built-in method. You go to the Microsoft documentation to learn how to use it, and find at least 8 different versions! They all have the same name: Math.Round().

What’s happening here is called method overloading, and each “version” is called an overload. Though they have the same name, the overloads are different because they have either (i) different parameter types or (ii) different number of parameters. This is useful if you want the same method to have different behavior based on its inputs.

Let’s examine this concept with these two overloads: Math.Round(Double, Int32) and Math.Round(Double).

The first overload, Math.Round(Double, Int32), rounds the double to the int‘s number of decimal points

using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets("Laika", "Albert");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();
    }
    
    static void NamePets(string pet1, string pet2)
    {
      Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
    }  
    
    static void NamePets(string pet1, string pet2, string pet3)
    {
      Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
    }  
    
    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
  }
}


