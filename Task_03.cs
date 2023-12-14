

class Program {
 
 static void Main()
    {
        
        int[] array = { 1, 2, 3, 4, 5 };

        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] arr, int i)
    {
        if (i >= 0)
        {
            Console.WriteLine(arr[i]);
            PrintArrayReverse(arr, i - 1);
        }
    }
}