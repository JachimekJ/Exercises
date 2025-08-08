/*Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/
//Moja wersja
/*
int current = 0;
do
{
    current = new Random().Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/
/*
int current = new Random().Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = new Random().Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

//Wykorzystanie continue
/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);
*/

//CHALLENGE ROLE PLAYING GAME BATTLE CHALLENGE
/* Two characters - hero and monster, 10 hp limit, they hit each other until hp <= 0, char wchich first damage other to 0 win.

int heroHealth = 10;
int monsterHealth = 10;


do
{
    int damage = new Random().Next(1, 11);
    monsterHealth -= damage;
    Console.WriteLine($"Monster was damaged lost {damage} health and now has {monsterHealth}");

    if (monsterHealth <= 0) continue;

    damage = new Random().Next(1, 11);
    heroHealth -= damage;
    Console.WriteLine($"Hero was damaged lost {damage} health and now has {heroHealth}");
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
*/

// Pierwsze zadanie wprowadzania liczb przez usera. Jesli z przedzialu 5-10 wyswietla wartosc, jesli inny numer prosi o podanie liczby z przedzialu 5-10, jesli enter lub litery wysweietla blad. 
/*
string? readResult;
string userInput = "";
int value = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        userInput = readResult;
    }
    validNumber = int.TryParse(userInput, out value);

    if (validNumber == true)
    {
        if (value <= 5 || value >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {value}. Please enter a number between 5 and 10.");
        }

    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

}
while (validNumber == false);

Console.WriteLine($"Your input value ({value}) has been accepted.");
*/

/* Drugie cwiczenie, input Admin, Manager, User, konwersja na małe litery, wyświetlenie odpowieniego walidacyjnego
string? readResult;
string role = "";
bool roleEntry = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        role = readResult.Trim();
    }
    if (role.ToLower() == "administrator" || role.ToLower() == "manager" || role.ToLower() == "user")
    {
        roleEntry = true;
        
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Please try again.");
    }

} while (roleEntry == false);

Console.WriteLine($"Your input value ({role.ToUpper()}) has been accepted. Welcome!");

// \"{zmienna}\" Wyswietla jako "zmienna"
*/

//ZADANIE 3 PROGRAM MA ROZBIC CIAG ZDAN NA ZDANIE PO ZDANIU. NAMIERZAMY KROPKE WYSWIETLAMY ZDANIE I USUWAMY RESZTE
//KOLEJNO USUWAMY SPACJE I ZNOWU WYŚWIETLAMY ZDANIE DO KROPKI RESZTA USUWANA, FINALNIE CHCEMY WIDZIEC KAZDE ZDANIE OSOBNO LINIA PO LINI

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;
string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");
        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
