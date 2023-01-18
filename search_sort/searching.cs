class Searching {
    void linearSearch(int searchTerm, int[] array_input) {
        for(int i=0; i<array_input.Length; i++) {
            if(array_input[i] == searchTerm) {
                Console.Out.WriteLine($"Item found at index: {i}");
                break;
            }
        }
        Console.Out.WriteLine("Term not found"); 
    }

    string BinarySearch(int searchTerm, int[] array_input) {
        Array.Sort(array_input);
        int mid = array_input.Length/2;
        if(mid >= array_input.Length) {
            return "not present..";
        }
        if(searchTerm == array_input[mid]) {
            return "The element is present";
        }
        else if(searchTerm < array_input[mid]) {
            return BinarySearch(searchTerm, array_input[0..mid]);
        }
        else {
            return BinarySearch(searchTerm, array_input[(mid+1)..]);
        }
    }
}