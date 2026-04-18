using System;
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


using System;

class Program
{
    static void Main()
    {
        // Startvärden
        Random randomizer = new Random();
        int credits = 100;
        int lives = 3;

        Console.WriteLine("Welcome to the dice game!");
        Console.WriteLine("You have 100 credits and 3 lives. All luck to you!!");

        // Huvudloop: Körs så länge vi har liv kvar och pengar kvar
        while (lives > 0 && credits > 0)
        {
            Console.WriteLine($"\nSaldo: {credits} | Lives: {lives}");
            int bet = 0;
            bool validBet = false;

            // Loop för att få ett korrekt bet (10, 30 eller 50)
            while (!validBet)
            {
                Console.Write("How much do you want to bet? (10, 30, 50): ");
                string input = Console.ReadLine();

                if (input == "10" || input == "30" || input == "50")
                {
                    bet = int.Parse(input);

                    // Kontrollera att man inte satsar mer än man har
                    if (bet <= credits)
                    {
                        validBet = true;
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough credits for that bet!");
                    }
                }
                else
                {
                    Console.WriteLine("Unfounded selection. Please select 10, 30, or 50.");
                }
            }

            // 1a. Slå tärningen (1-6)
            int roll = randomizer.Next(1, 7); // 1 till och med 6
            Console.WriteLine($"You hit one: {roll}");

            // 1b, 1g. Om tärningen är 1 eller 2 (Förlust)
            if (roll == 1 || roll == 2)
            {
                lives--;       // Minska liv
                credits -= bet; // Förlorar insatsen
                Console.WriteLine("Bummer! You lost your lives and credits");
            }
            // Om tärningen är 3 till 6 (Vinst)
            else
            {
                // Vi får tillbaka insatsen + vinst (totalt insatsen * 2)
                credits += bet;
                Console.WriteLine($"Good job! You won {bet} credits.");
            }
        }

        // Slutresultat när loopen avslutats
        Console.WriteLine("\n--- Game over ---");
        if (lives <= 0) Console.WriteLine("You ran out of lives!");
        if (credits <= 0) Console.WriteLine("You ran out of money!");

        Console.WriteLine($"Your final score was: {credits} credits.");
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- WELCOME TO THE COFFEESHOP ---");
        Console.WriteLine("Choose your coffee sort from the menu:");
        Console.WriteLine("1. Brewed coffee (25 kr)");
        Console.WriteLine("2. Cappuccino (40 kr)");
        Console.WriteLine("3. Café au lait (45 kr)");
        Console.WriteLine("4. Ice coffee (35 kr)");
        Console.WriteLine("----------------------------------");

        Console.Write("Your choice (number): ");
        string choice = Console.ReadLine();

        // ToLower()
        switch (choice.ToLower())
        {
            case "1":
            case "Brewed coffee":
                Console.WriteLine("You have selected brewed coffee. It will be 25kr ");
                break;

            case "2":
            case "cappuccino":
                Console.WriteLine("You have selected one creamy Cappuccino. That will be 40 kr.");
                break;

            case "3":
            case "latte":
                Console.WriteLine("You have selected one Big Café au lait. That will be 45 kr.");
                break;

            case "4":
            case "iskaffe":
                Console.WriteLine("You have chosen a refreshing Iced Coffee. That will be 35 kr.");
                break;

            default:
                Console.WriteLine("Unfortunately, that option is not on the menu.");
                break;
        }

        Console.WriteLine("Thank you for your visit! Come again!");
    }
}

using System;

class Program
{
    static void Main()
    {
        // Variabel för att hålla koll på priset
        int price = 0;
        string orderName = "";

        Console.WriteLine("BARISTA TERMINAL v1.0");
        Console.Write("Enter product code or name: ");

        // Läser in valet och gör om till små bokstäver
        string input = Console.ReadLine().ToLower().Trim();

        // Switch-satsen hanterar de olika kaffesorterna
        switch (input)
        {
            case "b":
            case "1":
            case "bre":
                orderName = "Brewed Coffee";
                price = 25;
                break;

            case "c":
            case "2":
            case "cap":
                orderName = "Cappuccino";
                price = 40;
                break;

            case "l":
            case "3":
            case "latte":
                orderName = "Latte";
                price = 45;
                break;

            case "i":
            case "4":
            case "icecoffee":
                orderName = "Icecoffee";
                price = 35;
                break;

            default:
                Console.WriteLine("Error: Unknown Product");
                return; // Avslutar programmet om produkten inte finns
        }

        // Ger tillbaka resultatet till baristan
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Order: {orderName}");
        Console.WriteLine($"Total: {price} kr");
        Console.WriteLine("-----------------------");
    }
}

List<string> coffeeMenu = new List<string> { "Espresso", "Latte", "Cappuccino", "Americano" };

Console.WriteLine("--- Coffee Menu ---");

for (int i = 0; i < coffeeMenu.Count; i++)
{
    // 'a' + 0 = 'a', 'a' + 1 = 'b', etc.
    char letter = (char)('a' + i);
    Console.WriteLine($"{letter}) {coffeeMenu[i]}");
}

Console.Write("\nPlease enter your choice: ");
string input = Console.ReadLine().ToLower();


using System;

