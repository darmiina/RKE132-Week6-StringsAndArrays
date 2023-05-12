// Väikse tähe suureks muutmiseks

string hello = "hello, world! ";

int stringLength = hello.Length;

hello = hello.Trim();

char firstLetter = hello[0];

Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], 'H'); // 1. variant

hello = hello.Replace(hello[0], char.ToUpper(hello[0])); // 2.variant

firstLetter = hello[0];

Console.WriteLine(firstLetter);


