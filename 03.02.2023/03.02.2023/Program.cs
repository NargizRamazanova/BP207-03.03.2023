//char letter = 'a';

//int charValue = (int)'A';

//Console.WriteLine(charValue);

using System.Text.RegularExpressions;

while (true)
{
Console.WriteLine("Enter your email: ");
string mail = Console.ReadLine();

var regex = new Regex(@"^\w{3,15}@code.edu.az$");

if (regex.IsMatch(mail))
{
    Console.WriteLine("User loged in successfully!");
}
else
{
    Console.WriteLine("Emelli mail yaz");
}

}
