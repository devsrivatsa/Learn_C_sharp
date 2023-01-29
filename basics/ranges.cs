using System;
namespace basics;

class Ranges {
    public static void Main(string[] args) {
        
        var mylist = new List<int>();
        var arr = new int[100];
        for (int i=0; i<100; i++) {
            arr[i] = i*2;
            mylist.Add(i*2);
        }
        
        Range myrange = 1..10;
        Range myreverserange = 20..10;

        //can be used to loop an array 
        foreach(int i in arr[1..10]) Console.Write($"{i} ");
        //cannot be used inside a collection
    }
}