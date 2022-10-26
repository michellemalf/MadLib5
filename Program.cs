//Michelle Malfabon
//October 25, 2022
//Peer Review: Valerie Aguilar
//Comment: Works Great!
//Description: Created a mad libs poem using 10 variables, user input(console.readline), stored into variables, and printed using concatination.  


//----------MINI 5 ----- MAD LIBS-----------////

//declare variables//
string color;
string pluralNoun;
string celebrity;
string animal;
string sound;
string food;
string pluralNoun2;
string adjective;
string pluralNoun3;
string activity;
bool playAgain= true;
string userChoice;

//while loop//
while (playAgain == true){
Console.WriteLine("Enter a color: ");
color = Console.ReadLine();

Console.WriteLine("Enter a plural noun: ");
pluralNoun = Console.ReadLine();

Console.WriteLine("Enter a celebrity: ");
celebrity = Console.ReadLine();

Console.WriteLine("Enter an animal: ");
animal = Console.ReadLine();

Console.WriteLine("Enter a sound: ");
sound = Console.ReadLine();

Console.WriteLine("Enter a food: ");
food = Console.ReadLine();

Console.WriteLine("Enter another plural noun: ");
pluralNoun2 = Console.ReadLine();

Console.WriteLine("Enter an adjective: ");
adjective = Console.ReadLine();

Console.WriteLine("Enter another plural noun: ");
pluralNoun3 = Console.ReadLine();

Console.WriteLine("Enter an activity: ");
activity = Console.ReadLine();

//printing the poem using the variables
Console.WriteLine("Roses are "+ color);
Console.WriteLine(pluralNoun+ " are blue");
Console.WriteLine("I love "+ celebrity + ", and you too!");
Console.WriteLine(animal + " says " + sound +"!");
Console.WriteLine("Ghosts say boooo!");
Console.WriteLine("I love  " + food + ", and you too!");
Console.WriteLine(pluralNoun2+ " are "+ adjective+ "," + pluralNoun3 + " are too.");
Console.WriteLine("I like "+ activity);
Console.WriteLine("But, yes, you guessed it... I lOVE YOU! <3");

Console.WriteLine("enter P to play again OR enter Q to quit");
userChoice = Console.ReadLine().ToUpper();

//condition for while loop
if (userChoice == "Q")
{
    playAgain = false;
}else if (userChoice == "P")
{
    playAgain = true;
} else{
    Console.WriteLine("Not a valid option, game over");
    playAgain = false;
}
}
