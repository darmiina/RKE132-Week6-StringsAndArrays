// Sümbolite lugemine:

string hello = "hello, world! ";

int stringLength = hello.Length;

// string trimmedString = hello.Trim(); - võtab rohkem vahemälu

hello = hello.Trim();

int wordCounter = 1;

for(int i = 0; i < hello.Length; i++)
{
    Console.WriteLine($"{i} symbol in string: {hello[i]}");
}

Console.WriteLine(hello.Length);

// Sõnade lugemine lauses:

for (int i = 0; i < hello.Length; i++)
{
    if (hello[i] == ' ')
    {
        wordCounter++;
    }
}

Console.WriteLine($"Word count in {hello}: {wordCounter} words.");

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        wordCounter++;
    }
}

Console.WriteLine($"Word count in {hello}: {wordCounter} words.");

int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int stringLength = numbers.Length;

numbers = numbers.Trim();


for (int i = 0; i < hello.Length; i++)
{
    Console.WriteLine($"{i} symbol in string: {numbers[i]}");
}

Console.WriteLine(numbers.Length);
