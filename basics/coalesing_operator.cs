using System;

using basics;

class CoalesingOperator {
    static string str1 = null;
    static string str2 = null;
    static string str3 = null;
    static string str4 = null;
    static string str5 = "I m not null";

    static string final = str1??str2??str3??str4??str5;

    public static void Main(string[] args)
    {
        Console.WriteLine(CoalesingOperator.final);
    }
}