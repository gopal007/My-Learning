using System;

namespace Sorting {

    public static class Sort
    {
        public static int[] SelectionSort(int [] arr, int n){
            Console.WriteLine("Selection Sort -- > Time complexity is n square");
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

        public static int[] BubbleSort(int [] arr){
            Console.WriteLine("Bubble Sort -- > Time complexity is n square");

            for(int i=0; i<arr.Length; i++){
                for(int j = 0; j < arr.Length-i-1; j++){
                    if(arr[j+1] < arr[j]){
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
                //Console.WriteLine(i+1 + " : " + String.Join(",", arr));
            }
            return arr;
        }
    }

}