namespace _03_ExtensionMethods;

public static class StringExtensions
{
    public static string ToCapitalize(this string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            throw new Exception("Word is empty!");
        }

        return char.ToUpper(word[0]) + word.Substring(1);
    }



    public static int CountWords(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        //string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //int count = 0;
        //foreach (string word in words)
        //{
        //    count++;

        //}
        //return count;

        int count = 0;
        bool inWord = false;
        for(int i = 0; i < text.Length; i++)
        {
            if (!char.IsWhiteSpace(text[i]) && !inWord)
            {
                count++;
                inWord = true;
            }
            else if (char.IsWhiteSpace(text[i]))
            {
                inWord = false;
            }
        }
        return count;

    }
}