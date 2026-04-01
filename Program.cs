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

using System;
// 1. Be användaren mata in sitt namn
Console.Write("Write your name: ");
string name = Console.ReadLine();

// 2. Kontrollera om namnet börjar med "Lord"
// Vi använder StringComparison för att vara säkra på att den hittar "Lord" även om man skriver "lord"
if (name.StartsWith("Lord", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Welcome Your Excellency");
}
else
{
    Console.WriteLine($"Welcome {name}");
}


using System;

// 1. Skapa arrayen med kontobalanserna
int[] accountBalances = { 5506, 291, 500, 482, 963 };

// 2. Skapa en variabel för att hålla totalsumman (börja på 0)
int totalAmount = 0;

// 3. Använd en for-loop för att gå igenom arrayen
// Vi använder .Length för att loopen ska veta hur många gånger den ska köra
for (int i = 0; i < accountBalances.Length; i++)
{
    // Addera det aktuella värdet till totalAmount
    // += är ett kortare sätt att skriva: totalAmount = totalAmount + accountBalances[i]
    totalAmount += accountBalances[i];
}

// 4. Skriv ut det totala beloppet till konsolen
Console.WriteLine(totalAmount);


using System;

Console.WriteLine("Write some text:");
string input = Console.ReadLine();

// We check if input is null to avoid errors
if (!string.IsNullOrWhiteSpace(input))
{
    string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < words.Length; i++)
    {
        // Ternary operator: (condition) ? true : false
        words[i] = (i % 2 == 0) ? words[i].ToUpper() : words[i].ToLower();
    }

    string result = string.Join(" ", words);
    Console.WriteLine("\nResult:");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("You havent written any text!");
}

using System;

// 1. Fråga användaren om input
Console.WriteLine("Write some text:");
string input = Console.ReadLine();

// 2. Splitta texten in till två ord
string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

// 3. Loopa genom orden och se hur långt det ör
for (int i = 0; i < words.Length; i++)
{
    // Titta om ordet har mer än 6 bokstäver.
    if (words[i].Length > 6)
    {
        // Lägg till det "långa ordet" till det nurvarande ordet.
        words[i] = words[i] + " (long word)";
    }
}

// 4. Lägg ihop orden tillsammans och visa på skärmen.
string result = string.Join(" ", words);
Console.WriteLine("\nResultat:");
Console.WriteLine(result);
*/
using System;

// 1. Få in text ifrån användaren
Console.WriteLine("Write your own text:");
string input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input))
{
    // 2. Dela in till två ord
    string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    Console.WriteLine("\nResult:\n");

    // 3. Yttre loop: Iterera genom varje ord
    foreach (string word in words)
    {
        // 4. Inre loop: Skriv ut ordet ordlängd gånger
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(word + " ");
        }
        
        // 5. Flytta till en ny rad efter att repetitionerna är klara
        Console.WriteLine();
    }
}