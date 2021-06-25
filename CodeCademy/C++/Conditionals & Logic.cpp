If Statement
An if statement is used to test an expression for truth and execute some code based on it. Here’s a simple form of the if statement:

if (condition) {

  some code

}
If the condition is true, then the statements within are executed. Otherwise, the statements are skipped and the program continues on.

#include <iostream>

int main() {

  int grade = 90;
  
  if (grade > 60) {
  
    std::cout << "Pass \n";

}

  
}

Relational Operators
When writing conditional statements, sometimes we need to use different types of operators to compare values. These operators are called relational operators.

To have a condition, we need relational operators:

== equal to
!= not equal to
> greater than
< less than
>= greater than or equal to
<= less than or equal to
Relational operators compare the value on the left with the value on the right.

#include <iostream>

int main() {

  int grade = 90;
  
  if (grade != 60) {
  
    std::cout << "Pass\n";
  
  }
  
}

Else Clause
We can also add an else clause to an if statement to provide code that will only be executed if the condition is false. Here’s a form of an if statement that includes an else clause:

if (condition) {

  do something

} else {

  do something else

}
If condition is true, statement1 is executed. Then the program skips statement2 and executes any code statements following the if/else clause.
If condition is false, statement1 is skipped and statement2 is executed. After statement2 completes, the program executes any code statements following the if/else clause.

#include <iostream>

int main() {

  int grade = 59;

  if (grade > 60) {

    std::cout << "Pass\n";

} 
else {
  
  std::cout << "Fail \n";
  
}
}

Else If
So what happens if you want more than two possible outcomes?

This is where else if comes in!

if (condition) {

  some code

} else if (condition) {

  some code

} else {

  some code

}
The else if statement always comes after the if statement and before the else statement. The else if statement also takes a condition.

#include <iostream>

int main() {
  
  double ph = 4.6;
  
  // Write the if, else if, else here:
  
  if (ph > 7) {
    
    std::cout << "Basic \n";
  }
  
  else if (ph < 7) {
    
    std::cout << "Acidic \n";
  }
  
  else {
    
    std::cout << "Neutral \n";
    
  }
}

Switch Statement
Now that we know how if, else if, else work, we can write programs that have multiple outcomes. Programs with multiple outcomes are so common that C++ provides a special statement for it… the switch statement!

A switch statement provides an alternative syntax that is easier to read and write. However, you are going to find these less frequently than if, else if, else in the wild.

#include <iostream>

int main() {
  
  int number = 9;
  
  switch(number) {
    
    case 1 :
      std::cout << "Bulbusaur\n";
      break;
    case 2 :
      std::cout << "Ivysaur\n";
      break;
    case 3 :
      std::cout << "Venusaur\n";
      break;
    case 4 :
      std::cout << "Charmander\n";
      break;
    case 5 :
      std::cout << "Charmeleon\n";
      break;
    case 6 :
      std::cout << "Charizard\n";
      break;
    case 7 :
      std::cout << "Squirtle\n";
      break;
    case 8 :
      std::cout << "Wartortle\n";
      break;
    case 9 :
      std::cout << "Blastoise\n";
    default :
      std::cout << "Unknown\n";
      break;
  
  }
  
}


Logical Operator: &&
The and logical operator is denoted by &&.

It returns true if the condition on the left and the condition on the right are both true. Otherwise, it returns false.

Here’s the truth table:

a	b	a && b
false	false	false
false	true	false
true	false	false
true	true	true

For instance:

( 1 < 2 && 2 < 3 ) returns true
( 1 < 2 && 2 > 3 ) returns false
Note: The keyword and can also be used in the place of &&.

#include <iostream>

int main() {
  
  int hunger = true;
  int anger = true;
  
  // Write the code below:
  
  if (hunger == true && anger == true) {
    
  std::cout << "Hangry\n";  
    
  }
  
  
}

Logical Operator: II
The or logical operator is denoted by ||.

It returns true when the condition on the left is true or the condition on the right is true. Only one of them needs to be true.

Here’s the truth table:

a	b	a || b
false	false	false
false	true	true
true	false	true
true	true	true

For instance:

( 1 < 2 || 2 > 3 ) returns true
( 1 > 2 || 2 > 3 ) returns false
Note: The keyword or can be used in the place of ||.

#include <iostream>

int main() {
  
  int day = 6;
  
  // Write the code below:
  if (day == 6 || day == 7 ) {
    
    std::cout << "Weekend\n";
    
  }

}

Logical Operator: !
The not logical operator is denoted by !.

