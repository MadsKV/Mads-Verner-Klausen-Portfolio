While Loop Demo
So first up… the while loop!

Before we dive deep into the syntax of the while loop, let’s do a demo.

Inside enter_pin.cpp, we have a program that asks and checks for a password. It uses a while loop to ask the user for the password over and over again.

#include <iostream>

int main() {
  
  int pin = 0;
  int tries = 0;
  
  std::cout << "BANK OF CODECADEMY\n";
  
  std::cout << "Enter your PIN: ";
  std::cin >> pin;
  
  while (pin != 1234 && tries <= 3) {
    
    std::cout << "Enter your PIN: ";
    std::cin >> pin;
    tries++;
    
  }
  
  if (pin == 1234) {
    
    std::cout << "PIN accepted!\n";
    std::cout << "You now have access.\n"; 
    
  }
  
}


Guess Number
So now that we got a demo of loops, let’s write one!

The while loop looks very similar to an if statement. And just like an if statement, it executes the code inside of it if the condition is true.

However, the difference is that the while loop will continue to execute the code inside of it, over and over again, as long as the condition is true.

#include <iostream>

int main() {

  int guess;
  
  int tries = 0;

  std::cout << "I have a number 1-10.\n";
  std::cout << "Please guess it: ";
  std::cin >> guess;
 
  // Write a while loop here:
  while (guess != 8 && tries < 50) {
    
    std::cout << "Wrong guess, try again: ";
    std::cin >> guess;
    
    tries++;
    
  }
  
  if (guess == 8) {
    
    std::cout << "You got it!\n";
  
  }  
  
}


While Loop
The last one we held your hand, so let’s try one on your own.

As an example of iteration, we have the first program ever to run on a stored-program computer (the EDSAC). It was written and run by David Wheeler in the computer laboratory at Cambridge University, England, on May 6th, 1948, to calculate and print a simple list of squares like the following:

0   0
1   1
2   4
3   9
4   16
5   25
6   36
7   49
8   64
9   81
On the left, there are numbers from 0 to 9. On the right are their squares. For example, for the number 9, 9 * 9 = 81.


#include <iostream>

int main() {
  
  int i = 0;
  int square = 0;
  
  // Write a while loop here:
  while (i < 10) {

  square = i * i;

  std::cout << i << "  " << square << "\n";

  i++;

}
}

For Loop Demo

FoxTrot

Iterating over a sequence of numbers is so common that C++, like most other programming languages, has a special syntax for it.

When we know exactly how many times we want to iterate (or when we are counting), we can use a for loop instead of a while loop:


#include <iostream>

int main() {

  for (int i = 0; i < 10; i++) {
    
    std::cout << "I will not throw paper airplanes in class.\n";
    
  }
  
}



99 Bottles
In the last exercise, we saw an example of an incrementing for loop so here we are going to show you how to write a for loop where the counter goes down. When we know exactly how many times we want to iterate (or when we are counting), we can use a for loop instead of a while loop:

#include <iostream>

int main() {

  // Write a for loop here:
  for (int i = 99; i > 0; i--) {
    
    std::cout << i << " bottles of pop on the wall.\n";
    std::cout << "Take one down and pass it around.\n";
    std::cout << i - 1 << " bottles of pop on the wall.\n\n";
    
  }
  
  std::cout << "No more bottles of pop on the wall.\n";
  std::cout << "No more bottles of pop. \n";
  std::cout << "Go to the store and buy some more,\n";
  std::cout << "99 bottles of pop on the wall.\n";
}







Fizz Buzz
Fizz Buzz is a classic developer interview question that is asked or referred to so often for so long, it is almost a cliché!

Though this challenge will appear very simplistic to those with some coding experience, it is designed to weed out 99.5% programming job candidates who cannot creatively use their coding knowledge to solve simple problems.

#include <iostream>

int main() 
{
  
  //Ouch
  for (int i = 1; i <= 100; i++) {
    
    if (i % 15 == 0) {
      
      std::cout << "FizzBuzz!\n";
    }
    
    
    else if (i % 5 == 0) {
      
      std::cout << "Fizz!\n";
    }
    
    else if (i % 3 == 0) {
      
      std::cout << "Buzz!\n";
    }
    
    else {
      
      std::cout << i << "\n";
    }
    
  }
}






Compile-time Errors
When we are writing C++ programs, the compiler is our first line of defense against errors.

There are two types of compile-time errors:

Syntax errors: Errors that occur when we violate the rules of C++ syntax.
Type errors: Errors that occur when there are mismatch between the types we declared.
Some common syntax errors are:

Missing semicolon ;
Missing closing parenthesis ), square bracket ], or curly brace }
Some common type errors are:

Forgetting to declare a variable
Storing a value into the wrong type

#include <iostream>

int main() {
  
  char answer;
  int score = 0;
  
  std::cout << "Who Wants To Be a Millionaire\n\n";
  
  std::cout << "Question 1)\n\n";
  
  std::cout << "For ordering his favorite beverages on demand, LBJ had four buttons installed in the Oval Office labeled 'Coffee', 'Tea', 'Coke', and what?\n\n";
  
  std::cout << "A. Fresca   B. V8  \n";
  std::cout << "C. Yoo-hoo  D. A&W \n\n";
  
  std::cout << "Enter your answer: ";
  std::cin >> answer;
  
  if (answer == 'A' || answer == 'a') {
    
    score = score + 100;
    std::cout << "Correct!\n";
    
  }
  
}


Link-time Errors
Sometimes the code compiles fine, but there is still a message because the program needs some function or library that it can’t find. This is known as a link-time error.

As our program gets bigger, it is good practice to divide the program into separate files. After compiling them, the linker takes those separate object files and combines them into a single executable file. Link-time errors are found by the linker when it is trying to combine object files into an executable file.

Some common link-time errors:

Using a function that was never defined (more on this later)
Writing Main() instead of main()


#include <iostream>

int main() {
  
  int num = 0;
  int sum = 0;
  
  std::cout << "Enter a number: ";
  std::cin >> num;
  
  for (int i = 1; i <= num; i++) {
    
    sum = sum + i;
    std::cout << i << " ";
    
  }
  
  std::cout << "Sum: " << sum << "\n";
  
}



Run-time Errors
If our program has no compile-time errors and no link-time errors, it’ll run. This is where the fun really starts.

Errors which happen during program execution (run-time) after successful compilation are called run-time errors. Run-time errors occur when a program with no compile-time errors and link-time errors asks the computer to do something that the computer is unable to reliably do.


#include <iostream>

int main() {
  
  int width = 20;
  int length = 30;

  int ratio = width / length;
  
  std::cout << ratio << "\n";
  
}



Logic Errors
Once we have removed the compile-time errors, link-time errors, and run-time errors, the program runs successfully. But sometimes, the program doesn’t do what we want it to do or no output is produced. Hmmm…

These types of errors which provide incorrect output, but appears to be error-free, are called logical errors. These are one of the most common errors that happen to beginners and also usually the most difficult to find and eliminate.

Logical errors solely depend on the logical thinking of the programmer. Your job now is to figure out why the program didn’t do what you wanted it to do.

Some common logic errors:

Program logic is flawed
Some “silly” mistake in an if statement or a for/while loop



#include <iostream>

int main() {
  
  // Output from 1 to steps:
  
  int steps = 10;
  
  for (int i = 1; i <= steps; i++) {
    
    std::cout << "Step #";
    std::cout << i << "\n";
    
  }
  
}