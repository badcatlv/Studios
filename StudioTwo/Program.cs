using StudioTwo;

string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
loremIpsum = loremIpsum.ToLower();
char[] loremIpsumChar = loremIpsum.ToCharArray();


FrequencyCount(loremIpsumChar);
static void FrequencyCount(char[] charArray)
{
    CharCount charCount = new CharCount();
    Dictionary<char, double> frequenyCount = charCount.CharCountDictionary(charArray);

    foreach (KeyValuePair<char, double> count in frequenyCount)
    {
        Console.WriteLine(count.Key + ": " + count.Value);
    }
}

List<char> charList = new List<char>();
charList.AddRange(loremIpsum);

char[] distinctValues = charList.Distinct().ToArray();

for (int i = 0; i < distinctValues.Length; i++)
{
    var cnt = charList.Count(e => e == distinctValues[i]);
    Console.WriteLine($"{distinctValues[i]}: {cnt}");
}