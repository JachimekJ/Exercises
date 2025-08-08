/*
bool flag = true;
int value = 0;
if (flag)
{
    
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
    Console.WriteLine($"Outside the code block: {value}");

*/

/*SPRAWDZENIE WYSWIETLENIA Z ZADANIA
bool flag;
int variable;
variable = 5;

if (variable > 0 == true)
{
    variable = 6;
    variable += variable;
}
Console.WriteLine($"Variable value: {variable}");

*/

/* Zadanie posprzatac kod tak zeby wyswietlal output 
Set contains 42
Total: 108
*/

/*ROZWIAZANIE AUTORA
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}"); */

//MOJE ROZWIAZANIE
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
 
foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");