//Test, wykrycie błędu
/*Question: Is it possible that attempting to change the value's data type would throw an exception at run time?
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);
Otrzymamy error

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
Otrzymamy 24
*/


/*Question: Is it possible that attempting to change the value's data type would result in a loss of information?
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal; //konwersja myDecimal na int //RZUTOWANIE/CASTING
Console.WriteLine($"int: {myInt}");
*/

/* Narrowing conversion - when you convert a value from data type that can hold more information to a data type with holding less info.
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
*/

//Use to convert a number to a ToString()string
/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
*/
/*
//Convert a to an using the helper methodstringintParse()

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
*/
//TAKA KONWERSJA JEST RYZYKOWNA LEPIEJ UŻYĆ .TryParse()

//Convert a to a using the classstringintConvert
/*
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

**HINT**
So, when should you use the Convert class? The Convert class is best for converting fractional numbers
into whole numbers (int) because it rounds up the way you would expect.

*/


//Compare casting and converting a into an decimalint
/*
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

**Casting truncates and converting rounds
When you're casting int value = (int)1.5m;, 
the value of the float is truncated so the result is 1, 
meaning the value after the decimal is ignored completely. 
You could change the literal float to 1.999m and the result of casting would be the same.

When you're converting using Convert.ToInt32(), 
the literal float value is properly rounded up to 2. 
If you changed the literal value to 1.499m, it would be rounded down to 1.

*/

// Examine the TryParse() method
/* moja proba :D
string value = "102";
int result = 0;
int.TryParse(value, out result);
Console.WriteLine(result);
*/
// Ważna wskazówka tak zainicjowana zmienna może też być użyta później, przydatne :)
// Miałem na myśli, że nie tylko w tym bloku kodu bo jest globalna ;p
/*
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

// Jeszcze raz ten sam kod tylko zmienimy wartość na tekst
/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
if (result > 0) // wprowadzenie warunku pozwala na uniknięcie wyświetlenia po instrukcji else.
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

/*
// Jeszcze jeden przykładzik żeby pokazać, że inne zmienne też można tak konwertować:

string myInput = "2,71828";
decimal myInputDecimal = 0;
decimal.TryParse(myInput, out myInputDecimal);
Console.WriteLine(myInputDecimal);
*/

// challenge to combine string array values as strings and as integers
/*
string[] values = { "12,3", "45", "ABC", "11", "DEF" };
double number = 0;
double sum = 0;
string message = "";
foreach (string value in values)
{
    if (double.TryParse(value, out number))
    {

        sum += number;
    }
    else
    {
        message += value;
    }
   
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {sum}");


/* ROZWIĄZANIE AUTORA:
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/

// Complete a challenge to output math operations as specific number types

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;



int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}\n");

decimal result2 = value2 / (decimal)value3;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}\n");

float result3 = value3 / value1;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

