class AllAboutSimpleArrays {
// multi dimensional array -  all arrays within the main array should be of same size. ex. all matrices and tensors
    int[,] arr2D = new int[3,3];
    int[,,] arr3D = new int[2,3,4]; // this is for array of shape (x,y,z)
    int[,] arr2D_2 = {
        {1,2,3},
        {4,5,6},
        {7,8,9}
    };
    int[,] arr2D_3 = {
        {1,0,0},
        {0,1,0},
        {0,0,1}
    };

    void iterateMultiDimArr(int[,] arr) {
        for (int row=0; row<arr.GetLength(0); row++) {
            for (int col=0; col<arr.GetLength(1); col++) {
                Console.Out.WriteLine(arr[row, col]);
            }
        }
    }


//jagged arrays: the arrays inside the parent arrays can all be different
    int[][] jarr1 = new int[3][]; //notice that the second element is left blank 
    int[][][] jarr2 = new int[2][][]; // only the outer array must have a size

    
    void iterateJaggedArr(int[][] arr) {
        for (int row=0; row<arr[0].Length; row++) {
            for (int col=0; col<arr[1].Length; col++) {
                Console.Out.WriteLine(arr[row][col]);
            }
        }
    }
}