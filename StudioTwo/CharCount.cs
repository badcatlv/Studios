namespace StudioTwo
{
    public class CharCount
    {
        public Dictionary<char, double> CharCountDictionary(char[] charArray)
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
    }
}
