using CommentToCodeApp;

class Program
{
    static void Main()
    {
        var util = new StringUtility();

        Console.WriteLine("=== String Utility Tests ===\n");

        // Test ReverseString
        Console.WriteLine($"ReverseString(\"hello\"): {util.ReverseString("hello")}");
        
        // Test ToTitleCase
        Console.WriteLine($"ToTitleCase(\"hello world\"): {util.ToTitleCase("hello world")}");
        
        // Test CountVowels
        Console.WriteLine($"CountVowels(\"hello\"): {util.CountVowels("hello")}");
        
        // Test RemoveDuplicates
        Console.WriteLine($"RemoveDuplicates(\"aabbcc\"): {util.RemoveDuplicates("aabbcc")}");
        
        // Test IsPalindrome
        Console.WriteLine($"IsPalindrome(\"racecar\"): {util.IsPalindrome("racecar")}");
        
        // Test ValidateEmail
        Console.WriteLine($"ValidateEmail(\"test@example.com\"): {util.ValidateEmail("test@example.com")}");
    }
}
