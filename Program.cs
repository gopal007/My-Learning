using Sorting;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int []arr = {7,1,5,3,2,4,9,8,88,57};
Console.WriteLine("Initial array : " + String.Join(",", arr));
        
//int []arrr = Sort.SelectionSort(arr, arr.Length);
//Console.WriteLine("Selection Sort : " + String.Join(",", arrr));


int []arrr = Sort.BubbleSort(arr);
Console.WriteLine("Bubble Sort : " + String.Join(",", arrr));
