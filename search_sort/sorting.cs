class Sorting {
       int[] bubbleSort(int[] input) {
        if(input.Length <= 1) return input;
        else {
            for(int i=0; i<input.Length; i++) {
                for(int j=i+1; j<input.Length; j++) {
                    int compElm = input[j];
                    if (input[i] > input[j]) {
                        int temp;
                        temp = input[j];
                        input[j] = input[i];
                        input[i] = temp;
                    }
                }
            }
            return input;
        }
    }

    int[] selectionSort(int[] input) {
        for (int j=0; j<input.Length; j++) {
            for (int i=0; i<input.Length-j; i++) {
               if (i == input.Length-1) break;
               if (input[i] > input[i+1]) {
                int temp = input[i];
                input[i] = input[i+1];
                input[i+1] = temp;
               } 
            }
        }
        return input;
    }

    int[] mergeSort(int[] input) {
        
        return input;
    }
    
}