using System;

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
    }
}

// Lista med ord som spelet kan välja från
string[] words = { "cookie", "pie", "cake" };

// Skapar en slumpgenerator
Random random = new Random();

// Väljer ett slumpmässigt ord från listan
string word = words[random.Next(words.Length)];

// Skapar en array som ska visa _ _ _ istället för bokstäver
char[] display = new char[word.Length];

// Loop som fyller arrayen med _
for (int i = 0; i < display.Length; i++)
{
    display[i] = '_'; // varje plats blir _
}

// Antal försök spelaren har
int guesses = 10;
bool gameOver = false;
