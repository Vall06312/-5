using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "hello";
        string str3 = "Hello";
        string str4 = "World";
        string text = "C# is a powerful programming language";

        // Compare()
        Console.WriteLine("Compare():");
        Console.WriteLine(string.Compare(str1, str2));
        Console.WriteLine(string.Compare(str1, str3));
        Console.WriteLine(string.Compare(str1, str4));
        Console.WriteLine();

        // CompareOrdinal()
        Console.WriteLine("CompareOrdinal():");
        Console.WriteLine(string.CompareOrdinal(str1, str2));
        Console.WriteLine(string.CompareOrdinal(str1, str3));
        Console.WriteLine(string.CompareOrdinal("a", "A"));
        Console.WriteLine();

        // Equals()
        Console.WriteLine("Equals():");
        Console.WriteLine(str1.Equals(str2));
        Console.WriteLine(str1.Equals(str3));
        Console.WriteLine(string.Equals(str1, str2));
        Console.WriteLine();

        // == и !=
        Console.WriteLine("== и !=:");
        Console.WriteLine(str1 == str2);
        Console.WriteLine(str1 == str3);
        Console.WriteLine(str1 != str2);
        Console.WriteLine(str1 != str3);
        Console.WriteLine();

        // IndexOf()
        Console.WriteLine("IndexOf():");
        Console.WriteLine(text.IndexOf("powerful"));
        Console.WriteLine(text.IndexOf('i'));
        Console.WriteLine(text.IndexOf("java"));
        Console.WriteLine(text.IndexOf("programming"));
        Console.WriteLine();

        // Contains()
        Console.WriteLine("Contains():");
        Console.WriteLine(text.Contains("powerful"));
        Console.WriteLine(text.Contains("C#"));
        Console.WriteLine(text.Contains("java"));
        Console.WriteLine(text.Contains("language"));
    }
}