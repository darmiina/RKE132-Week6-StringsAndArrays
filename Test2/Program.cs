
string[] colors = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();
string randomColor = colors[rnd.Next(0, colors.Length)];

for (int i = 0; i < colors.Length; i++)
{
    colors[i] = colors[i].ToUpper();
}

Console.WriteLine($"You should wear {randomColor} today.");
