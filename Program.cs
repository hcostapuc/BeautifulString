// See https://aka.ms/new-console-template for more information
using BeautifulString;

Console.WriteLine("_________________________");
Console.WriteLine("Beatiful string challange");
Console.WriteLine("_________________________");

var firstTest = "aaabbbbccdddd";
var secondTest = "aabbbcccdddd";

Console.WriteLine($"aaabbbbccdddd It's beautiful? {firstTest.IsBeautifulString()}");
Console.WriteLine($"aabbbcccdddd It's beautiful? {secondTest.IsBeautifulString()}");
Console.ReadKey();