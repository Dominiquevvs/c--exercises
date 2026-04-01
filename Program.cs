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


using System;
// 1. Be om lösenord
Console.Write("Write your password: ");
string password = Console.ReadLine();

// 2. Be om e-mail
Console.Write("Write your emailadress: ");
string email = Console.ReadLine();

// 3. Kontrollera kraven
bool passwordOk = password.Length >= 7;
bool emailOk = email.EndsWith(".se") || email.EndsWith(".com");

// 4. Ge feedback till användaren

if (!passwordOk)
{
    Console.WriteLine("The password needs to be seven letters or more.");
}

if (!emailOk)
{
    Console.WriteLine("E-postadressen måste vara av typen .se eller .com.");
}

// 5. Om allt är rätt
if (passwordOk && emailOk)
{
    Console.WriteLine("Ett konto har skapats.");
}
*/

using System;
   
   // 1. Be användaren mata in en mening
   Console.WriteLine("Write a message that contains at least seven words:");
   string input = Console.ReadLine();
   
   // 2. Dela upp meningen i ord baserat på mellanslag
   // StringSplitOptions.RemoveEmptyEntries gör att extra mellanslag inte räknas som ord
   string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
   
   // 3. Kontrollera om antalet ord är minst sju
   if (words.Length >= 7)
   {
       Console.WriteLine("Sentence accepted");
   }
   else
   {
       Console.WriteLine("Not a correct sentence");
   }
   