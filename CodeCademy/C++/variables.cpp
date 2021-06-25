Step 1: Declare a Variable
"Every variable in C++ must be declared before it can be used!"
Suppose we are building a game and we want to keep track of a player’s score that goes from 0 to 10. We need a variable!

Before we can use a variable, we must declare, or create, it. To declare a variable, we need to provide two things:

A type for the variable.
A name for the variable.

#include <iostream>

int main() 
{

  // Declare a variable
  int year;
  
}

Step 2: Initialize a Variable
After we declare a variable, we can give it a value!

#include <iostream>

int main() {
  
  // Declare a variable   
  int year;
  
  // Initialize a variable
  year = 2019;
   
}

Combining Step 1 and Step 2
We can both declare and assign a value to a variable in a single initialization statement.

#include <iostream>

int main() {

   int score = 0;
   
   // Declare and initialize a variable here
   int year = 2019;
   
   return 0;
   
}

Arithmetic Operators
Computers are incredible at doing calculations. Now that we have declared variables, let’s use them with arithmetic operators to calculate things!

Here are some arithmetic operators:

+ addition
- subtraction
* multiplication
/ division
% modulo (divides and gives the remainder)

#include <iostream>

int main() {

  int score = 0;

  // Change score here:
  score = 1234 * 99;
  
  std::cout << score << "/n";
  
}

Chaining
Now that we have outputted a variable and have also outputted things using multiple couts. Let’s take a closer look at cout again.

#include <iostream>

int main() {
  
  int score = 0;
  
  // Output
  std::cout << "Player score: " << score << "\n";
   
}

User Input
Like we mentioned in the introduction, another way to assign a value to a variable is through user input. A lot of times, we want the user of the program to enter information for the program.

We have cout for output, and there is something called cin that’s used for input!

#include <iostream>

int main() {
  
  int tip = 0;
  
  std::cout << "Enter tip amount: ";
  std::cin >> tip;
  
  std::cout << "You paid " << tip << " dollars."; 
  
}

Challenge: Temperature (Part 1)
Now that we’ve learned about the basics of variables and cin, let’s write a program!

The mad scientist Kelvin has mastered predicting the weather in his mountain-side meteorology lab.

Recently, Kelvin began publishing his weather forecasts on his website, however, there’s a problem: All of his forecasts describe the temperature in Fahrenheit degrees.

Let’s convert a temperature from Fahrenheit (F) to Celsius (C).

The formula is the following:

C = (F - 32) / 1.8C=(F−32)/1.8

#include <iostream>

int main() {
  
  //De forskellige grader, tempc ud fra tempf
  double tempf = 39;
  double tempc = (tempf - 32) / 1.8;
  
  
  //output graden i tempc
  std::cout << "The temp is " << tempc << " degrees Celsius. \n";
  
  
}Challenge: Temperature (Part 2)
Let’s go back to the temperature.cpp that we wrote. This time, instead of giving tempf a value of the current temperature in New York:

#include <iostream>

int main() {
  
  double tempf;
  double tempc;
  
  // Ask the user
  std::cout << "Enter the temperature in Fahrenheit: \n";
  std::cin >> tempf;
  
  
  tempc = (tempf - 32) / 1.8;
  
  std::cout << "The temp is " << tempc << " degrees Celsius.\n";
  
}



Dog Years
"How old is your fuzzy friend in human years?"

#include <iostream>

int main() {
  
  //gismos age
  int dog_age = 11;
  
  
  int early_years = 21;
  int later_years = (dog_age - 2) * 4;
  int human_years = early_years + later_years;
  
  std::cout << "My name is Gismo! Ruff ruff, I am " << human_years << " years old in human years.";
}

Quadratic Formula
In algebra, a quadratic equation is an equation having the form:

ax^2 + bx + c = 0ax 
2
 +bx+c=0
Graphing, we get the curve below:

Graph

The corresponding x values are the x-intercepts of the graph, while a, b, and c are constants.

Write a C++ program called quadratic.cpp that solves the quadratic equation for the x‘s:

x = \frac{-b\pm\sqrt{b^2-4ac}}{2a}x= 
2a
−b± 
b 
2
 −4ac
​
 
​
#include <iostream>
#include <cmath>

int main() {
  
  double a, b, c;
  
  std::cout << "Enter a \n";
  std::cin >> a;
  
  std::cout << "Enter b \n";
  std::cin >> b;
  
  std::cout << "Enter c \n";
  std::cin >> c;
  
  double root1, root2;
  
  root1 = (-b + std::sqrt(b*b - 4*a*c)) / (2*a); 
  root2 = (-b - std::sqrt(b*b - 4*a*c)) / (2*a); 
  
  std::cout << "root 1 is " << root1 << "\n";
  std::cout << "root 2 is " << root2 << "\n";
}

Piggy Bank
You just returned from a trip to South America. The countries you visited were Colombia, Brazil, and Peru. You arrived back in your country with some foreign currencies from these three countries.

#include <iostream>

int main() {
  
  double pesos, reais, soles;
  
  double dollars;
  //1 dollar = 0.00029 pesos
  std::cout << "Enter number of Colombian Pesos: \n";
  std::cin >> pesos;
  //1 dollar = 0,23 reais
  std::cout << "Enter number of Brazilian reais: \n";
  std::cin >> reais;
  //1 dollar = 0,30 soles
  std::cout << "Enter number of Peruvian soles: \n";
  std::cin >> soles;
  
  dollars = 0.00029 * pesos + 0.23 * reais + 0.3 * soles;
  
  std::cout << "US Dollars = $" << dollars << "\n";
  
}