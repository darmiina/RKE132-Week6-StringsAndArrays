// Kasutades char.ToUpper() meetodit, täienda koodi nii, et tervitus "Hello!" kuvaks konsoolis suurtähega:

using System.Collections.Generic;

string hello = "hello!";
hello = hello.Replace(hello[0], char.ToUpper(hello[0]));
Console.WriteLine(hello);

// Programm loeb tühikuid antud lauses ja kuvab lauses olevate sõnade arvu konsoolis.
string hellou = "Hello, world!".Trim();
int spaceCounter = 0;

for (int i = 0; i < hellou.Length; i++)
{
    if (char.IsWhiteSpace(hellou[i]))
    {
        spaceCounter++;
    }
}

Console.WriteLine(spaceCounter +1);

// Täienda koodi nii, et kuvada massiivi elemente tagurpidi:
string[] colours = { "red", "green", "blue", "pink", "yellow" };
for (int i = colours.Length -1; i >= 0; i--)
    {
    Console.WriteLine (colours[i]) ;
}

// Täienda koodi nii, et kuvada massiivi elemente tagurpidi nummerdatud loeteluna.
string[] colors = { "red", "green", "blue", "pink", "yellow" };
for (int i = colors.Length -1; i >= 0; i--)
{ 
    Console.WriteLine($"{colors.Length - i}. {colors[i]}");
}