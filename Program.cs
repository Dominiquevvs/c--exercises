/*
// 1. Ask the user for the instrument
Console.WriteLine("Please enter the name of a music instrument:");

// 2. Input variable
string instrument = Console.ReadLine();

// 3.This
Console.WriteLine($"Can you play the {instrument}?");

Console.WriteLine("Please enter your familyname:");
string familyName = Console.ReadLine();
Console.WriteLine("Please enter your first name:");
string firstName = Console.ReadLine();
Console.WriteLine($"{firstName} {familyName} Joined the firm!");
*/

// 1. Ask for the full name
Console.WriteLine("Please enter your first and family name:");

// 2. Accept the response
string fullName = Console.ReadLine();

// 3. it splits into two parts
string[] nameParts = fullName.Split(" ");

// 4. Transform the cases 
string firstNameLower = nameParts[0].ToLower();
string lastNameUpper = nameParts[1].ToUpper();

// 5. Write to Console in the format: "LASTNAME, firstname : present"
Console.WriteLine($"{lastNameUpper}, {firstNameLower} : present");
