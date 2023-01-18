using System.Collections.Generic;
using System;

class Dictionaries {
    static void Main(string[] args) {
        Dictionary<string, int> reportCard = new Dictionary<string, int>();
        
        // adding key value pairs
        reportCard.Add("Physics", 95);
        reportCard.Add("Maths", 100);
        reportCard.Add("Chemistry", 89);

        //indexing or referencing a key to get value
        Console.WriteLine($"I got {reportCard["Chemistry"]} out of 100 in Chemistry.");
        
        //changing value of a key
        reportCard["Maths"] = 99;

        //adding new key value pair - preferred method
        reportCard["Chemistry"] = 99;

        //checks if the specified key is present
        reportCard.ContainsKey("bloor-Yonge");
        //checks if the specific value is present
        reportCard.ContainsValue(442);

        //tries to get value if specified key is available or returns the specified value
        int dummyScore = 0;
        reportCard.TryGetValue("Sanskrit", out dummyScore);

        //try adding a key. Does not override existing value or raise an exception if key already exist. Just returns false or trur
        reportCard.TryAdd("Sanskrit", 100);
        reportCard.TryAdd("Physics", 100); // now physics will not be added as it already exists. Neither will an exception be raised

        //check if key exists
        Console.WriteLine($"dictionary contains maths ? => {reportCard.ContainsKey("Maths")}");

        //check if value exists
        Console.WriteLine($"Did student achieve any perfect scores ? => {reportCard.ContainsValue(100)}");

        //get key value pairs for iterations
        foreach(KeyValuePair<string, int> item in reportCard) {
            Console.WriteLine($"{item.Key} --> {item.Value}");
        }

        //iterating only the keys
        foreach(var k in reportCard.Keys) {
            Console.WriteLine(k);
        }
        //iterating only the values
        foreach(var v in reportCard.Values) {
            Console.WriteLine(v);
        }

        //remove the value of the specified key
        reportCard.Remove("Physics");

        //count items in dictionary
        reportCard.Count();

        //clear elements from dictionary
        reportCard.Clear();
    }
}