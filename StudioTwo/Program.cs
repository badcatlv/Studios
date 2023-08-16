string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
char[] loremIpsumChar = loremIpsum.ToCharArray();

//for (int i = 0; i < loremIpsumChar.Length; i++)
//{
//    Console.WriteLine(loremIpsumChar[i]);
//}

FrequencyCount(loremIpsumChar);
static void FrequencyCount(char[] charArray)
{
    Dictionary<char, double> frequenyCount = CharCountDictionary(charArray);

    foreach (KeyValuePair<char, double> count in frequenyCount)
    {
        Console.WriteLine(count.Key + ": " + count.Value);
    }
}
static Dictionary<char, double> CharCountDictionary(char[] charArray)
{
    Dictionary<char, double> charCount = new Dictionary<char, double>();

    foreach (char item in charArray)
    {
        if (!(charCount.ContainsKey(item)))
        {
            charCount.Add(item, 1);
        }
        else
        {
            charCount[item]++;
        }
    }
    return charCount;
} 
