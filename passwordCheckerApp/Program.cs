using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //password requirements
        int minLength = 9;
        string uppercase = "ABCDEFGHIKLMNOPQRSTVXYZ";
        string lowercase = "abcdefghiklmnopqrstvxyz";
        string digits = "0123456789";
        string specialChars = "!@\"'()*=+,-./";

        //user input
        Console.Write("Enter a password: ");
        string userInput = Console.ReadLine();

        //refactor input length
        int passwordLength = userInput.Length;

        //password strength score
        int score = 0;
        if (passwordLength >= minLength)
        {
            score = score + 1;
            //Console.WriteLine($"Score: {score}");
        }
        if (Contains(userInput, uppercase))
        {
            score = score + 1;
            //Console.WriteLine($"Score: {score}");
        }
        if (Contains(userInput, digits))
        {
            score = score + 1;
            //Console.WriteLine($"Score: {score}");
        }
        if (Contains(userInput, specialChars))
        {
            score = score + 1;
            //Console.WriteLine($"Score: {score}");
        }
        if (userInput == "password")
        {
            score = 0;
            Console.WriteLine("This password is too easy to crack!");
            //Console.WriteLine($"Score: {score}");
        }
        if (userInput == "1234")
        {
            score = 0;
            Console.WriteLine("This password is too easy to crack!");
            //Console.WriteLine($"Score: {score}");
        }
        Console.WriteLine($"Score: {score}");

        //CHANGE TO ACCEPT >4
        //REQUIRE TO REINPUT IF REQUIREMENTS NOT MET
        switch (score)
        {
            case 4:
                Console.WriteLine("This is an extremely strong password");
                break;
            case 3:
                Console.WriteLine("This is a strong password");
                break;
            case 2:
                Console.WriteLine("This is an average password");
                break;
            case 1:
                Console.WriteLine("This is a weak password");
                break;
            default:
                Console.WriteLine("This password doesn't meet the standards");
                break;
        }
        Console.ReadLine();

        if (score < 3)
        {
            Console.WriteLine("Try Again");
            Console.Write("Enter a password: ");

        }
    }
    


    //Tools.cs reference
    public static bool Contains(string target, string list)
    {
        return target.IndexOfAny(list.ToCharArray()) != -1;
    }
    public static void ContainsTest()
    {
        string loudWord = "LASDAD";
        string quietWord = "pssst";
        string mixedWord = "lkaAWEkasfkEW";

        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";

        Console.WriteLine("Running \"tests...\"");
        Console.WriteLine($"Should be true: {Contains(loudWord, uppercase)}");
        Console.WriteLine($"Should be false: {Contains(loudWord, lowercase)}");
        Console.WriteLine($"Should be false: {Contains(quietWord, uppercase)}");
        Console.WriteLine($"Should be true: {Contains(quietWord, lowercase)}");
        Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
        Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");
    }

}
