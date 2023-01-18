class Lists
{
    public static void Main(string[] args)
    {
        // creation
        List<int> mylist1 = new List<int>(3); //with limit set
        List<int> mylist = new List<int>();
        List<int> mylist2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }; // initialization
        List<int> mylist3 = new List<int>(new int[]{11,12,13,14}); // instantiate list with elements from another list

        //methods

        //1. adding elements without worrying about size limitations
        mylist.Add(10);
        mylist.Add(100);
        mylist.AddRange(new int[]{100,2000}); // add a range of elements from another array
        mylist.AddRange(mylist3); // add a range of elements from another collection


        //2. indexing
        Console.Out.WriteLine(mylist[1]);

        //3. inserting
        mylist.Insert(0, 1); // into a specific position
        mylist.InsertRange(3, new int[]{121,232,3443}); //a range of values into a specific position

        //4. iterating with a foreach loop
        foreach (int i in mylist)
        {
            Console.Out.Write(i + " ");
        }

        //5. removing elements
        mylist.Remove(1000);
        mylist.Remove(1); // removes the 1 from list
        mylist.RemoveAt(1); // removes item at location 1

        for (var i = 0; i<20; i++) mylist.Add(i*3);
        mylist.RemoveRange(9, 10); //remove 10 elements from mylist starting at index 9
        
        //6. searching in list
        mylist.Contains(5);

        //7. getting index of element
        mylist.IndexOf(5);
        mylist.LastIndexOf(5);

        //8. comparing lists
        List<int> list1 = new List<int>() {1,2,3,4};
        List<int> list2 = new List<int>() {11,22,33,44};
        List<int> list3 = new List<int>() {1,2,3,4};

        Console.WriteLine($"Is list1 equals to list2: {list1.SequenceEqual(list2)}");
        Console.WriteLine($"Is list1 equals to list3: {list1.SequenceEqual(list3)}");

        //9. length of the list
        list1.Count();

        // index list
        Console.WriteLine($"the element at last index is {list1[list1.Count()-1]}");



        //4. clear elements from list
        mylist.Clear();

    }

}