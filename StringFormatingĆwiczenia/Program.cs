/*
// Formatowanie złożone - composite formating

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);


// Interpolacja stringów - string interpolation

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");


// Formatowanie wartości

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// :C - format waluty, reprezentuje price i discount jako walutę.
// output 123.45Zł, 50Zł w zależności od ustawionej kultury

// Formatowanie wartości
// Może uczynić np liczbę lepiej widoczną --> :N
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
// :N domyślnie wyświetli 2 liczby po przecinku można to zmienić dodając numer do :N np :N4
Console.WriteLine($"Measurement: {measurement:N4} units");

// Formatowanie procentów
// :P --> Wyświetli liczbę w procentach, zaokrąglony do 2 miejsc po przecinku

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");



// Łączenie metod formatowania

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);
decimal priceDwa = price - salePrice;
Console.WriteLine($"You saved {priceDwa:C2} off the regular {price:C2} price.");

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; // obliczenie procentowej wartosci discount
Console.WriteLine(yourDiscount);

// Exercise display values using interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"  Shares: {productShares:N3} Product");
Console.WriteLine($"   Sub Total: {subtotal:C}");
Console.WriteLine($"         Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");


// Exercise Discover padding and alignment

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
*/

// Formatting strings by adding whitespace before or after


// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// Doda 12 znaków odstępu po lewej stronie stringa
// Analogicznie można użyć Pad.Right(x) ofc po prawej

// second overloaded version
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));
// SO:
// ----Pad this
// Pad this----

// Exercise, working with padded strings
/*
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/

// Complete a challenge to apply string interpolation to a form letter

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");
string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(15);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format($"{newReturn:P}").PadRight(10);
comparisonMessage += String.Format($"{newProfit:C}").PadRight(15);
Console.WriteLine(comparisonMessage);

/*
Console.WriteLine($"{currentProduct.PadRight(20)}{currentReturn:P}   {currentProfit:C}");
Console.WriteLine($"{newProduct.PadRight(20)}{newReturn:P}   {newProfit:C}");
string comparisonMessage = "123456789012345678901234567890123456789012345";
Console.WriteLine(comparisonMessage);

// 123456789012345678901234567890123456789012345
// Magic Yield         12.75%   $55,000,000.00
*/

// Oba rozwiązania poprawne, chciałem spróbować kilka sposobów, najlepszy
// imo to string.format + interpolacja pozdro
