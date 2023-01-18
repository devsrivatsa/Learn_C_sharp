using System;
using System.Collections;
using System.Collections.Generic;
class ArrayLists {
    public static void Main(string[] args) {
        Console.WriteLine("The arraylist class can hold heterogeneous collections of objects. But it does not offer the best performace always");

        //create an arraylist
        ArrayList myAl = new ArrayList();
        var myAl2 = new ArrayList(5); //size is predefined
        var myAl3 = new ArrayList() {1,2,3,4,5,6}; // with initialization
        
        int[] simplearr = new int[]{10,12,20,23,30,44};
        var muAl4 = new ArrayList(simplearr);

        //check the length of the arrayList
        Console.WriteLine($"the arrayList 3 contains {myAl3.Count} elements");
        
        //check if element is present
        myAl3.Contains(6);

        // index arraylist
        Console.WriteLine($"the element at last index is {myAl3[myAl3.Count]}");

        // add elements
        myAl.Add(101);
        myAl.AddRange(myAl3); // add a range of elements from another collection
        myAl.AddRange(simplearr); // add a range of elements from another array

        // insert at specific position
        myAl.Insert(0, 201);
        myAl.SetRange(5, new ArrayList(){1000,200,3000}); // insert from index 5 - the elements from specified array

        // get index of something
        myAl.IndexOf(201); //returns the first index of 201
        myAl.IndexOf(1000, 5,8); //search the array for 1000 frim index 5 till 8 and return the index.

        myAl.LastIndexOf(3000); //returns the last index of 201
        myAl.LastIndexOf(1000, 5); //search the array for 1000 from index 5 onwards till the end.

        // remove elements
        myAl.Remove(10);
        myAl.RemoveAt(myAl3.Count-1); // remove element at the specified index
        myAl.RemoveRange(0,3); // removes 3 items from 0th index

        //reverse the arraylist
        myAl3.Reverse();
        myAl3.Reverse(3,5); // reverse values only from index 3 till 5

        //sorts the arraylist
        myAl.Sort();

        // copies elements to a simple array
        myAl.ToArray();

    }
}