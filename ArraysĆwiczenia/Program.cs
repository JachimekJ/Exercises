// Tworzenie tablicy, sortowanie
/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("Sorted...");
Array.Sort(pallets); // Sortuje tablice alfanumerycznie
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
// SO: A11, A13, B12, B14



// Odwracanie kolejności tablicy - Reverse
/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("Sorted...");
Array.Sort(pallets); // Sortuje tablice alfanumerycznie
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");

Array.Reverse(pallets); // Odwrócenie indeksów
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// SO: B14, B12, A13, A11
*/

// Czyszczenie danych z tablicy Array.Clear
// Ta funkcja usuwa wartości z określonego zakresu elementów tablicy
// i ustawia ich wartość na domyślną np. String --> null, int --> 0, bool --> false
/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Pierwsze dwa elementy są NULL SO: --  , --  , B12, A13
WAŻNE: 
Po Array.Clear() element nie jest pustym stringiem – jest null.
Konsola może wyświetlać pusty ciąg, 
bo C# automatycznie konwertuje null na "" w Console.WriteLine().


string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
/*
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Wywołanie metody na null spowoduje NullReferenceException:
pallets[0].ToLower(); // Błąd, jeśli element jest null

*/

// Zmiana rozmiaru tablicy Array.Resize(); Dodanie elementów
/*
string[] pallets =  ["B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6); //zmiana rozmiaru tablicy, ref - przekazanie przez referencję, wymagane!!
When in doubt, you're recommended to look at Intellisense or Microsoft Docs for examples on how to properly call a given method.

Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// SO: --  ,--  ,--B..,--A..,--C..,C..
*/

// Usuwanie elementów
/*
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

SO:
Clearing 2 ... count: 4
--
--
-- B12
-- A13

Resizing 6 ... count: 6
--
--
-- B12
-- A13
-- C01
-- C02

Resizing 3 ... count: 3
--
--
-- B12

Zauważmy, że array resize nie eliminuje null elementów, usuwa 3 ostatnie elementy nawet jak nie byly null
Jak zatem usunąć null elementy?
Usuwanie elementów null

Array.Resize() nie usuwa pustych/null elementów w środku tablicy.

Aby pozbyć się null:

Zliczyć elementy ≠ null.

Stworzyć nową tablicę o tej długości.

Skopiować tylko elementy ≠ null.
*/

/*
// ToCharArray() tworzy tablice, gdzie kazdy element tablicy to pojedynczy znak z stringa

string value = "abc123";
char[] valueArray = value.ToCharArray(); // string --> tablica znaków
Array.Reverse(valueArray);
string result = new string(valueArray); // tablica znaków --> string
Console.WriteLine(result);

// SO: 321cba
*/

/*
// Join() dodanie przecinka do kazdego elemntu

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);
// SO: 3,2,1,c,b,a

// Split() rozdzieli każdy element stringa do przecinka na pojedynczy
// Pętla foreach wyświetli każdy ten pojedynczy element

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

// SO:
/*
3,2,1,c,b,a
3
2
1
c
b
a
*/

// Challenge to reverse words in a sentence:
/*
string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' ');
string[] newWords = new string[words.Length];
for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    newWords[i] = new string(letters);
}

string finalResult = String.Join(" ", newWords);
Console.WriteLine(finalResult);
*/

// Challenge to parse a string of orders, sort the orders and tag possible errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);
foreach (string order in orders)
{
    if (order.Length == 4)
    {
        Console.WriteLine(order);
    }
    else
    {
        Console.WriteLine($"{order}     --Error");
    }
}
