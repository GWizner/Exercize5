// See https://aka.ms/new-console-template for more information
double userIn = 0;
double userBin = 0;

Console.WriteLine("Choose a number:");
string userInput = Console.ReadLine();
double.TryParse(userInput, out userIn);
Console.WriteLine();
Console.WriteLine("Choose one more number:");
string userBinput = Console.ReadLine();
double.TryParse(userBinput, out userBin);
Console.WriteLine();
Console.WriteLine(userIn * userBin);
Console.ReadLine();