It reverses the bool outcome of the expression that immediately follows.

Here’s the truth table:

a	!a
false	true
true	false

For instance:

( !true ) returns false
( !false ) returns true
( !(10 < 11) ) returns false
Note: The keyword not can be used in the place of !.

#include <iostream>

int main() {
  
  bool logged_in = false;
  
  // Write the code below:
  if (!logged_in) {
    
    std::cout << "Try Again\n";
    
  }
  
}








Magic 8-Ball
The Magic 8-Ball is a super popular toy used for fortune-telling or seeking advice, developed in the 1950s!

Write a magic8.cpp program that will output a random fortune each time it executes.

#include <iostream>
#include <cstdlib>
int main() 
{
  
  //your future is here
  
  std::cout << "MAGIC 8-BALL \n";
  
  
  srand(time(NULL));
  int answer = std::rand() % 11;
  
  
  if (answer == 0) {
    
    std::cout << "It is certain";
  }
  //new
  else if (answer == 1) {
    
    std::cout << "Dont get your hopes up";
  }
  //new
  else if (answer == 2) {
    
    std::cout << "Outlook not so good";
  }
  //new
  else if (answer == 3) {
    
    std::cout << "cannot predict now";
  }
  //new
  else if (answer == 4) {
    
    std::cout << "Signs point to yes";
  }
  //new
  else if (answer == 5) {
    
    std::cout << "Ask again later";
  }
  //new
  else if (answer == 6) {
    
    std::cout << "Dont count on it";
  }
  //new
  else if (answer == 7) {
    
    std::cout << "Thats out of my power";
  }
  //new
  else if (answer == 8) {
    
    std::cout << "Try and ask someone else";
  }
  //new
  else if (answer == 9) {
    
    std::cout << "Negative";
  }
  //new
  else {
    
    std::cout << "Very doubtful";
  }
  
  
}








Harry Potter Sorting Hat Quiz
“A thousand years or more ago,
When I was newly sewn,
There lived four wizards of renown,
Whose names are still well known.”

The Hogwarts School of Witchcraft and Wizardry welcomes you! First-year students must go through the annual Sorting Ceremony.

#include <iostream>

int main() 
{
  //The different houses
  int gryffindor = 0, hufflepuff = 0, ravenclaw = 0, slytherin = 0;
  //Answers
  int answer1 = 0, answer2 = 0, answer3 = 0, answer4 = 0;
  
  //start of the quiz
  
  std::cout << "|=====================|\n";
  std::cout << "|THE SORTING HAT QUIZ |\n";
  std::cout << "|=====================|\n\n";
  
  //Question 1
  std::cout << "Q1 When I'm dead, I want people to remember me as: \n\n";
  std::cout << "1) The Good\n";
  std::cout << "2) The Great\n";
  std::cout << "3) The Wise\n";
  std::cout << "4) The Bold\n";
  
  std::cout << "Enter your answer (1-4):";
  //User's answer 1
  std::cin >> answer1;
  //New line
  std::cout << "\n";
  
  //point from Q1
  if (answer1 == 1) {
    
  hufflepuff++;
  }
   else if (answer1 == 2) {
    
  slytherin++;
  }
   else if (answer1 == 3) {
    
  ravenclaw++;
  }
   else if (answer1 == 4) {
    
  gryffindor++;
  }
  else {
    
    std::cout << "Invalid input \n";
  }
  
  //Question 2
  std::cout << "Q2) Dawn or Dusk?\n\n";
  std::cout << "1) Dawn\n";
  std::cout << "2) Dusk\n";
  
  std::cout << "Enter your answer (1-2):";
  //user answer 2
  std::cin >> answer2;
    //New line
  std::cout << "\n";
  
  //points for Q2
  if (answer2 == 1) {
    
    gryffindor++;
    ravenclaw++;
  }
  else if (answer2 == 2) {
    
    hufflepuff++;
    slytherin++;
  }
  else {
    
    std::cout << "Invalid input";
    
  }
  
  //Question 3
  std::cout << "Q3 Which kind of instrument most pleases your ear\n\n";
  std::cout << "1) The violin\n";
  std::cout << "2) The Trumpet\n";
  std::cout << "3) The Piano\n";
  std::cout << "4) The Drum\n";
  
  std::cout << "Enter your answer (1-4):";
  
  //user answer 3
  std::cin >> answer3;
    //New line
  std::cout << "\n";
  
  //points for Q3
  if (answer3 == 1) {
    
    slytherin++;
  }
  else if (answer3 == 2) {
    
    hufflepuff++;
  }
  else if (answer3 == 3) {
    
    ravenclaw++;
  }
  else if (answer4 == 4) {
    
    gryffindor++;
  }
  else {
    
    std::cout << "Invalid input";
  }
  
  //Question 4
  std::cout << "Q4 Which road tempts you most?\n\n";
  std::cout << "1) The wide, sunny grassy lane\n";
  std::cout << "2) The narrow, dark, lantern-lit alley\n";
  std::cout << "3) The twisting, leaf-strewn path through wood\n";
  std::cout << "4) The cobbled street lined (ancient buildings)\n";
  
  std::cout << "Enter your answer (1-4):";
  //User answer 4
  std::cin >> answer4;
    //New line
  std::cout << "\n";
  
  //Points for Q4
  if (answer4 == 1) {
    
    hufflepuff++;
  }
  else if (answer4 == 2) {
    
    slytherin++;
  }
    else if (answer4 == 3) {
    
    gryffindor++;
  }
    else if (answer4 == 4) {
    
    ravenclaw++;
  }
  else {
    
    std::cout << "Invalid input";
  }
  
  //Choosing house
  int max = 0;
  std::string house;
  
  //Points in each house
  if (gryffindor > max) {
    
    max = gryffindor;
    house = "Aaaah this is a simple one\n\nGryffindor!";
  }
  if (hufflepuff > max) {
    
    max= hufflepuff;
    house = "No doubt! \n\n" "Hufflepuff!";
  }
    if (ravenclaw > max) {
    
    max= ravenclaw;
    house = "Hmm, you remind me of someone..\n\n""Ravenclaw!";
  }
    if (slytherin > max) {
    
    max= slytherin;
    house = "You belong to the dark side for sure \n\n""slytherin!";
  }
  
  std::cout << house << "!\n";
  
  
}




