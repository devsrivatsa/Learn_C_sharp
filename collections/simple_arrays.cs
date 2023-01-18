using System;

class SimpleArrays {
    public static void Main(string[] args) {

        // create an array
        int[] arr1 = new int[5];
        int[] arr2 = new int[] {1,2,3,4,5};
        int[] arr3 = {11,12,13,14};

        //number of items in an array
        
        Console.WriteLine($"The Length of the array is: {arr1.Length}");
        //find if this is single or multi dimensional array
        Console.WriteLine($"The Rank of the array is: {arr1.Rank}");
        //sort the array
        Array.Sort(arr2);

        //copy elements from 1 array to another starting from the specified index.
        arr2.CopyTo(arr1,0);
        //reverse the array
        Array.Reverse(arr2);

    }
}