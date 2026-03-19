// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// This code says Hello, World!
Random randomizer = new Random();
// Makes a random number generator 
bool success = false;
// boolean to keep track 
while (success == false)
// Loop continues until user dices a 6 
{
    Console.WriteLine("Roll the dice");
    // The user presses enter to roll the dice
    Console.ReadLine();
// Create a random number between 1 and 6
    int dice = randomizer.Next(1, 7); 
    
    // numbers 1–6

    Console.WriteLine("You rolled: " + dice);
// The user must roll a 6 to win hejdå
    if (dice == 6)
    {
        Console.WriteLine("Congratulations! You rolled a 6!");
        success = true;
        // End of the loop if user rolls a 6 and writes a congratulation message to the console
    }
}