Rock, Paper, Scissors, Lizard, Spock
You may have played Rock, Paper, Scissors, but have you played Rock, Paper, Scissors, Lizard, Spock? This is the infamous game brought to popularity with the TV show The Big Bang Theory.

Rock Paper Scissors Lizard Spock

Write a rock_paper_scissors.cpp program that:

Prompts the user to select either Rock, Paper, Scissors, Lizard, or Spock.
Instructs the computer to randomly select either Rock, Paper, Scissors, Lizard, or Spock.
Compares the user’s choice and the computer’s choice and determine the winner.
Informs the user who the winner is.


/*
Rock paper scissors
From the big bang theory
*/

#include <iostream>
#include <stdlib.h>

// Random Number for computer and user input
int main() {
  
  srand (time(NULL));

int computer = rand() % 3 + 1;

int user = 0;
  
//Start of the game
std::cout << "====================\n";
std::cout << "rock paper scissors!\n";
std::cout << "====================\n";
  
std::cout << "1) Rock!\n";
std::cout << "2) Paper!\n";
std::cout << "3) Scissors!\n";

std::cout << "shoot! ";

std::cin >> user;

//If statements for User
if (user == 1) {
  
  std::cout << "You choose Rock!\n";
}
else if (user == 2) {
  
  std::cout << "You choose Paper!\n";
}
else if (user == 3) {
  
  std::cout << "You choose Scissors!\n";
}
else {
  
  std::cout << "Pick something between 1-3!!\n";
}
  
//If statements for Computer
if (computer == 1) {
  
  std::cout << "Computer choose Rock!\n";
}
else if (computer == 2) {
  
  std::cout << "Computer choose Paper!\n";
}
else if (computer == 3) {
  
  std::cout << "Computer choose Scissors!\n";
}
else {
  
  std::cout << "Pick something between 1-3!!\n";
}
  
  //tie result
  if (user == computer) {
    
    std::cout << "its a Tie!\n";
  } 
  
  //rock
  else if (user == 1) {
    
    if (computer == 2) {
      
      std::cout << "You Lost! Try again!\n";
      
    }
    if (computer == 3) {
      
      std::cout << "You won! Good job!\n";
    }
    
  }
  //paper
  else if (user == 2) {
    
    if (computer == 1) {
      
      std::cout << "You won! Good job!\n";
    }
    if (computer == 3) {
      
      std::cout << "You Lost! Try again\n";
    }
    
  }
  //Scissors
  else if (user == 3) {
    
    if (computer == 1) {
      
      std::cout << "You Lost! Try Again\n";
    }
    if (computer == 2) {
      
      std::cout << "You Won! Good job!\n";
    }
  }
  
  
}