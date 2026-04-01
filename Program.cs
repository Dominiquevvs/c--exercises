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


// 1. Ask the user the question
Console.WriteLine("Do you have a gluten intolerance? (Yes/No)");

// 2. Accept their response
string choice = Console.ReadLine();

// 3. Process the logic using if-else
// We use ToLower() so that "YES" or "Yes" both match "yes"
if (choice.ToLower() == "yes")
{
    Console.WriteLine("You will be served gluten free food");
}
else if (choice.ToLower() == "no")
{
    Console.WriteLine("The regular menu will apply");
}
else
{
    Console.WriteLine("Unable to decide preference");
}
*/

Console.WriteLine("Wrtie some text");
string input = Console.ReadLine();
string replaceText = input.Replace(" ","");
string [] susTextArray = ["drop", "data", "base", "drp", "dta", "bse"];
string toLowerText = replaceText.ToLower();
bool badWord = false ;
foreach (string word in susTextArray)
{
    if (toLowerText.Contains(word))
    {
        badWord = true;
        break;
    }
}

if (badWord)
{
    Console.WriteLine("Error 103: Unable to process");
}
else
{
    Console.WriteLine("Proceed successfully");}