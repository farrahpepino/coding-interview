class Program{
    static void Main(string[] args){
        Palindrome p1 = new Palindrome("Farrah");
        Palindrome p2 = new Palindrome("racecar");

        string res1 = p1.CheckPalindrome();
        string res2 = p2.CheckPalindrome();

        Console.WriteLine("Farrah " + res1);
        Console.WriteLine("racecar " + res2);
    }
}

class Palindrome
{
    private string word;

    public Palindrome(string word)
    {
        this.word = word;
    }

    public string CheckPalindrome()
    {
        bool isPalindrome = true;

        for (int i = 0, j = word.Length - 1; i < j; i++, j--)
        {
            if (word[i] != word[j])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
            return "Palindrome";
        else
            return "Not Palindrome";
    }
}
