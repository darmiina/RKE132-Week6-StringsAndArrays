// string[] fruit = { "apples", "bananas", "oranges" };

string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

// Näitab, mis on massiivi pikkus ehk mitu tükki on 
int fruitArrayLength = fruit.Length;
Console.WriteLine($"There are {fruitArrayLength} in your array.");

// Kuvab massiivi muutujad vol 1
for (int i = 0;  i < fruitArrayLength; i++)
{
    Console.WriteLine(fruit[i]);
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0])); // Muudab esimesed tähed suureks
}

// Kuvab masiivi muutujad vol 2
foreach(string element in fruit)
{
    Console.WriteLine(element);
}