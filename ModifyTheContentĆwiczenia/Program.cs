// Write code to find parenthesis pairs embedded in a string

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// SO: 13 i 36 czyli 14 znak to ( i 36 to ) teraz można wyciągnąć interesujący nas tekst

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
// metoda Substring potrzebuje pozycji startowej i liczby znaków lub długości
// do wyciągniecia danych SO: (inside the parentheses

// chcemy jednak usunać ( więc zmieńmy opening position na

// openingPosition += 1;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
/*
string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// zaleca się unikać magic strings i magic numbers w tym wypadku <span> i liczba 6
// lepiej zrobić to w ten sposób
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

// Use the string's IndexOf() and LastIndexOf() helper methods
/*
string message = "hello there!";
int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));



// Retrieve all instances of substrings inside parentheses

string message = "(What if) there are (more than) one (set of parentheses)?";

while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break; //Pętla się przerwie w momencie, gdy już nie napotka
    //żadnego (. Bo index of zwraca -1 gdy nie ma pasującej wartości

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1); // pozwala na przejście do kolejnego nawiasu po wykonaniu pętli
}

// Work with different types of symbol sets with IndexOfAny()
// IndexOfAny pozwala na wyszukiwanie kilku znakow nie tylko pojedycznego, w przypadku nie znalezienia zwraca -1 tak jak indexof

string message = "Hello world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

// SO: Found 'e' in 'Hello, world!' at index: 1.

string message = "Help (find the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] openSymbols = { '[', '{', '(' };

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }


openingPosition += 1;
closingPosition = message.IndexOf(matchingSymbol, openingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
}

// Use the Remove() and Replace() methods

// Remove characters in specific locations from a string

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
// SO: 123455000  3

// Use the Replace() method

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

// SO: This is example data
*/

// Complete a challenge to extract, replace, and remove data from an input string
                    //   12345678901234567890123456789012345    1234567890123                
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
// Quantity moje ale wersja bez const
/*
int openingPosition = input.IndexOf("<span>");
int closingPosition = input.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, length);
quantity = $"Quantity: {quantity}";
*/
// Druga wersja z constem
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
quantity = "Quantity: " + input.Substring(openingPosition, length);

// OBSERWACJA  w sumie można zapisać prościej openingPosition jako:
// int openingPosition = input.IndexOf(openSpan) + openSpan.Length

// Output moje z const
const string trade = "&trade";
const string reg = "&reg";
output = input.Replace(trade, reg);

const string openDiv = "<div>";
int divOpen = output.IndexOf(openDiv);
output = output.Remove(divOpen, openDiv.Length);

const string closeDiv = "</div>";
int divClose = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divClose, closeDiv.Length);


Console.WriteLine(quantity);
Console.WriteLine(output);