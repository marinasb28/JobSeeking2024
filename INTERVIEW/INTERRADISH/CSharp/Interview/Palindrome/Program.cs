using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine($"Is palindrome: {isPalindrome}");
    }

    static bool IsPalindrome(string str)
    {
        // Remove non-alphanumeric characters and convert to lowercase
        string cleanedStr = string.Concat(str.Where(c => Char.IsLetterOrDigit(c))).ToLower();

        // Compare characters from start to end
        int left = 0;
        int right = cleanedStr.Length - 1;

        while (left < right)
        {
            if (cleanedStr[left] != cleanedStr[right])
            {
                return false; // Not a palindrome if characters don't match
            }
            left++;
            right--;
        }

        return true; // All characters matched, it's a palindrome
    }
}
