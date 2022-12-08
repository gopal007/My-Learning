using System;

namespace Sorting {

    public static class Sort
    {
        public static int[] SelectionSort(int [] arr, int n){
            for(int i=0; i<n;i++){
                int indexmin = i;
                for(int j=i+1; j<n; j++){
                    if(arr[j] < arr[indexmin]){
                        indexmin = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[indexmin];
                arr[indexmin] = temp;
                //Console.WriteLine(String.Join(",", arr));
            }
            
            return arr;
        }
    }

}