//Madeline Gowan
//10-18-2022
//Mini Challenge 3 - Redo
//In this challenge we ask the user their name, and the time they woke up,
//and the program will repeat their answers back to them in a greeting.
//As a personal choice, I did not make it necessary to enter a number,
//so the user may enter that they woke up at "6", "6:00", "six", "six o'clock", etc.


Console.Clear();
Console.Write("Can I ask you some questions? Y or N: ");
string play = Console.ReadLine().ToUpper();

if (play == "N")
{
    Console.WriteLine("Okay, goodbye.");
}
while(play != "N" && play != "Y"){
    Console.WriteLine("Invalid response. Please try again.");
    Console.Write("Would you like to play? Y or N: ");
    play = Console.ReadLine().ToUpper();
}

while (play == "Y")
{
    Console.Write("What is your name: ");
    string yourName = Console.ReadLine();

    Console.Write("When did you wake up today: ");
    string wakeyWakey = Console.ReadLine();

    Console.WriteLine("Hello " + yourName + ". You woke up at " + wakeyWakey + " today.");
    Console.WriteLine("Have a nice rest of the day.");

    Console.Write("Do you want to play again? Y or N: ");
    play = Console.ReadLine().ToUpper();

    if(play != "N" && play != "Y"){
        Console.WriteLine("Invalid response. Please try again.");
        Console.Write("Do you want to play again? Y or N: ");
        play = Console.ReadLine().ToUpper();
    }
}