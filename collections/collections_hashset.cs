using System;
using System.Collections.Generic;

class HashSets {
    public static void Main(String[] args) {
        Console.WriteLine("Hashset is an implementation of a mathematical set");
        //creating a hashset - this is a representation of a mathematical set.
        HashSet<int> set_1 = new HashSet<int>() {1,2,3,4,5,6,7};
        var set_2 = new HashSet<int>(5); // size specified and uninitialized
        var set_3 = new HashSet<int>(); // size unspecified and uninitialized

        //adding elements into a hashset
        set_3.Add(12);
        set_3.Add(11);
        set_3.Add(3);
        
        for (int i=4; i<10; i++) set_2.Add(i); //if the number of elements added exceeds the limit, automatically the memory allocated is extended
        
        //check if a specific element is present in the hashset
        Console.WriteLine($"does set 1 contain element 5 ? --> {set_1.Contains(1)}");

        //remove specified element from the hashset
        set_3.Remove(12);

        //count of elements in a set
        set_3.Count();
        
        //intersection - modifies the calling set inplace
        var set_a = new HashSet<int>(5) {1,2,3,4,5};
        var set_b = new HashSet<int>() {3,4,5,6,7,8};
        set_a.IntersectWith(set_b);
        Console.WriteLine($"set a intersection with set b is {set_a.ToString()}");

        // is subset of another set
        set_a.IsSubsetOf(set_3);
        set_a.IsProperSubsetOf(set_3);

        // is superset of another set
        set_3.IsSupersetOf(set_a);
        set_3.IsProperSupersetOf(set_a);

        //create a disjoint set - only uncommon elements from both set (modifies calling set in place)
        set_b.SymmetricExceptWith(set_a);

        //union
        var myset = new HashSet<int>();
        myset.UnionWith(set_1);

        //check if 2 sets contain the same elements
        myset.SetEquals(set_1);

        //clear all elements from set
        myset.Clear();

        //copy all elements of the set into a new array
        set_3.CopyTo(new int[15]); 

    }
}

internal class Array<T>
{
    public Array()
    {
    }
}