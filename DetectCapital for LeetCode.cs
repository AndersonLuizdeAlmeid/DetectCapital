public class Solution
{
    public bool DetectCapital(string word)
    {
        if (word.All(char.IsUpper))
            return true;

        if (word.All(char.IsLower))
            return true;

        if (char.IsUpper(word[0]) && word.Skip(1).All(char.IsLower))
            return true;

        return false;
    }
}