class Program
{
    static void Main()
    {
        // 1. Display the Menu
        Console.WriteLine("Welcome to the Coffee Shop!");
        Console.WriteLine("---------------------------");
        Console.WriteLine("1. Espresso");
        Console.WriteLine("2. Latte");
        Console.WriteLine("3. Americano");
        Console.WriteLine("---------------------------");
        Console.WriteLine("4. Extra Sugar");
        Console.WriteLine("5. Additional Cream");
        Console.WriteLine("6. Oat Milk");

        Console.Write("\nEnter the number of your choice: ");

        // 2. Get the user's number
        string input = Console.ReadLine();

        // 3. Simple if/else logic
        if (input == "1") {
            Console.WriteLine("You selected: Espresso");
        }
        else if (input == "2") {
            Console.WriteLine("You selected: Latte");
        }
        else if (input == "3") {
            Console.WriteLine("You selected: Americano");
        }
        else if (input == "4") {
            Console.WriteLine("Added: Extra Sugar");
        }
        else if (input == "5") {
            Console.WriteLine("Added: Additional Cream");
        }
        else if (input == "6") {
            Console.WriteLine("Added: Oat Milk");
        }
        else {
            Console.WriteLine("Error: That number is not on the menu.");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        // 1. Visar användaren the "Cheat Sheet"
        Console.WriteLine("MENU: a=Espresso, b=Latte, c=Americano");
        Console.WriteLine("EXTRAS: d=Sugar, e=Cream, f=Oat Milk");
        Console.WriteLine("---------------------------------------");

        // 2. Hämta kodsträng
        Console.Write("Enter your codes (e.g., 'ae'): ");
        string input = Console.ReadLine().ToLower();

        Console.WriteLine("\nProcessing your order...");

        // 3. Loopen: Denna slinga tittar på varje bokstav i strängen en efter en
        foreach (char code in input)
        {
            // Vi använder en brytare för att avgöra vad varje bokstav betyder
            switch (code)
            {
                case 'a':
                    Console.WriteLine("- Espresso");
                    break;
                case 'b':
                    Console.WriteLine("- Latte");
                    break;
                case 'c':
                    Console.WriteLine("- Americano");
                    break;
                case 'd':
                    Console.WriteLine("- Added: Extra Sugar");
                    break;
                case 'e':
                    Console.WriteLine("- Added: Additional Cream");
                    break;
                case 'f':
                    Console.WriteLine("- Added: Oat Milk");
                    break;
                default:
                    Console.WriteLine($"- '{code}' is not a valid menu letter.");
                    break;
            }
        }

        Console.WriteLine("\nOrder Complete!");
    }
}

// 1. Skapa din Dictionary (listan med regler)
var coffeeSizes = new Dictionary<string, List<int>>
{
    { "Latte", new List<int> { 200, 350, 500 } },
    { "Espresso", new List<int> { 100, 200 } }
};

// 2. Fråga användaren (Här skapas variabeln!)
Console.WriteLine("Which coffee do you want? (Latte/Espresso)");
string selectedCoffee = Console.ReadLine(); // Nu finns "selectedCoffee"!

// 3. Kontrollera om kaffet finns i din lista överhuvudtaget
if (coffeeSizes.ContainsKey(selectedCoffee))
{
    // 4. Kolla om just 350ml finns för detta kaffe
    if (coffeeSizes[selectedCoffee].Contains(350))
    {
        Console.WriteLine("350ml is availble!");
    }
    else
    {
        Console.WriteLine($"Sorry, {selectedCoffee} is not served 350ml.");
    }
}
else
{
    Console.WriteLine("That coffee is not on the menu.");
}


// 1. Variabler för att hålla koll på valet
string selectedCoffee = "Cappuccino"; // Denna får du från användarens input
int selectedSize = 250;
string topping = "Additional Syrup Topping";
double basePrice = 3.50; // Pris för kaffet
double toppingPrice = 0.50; // Pris för topping
double totalPrice = basePrice + toppingPrice;

// 2. Skapa orderbeskrivningen (Order Description)
// Vi använder $"" (String Interpolation) för att enkelt baka in variabler i texten
string orderSummary = $"{selectedCoffee} {selectedSize}ml, {topping}, {totalPrice:F2}.";

// 3. Skriv ut till användaren
Console.WriteLine("--- Order Receipt ---");
Console.WriteLine(orderSummary);

CheckPassword();

void CheckPassword()
{
    Console.WriteLine("Enter your password:");
    string password = Console.ReadLine();

    bool passwordMatch = password.ToLower() == "pencil";

    if (passwordMatch)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Login failed");
    }
}


// Listan med användare (username, password)
string[][] users = [["john", "plate"], ["michelle", "bike"], ["lisa", "pencil"]];

LoginUser(users);

void LoginUser(string[][] userList)
{
    Console.WriteLine("Enter your username:");
    string username = Console.ReadLine();

    Console.WriteLine("Enter your password:");
    string password = Console.ReadLine();

    int userMatch = -1;

    // Loopa igenom listan
    for (int i = 0; i < userList.Length; i++)
    {
        if (userList[i][0] == username.ToLower())
        {
            userMatch = i;
            break;
        }
    }

    bool passwordMatch = false;


    // Om användaren hittades, kontrollera lösenordet
    if (userMatch > -1)
    {
        passwordMatch = password.ToLower() == userList[userMatch][1];
    }

    if (passwordMatch)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Login failed");
    }
}
*/
string[] nameArray =
{
    "Emma", "Tom", "Benjamin", "Elina"

};
int longestLength = GetLongestStringLength(nameArray);
Console.WriteLine("The longest word has this many letters: " + longestLength);
int GetLongestStringLength(string[] words)
{
    int maxLength = 0;
    foreach (var word in words)
    {
        if (word.Length > maxLength)
        {
            maxLength = word.Length;

        }
    }

    return maxLength;
}
