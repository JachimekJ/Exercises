string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
   string firstName = corporate[i, 0];
   string lastName = corporate[i, 1];
    DisplayEmail(firstName, lastName);
    
}

for (int i = 0; i < external.GetLength(0); i++)
{
    string firstName = external[i, 0];
    string lastName = external[i, 1];
    DisplayEmail(firstName, lastName, externalDomain);
}

// z Robert Bavin muszę zrobić robavin@contoso.com
void DisplayEmail(string firstName, string lastName, string domain = "@contoso.com")
{
    string userName = firstName.Substring(0, 2) + lastName; // Wyciągam sobie dwie litery imienia i nazwisko z tablicy
    string email = userName.ToLower() + domain; // połączone 2 litery + nazwisko zmieniam na małe litery i dodaje stałą domenę pracowników
    Console.WriteLine(email); // wyświetlam adres
}


// Tu dla porównania kod z rozwiązania:

/*
string[,] corporate = 
	{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

	string[,] external = 
	{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	};

	string externalDomain = "hayworth.com";

	for (int i = 0; i < corporate.GetLength(0); i++) 
	{
		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
	}

	for (int i = 0; i < external.GetLength(0); i++) 
	{
		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
	}

	void DisplayEmail(string first, string last, string domain = "contoso.com") 
	{
		string email = first.Substring(0, 2) + last;
		email = email.ToLower();
		Console.WriteLine($"{email}@{domain}");
	}
    */