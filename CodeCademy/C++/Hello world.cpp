#include <iostream>

int main() {
  
  std::cout << "Hello World!\n";

}

Output
High five! We just got your first program to run.

C++, like most programming languages, runs line by line, from top to bottom. Here is the structure of a C++ program:

#include <iostream>

int main() {
  
  std::cout << "Codecademy\n";
  
}


Pattern

#include <iostream>

int main() 
{
  
  std::cout << "       1\n";
  std::cout << "     2 3\n";
  std::cout << "   4 5 6\n";
  std::cout << "7 8 9 10\n";
}

Review
Woohoo! You have written a few C++ programs. 🙌

In this lesson, you have learned:

C++ is a general-purpose coding language.
C++ runs line by line, from top to bottom.
std::cout is how you output to the terminal:

#include <iostream>

int main() 
{
  
  std::cout << "Dear Self,\n";
  std::cout << "Im gonna learn multiple coding languages,\n";
  std::cout << "I Will master this coding thing!";
  
  
  
  
}




Compile and Execute
Compile: A computer can only understand machine code. A compiler can translate the C++ programs that we write into machine code. To compile a file, you need to type g++ followed by the file name in the terminal:

#include <iostream>

int main() 
{
  
  std::cout << "Hello World!\n";
  
}

Compile and Execute (Naming Executables)
Compile: Sometimes when we compile, we want to give the output executable file a specific name. To do so, the compile command is slightly different. We still need to write g++ and the file name in the terminal. After that, there should be -o and then the name that you want to give to the executable file:

#include <iostream>

int main() 
{
  
  std::cout << "Hello World!\n";
  
  
  
}

Comments
Programming is often highly collaborative. In addition, our own code can quickly become difficult to understand when we return to it — sometimes only a few hours later! For these reasons, it’s often useful to leave notes in our code for ourselves or other developers.

As we write a C++ program, we can write comments in the code that the compiler will ignore as our program runs. These comments exist just for human readers.

Comments can explain what the code is doing, leave instructions for developers using the code, or add any other useful annotations.

// Harry Potter
#include <iostream>

int main() 
{
  
  std::cout << "Expecto Patronum\n";
  
}

Block Letters
Write a C++ program called initials.cpp that displays the initials of your name in block letters as shown:

#include <iostream>

int main() 
{
  //Coden er indenfor { "Code Her"  }
  
  //Det tog alt for lang tid
  std::cout << "M       M   K    K\n";
  std::cout << "MM     MM   K   K\n";
  std::cout << "MM     MM   K  K \n";
  std::cout << "M   M   M   KK  \n";
  std::cout << "M       M   K  K \n";
  std::cout << "M       M   K   K\n";
  std::cout << "M       M   K    K\n";

  //Coden er indenfor { "Code Her"  }
  
}