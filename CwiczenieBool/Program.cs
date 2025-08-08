
//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


/*Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/

/*Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/

//string pangram = "The quick brown fox jumps over the lazy dog.";

/*
//Przedstawienie negacji na dwa sposoby oba daja output false.
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
*/
/*
int a = 7;
int b = 6;
Console.WriteLine(a != b); // Output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // Output: False
*/

/* Nowo poznane funkcje
.Trim() - usuwa białe znaki z początku i końca stringa
.ToLower() - zamienia wszystkie znaki w stringu na małe litery
.ToUpper() - zamienia wszystkie znaki w stringu na wielkie litery
.Contains() - sprawdza czy string zawiera inny string

*/

/*
The conditional operator ?: evaluates a Boolean expression and returns one of two results 
depending on whether the Boolean expression evaluates to true or false.
The conditional operator is commonly referred to as the ternary conditional operator.

Here's the basic form:

c#

Copy
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
Take a minute to consider how you'd apply the conditional operator to the promotional discount scenario. 
Your goal is to display a message to the customer that shows their discount percentage. 
The amount of their discount will be based on whether they've spent more than 1000 euros on their purchase.
*/
/*
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
*/

//JESZCZE PROSTRZA WERSJA BEZ DEKLAROWANIA DISCOUNT

int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
