Creating a Vector
The std::vector lives in the <vector> header. So first, we need to add this line of code at the top of the program:

#include <vector>
For review, #include is a preprocessor directive that tells the compiler to include whatever library that follows. In our case that is the standard vector library.

#include <iostream>
#include <vector>

int main() {
   
  std::vector<double> subway_adult;
  
  // Declare another vector here:
  std::vector<double> subway_child;
    
  
}


Initializing a Vector
Now we know how to create a vector, we can also initialize a vector, giving it values, as we are creating it in the same line.

#include <iostream>
#include <vector>

int main() {
   
  std::vector<double> subway_adult = {800, 1200, 1500};
  
  // Give subway_child some values:
  
  std::vector<double> subway_child = {400, 600, 750};
  
}

Index
Now that we have a vector, how do we access an individual element? This is where index comes into play.

An index refers to an element’s position within an ordered list. Vectors are 0-indexed, meaning the first element has index 0, the second index 1, and so on.

#include <iostream>
#include <vector>

int main() {
   
  std::vector<double> subway_adult = {800, 1200, 1500};
  
  std::vector<double> subway_child = {400, 600, 750};
  
  // What number at index 2 of subway_child?
  
  std::cout << subway_child[2] << "\n";
  
}

Adding and Removing Elements
Often, we start with a vector that’s either empty or a certain length. As we read or compute data we want, we can grow the vector as needed.

.push_back()
To add a new element to the “back”, or end of the vector, we can use the .push_back() function.

For example, suppose we have a vector called dna with three letter codes of nucleotides:

#include <iostream>
#include <vector>

int main() {
  
  std::vector<std::string> last_jedi;
  
  // Add characters here:
  last_jedi.push_back("kylo");
  last_jedi.push_back("rey");
  last_jedi.push_back("luke");
  last_jedi.push_back("finn");
  
  
  
  std::cout << last_jedi[0] << " ";
  std::cout << last_jedi[1] << " ";
  std::cout << last_jedi[2] << " ";
  std::cout << last_jedi[3] << " ";
  
}

.size()
<std::vector> not only stores the elements; it also stores the size of the vector:

size

The .size() function returns the number of elements in the vector.

#include <iostream>
#include <vector>

int main() {
  
  std::vector<std::string> grocery = {"Hot Pepper Jam", "Dragon Fruit", "Brussel Sprouts"};
    
  // Add more 
  grocery.push_back("Artichoke");
  std::cout << grocery.size() << "\n";
}


Operations
So what happens when you want to change each of the values within a vector?

You can use a for loop!

For example, suppose we have an int vector that looks like this:

1

You can write a for loop that iterates from 0 to vector.size(). And here’s the cool part: you can use the counter of the for loop as the index! Woah.


#include <iostream>
#include <vector>
  
int main() {
  
  std::vector<double> delivery_order;
  
  delivery_order.push_back(8.99);
  delivery_order.push_back(3.75);
  delivery_order.push_back(0.99);
  delivery_order.push_back(5.99);
  
  // Calculate the total using a for loop:
  
  double total = 0.0;
  
    for (int i = 0; i < delivery_order.size(); i++) {

  total = total + delivery_order[i];

}
  
  std::cout << "Total: $" << total << "\n";
}





Whale Talk
Takes a phrase like "turpentine and turtles" and translate it into its “whale talk” equivalent, "uueeieeauuee".

There are a few simple rules for translating text to whale language:

There are no consonants. Only vowels excluding the letter y.
The u‘s and e‘s are extra long, so we must double them.
Once we have converted text to the whale language, the result is sung slowly, as is custom in the ocean.

Write a whale.cpp program that accomplishes this translation using loops and vectors.

Let’s get started!

#include <iostream>
#include <vector>
#include <string>

int main() 
{
  
  //Whale, whale, whale.
  //What have we got here?
  
  std::string input = "turpentine and turtles";
  
  //Vowel Vector
  std::vector <char> vowels;
  //Push back for vowel vector
  vowels.push_back('a');
  vowels.push_back('e');
  vowels.push_back('i');
  vowels.push_back('o');
  vowels.push_back('u');
  //Result vector
  std::vector <char> result;
  
  //For loop
  for (int i = 0; i < input.size(); i++) {
    
    for (int j = 0; j < vowels.size(); j++) {
      
      if (input[i] == vowels[j]) {
        
        result.push_back(input[i]);
      }
        if (input[i] == 'u' || input[i] == 'e') {

  result.push_back(input[i]);

}
    }
    
  }
  
  for (int k = 0; k < result.size(); k++) {

  std::cout << result[k];

}
}