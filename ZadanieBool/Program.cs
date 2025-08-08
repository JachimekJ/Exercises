//In this challenge, you'll implement a conditional operator to simulate a "coin flip."
//The resulting decision logic will display either heads or tails.
/*
int coinFlip = new Random().Next(0, 2); 
Console.WriteLine(coinFlip == 0 ? "Heads" : "Tail");
*/
/*Druga mozliwość kodu:
Random coin = new Random(); //tworzenie obiektu Random
int flip = coin.Next(0, 2); //generowanie losowej liczby 0 lub 1
Console.WriteLine(flip == 0 ? "Heads" : "Tail"); //wyświetlanie wyniku
*/

/* Zadanie 2
In this challenge, you implement decision logic based on a series of business rules.
The business rules specify the access that is granted to users based on their role-based permissions and their career level.
Code branches display a different message to the user depending on their permissions and level.
*/

string permission = "Admin|Manager"; // Example permissions, can be "Admin", "Manager", or both
int level = 19;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}

else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}

else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}

else if (permission.Contains("Manager") && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}