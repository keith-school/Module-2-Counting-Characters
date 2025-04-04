Console.WriteLine("Enter a word:");
string? inputWord = Console.ReadLine();
inputWord = inputWord ?? string.Empty;
Dictionary<char, int> letters = new Dictionary<char, int>();

for (int i = 0; i < inputWord.Length; i++)
{
    char upperChar = char.ToUpper(inputWord[i]);
    if (char.IsLetter(upperChar))
    {
        if (letters.ContainsKey(upperChar))
            letters[upperChar]++;
        else
            letters[upperChar] = 1;
    }
}

Console.WriteLine("Character counts:");
foreach (var i in letters.Keys.OrderBy(a => a))
    Console.WriteLine(i + ": " + letters[i]);
