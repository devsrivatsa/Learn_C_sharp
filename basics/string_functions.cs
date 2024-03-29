using System;

public class StringFunctions
{
    public static void Main(string[] args)
    {
        //string is of the reference types category
        // reference types are stored in a heap compared to the value types which are stored in the stack
        // strings are immutable. Anytime it is changed, a new string gets created and the original string gets destroyed
        string name = "srivatsa";
        char[] arr = {'h', 'e', 'l', 'l', 'o'};
        string hello = new string(arr);
        Console.WriteLine(hello + ' ' + name);
        Console.WriteLine($"{hello} {name}, This is an awesome feature!");
    
        // string properties
        
        //1. length of a string
        Console.WriteLine($"The length of the name is {name.Length}");
        
        //2. comparing string Console.WriteLine();
        Console.WriteLine(name.CompareTo("srivatsa"));
        Console.WriteLine(name.CompareTo("rrivatsa"));
        Console.WriteLine(name.CompareTo("trivatsa"));
        
        Console.WriteLine(name == "srivatsa \n");
        
        //3. index
        Console.WriteLine($"the first index of s is {name.IndexOf("s")}; the last index of s is {name.LastIndexOf("s")} \n");
        Console.WriteLine($"the first index of s beginning search from 2nd index is {name.IndexOf("s", 2)}");
        
        //4. removing characters starting from 2nd index
        Console.WriteLine($"removing 3 characters starting at index 0 -> {name.Remove(0,3)}");
        
        //5. uppercase and lowercase
        string capsname = "SRIVATSA";
        Console.WriteLine($"{name.ToUpper()}; SRIVATSA to lower: {capsname.ToLower()}");
        
        //6. string split
        string someOtherString = "My name is Rick";
        string[] words = someOtherString.Split(' ');
        for (int i=0; i<4; i++) {
            Console.WriteLine(words[i]);
        }
        
        //7. verbatim string literals (similar to an r-string in python)
        string buy = @"\t this \t will not \t escape the tab character";
        Console.WriteLine(buy);
        
        //8. String To Array
        string a = "convert";
        char[] chararray = a.ToCharArray(); //returns a character array
        
        //9. Reverse a string
        Array.Reverse(chararray); //modifies in place
        
    }
}