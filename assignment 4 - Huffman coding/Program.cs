var allCharacters = new Dictionary<char, int>();
foreach (var line in File.ReadAllLines(
             "D:\\C#Projects\\assignment 4 - Huffman coding\\assignment 4 - Huffman coding\\THE ADVENTURE OF THE DANCING MEN.txt"))
{
    foreach (var character in line)
    {
        if (!allCharacters.ContainsKey(character))
        {
            allCharacters[character] = 0;
        }

        allCharacters[character]++;
    }
}

foreach (var character in allCharacters)
{
    Console.WriteLine($"Character {character.Key} has {character.Value} implementations.");
}