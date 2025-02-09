public class Solution
{
    // Solution to detect capital letters in a string
    public static void Main()
    {
        DetectCapitalUse();
    }

    static void DetectCapitalUse()
    {
        Console.WriteLine("Type 'cancel' to exit!");
        while (true)
        {
            Console.Write("Enter a word :");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error - Input is null or empty");
                continue;
            }

            if (input.ToLower() == "cancel")
                break;

            Console.WriteLine($"{input} -> {DetectStringCase(input)}");
        }
    }

    static string DetectStringCase(string input)
    {
        if (input.All(char.IsUpper))
            return "True - All characters are uppercase";

        if (input.All(char.IsLower))
            return "True - All characters are lowercase";

        if (char.IsUpper(input[0]) && input.Skip(1).All(char.IsLower))
            return "True - First character is uppercase and the rest are lowercase";

        return "False - The input does not match any pattern";
    }
}