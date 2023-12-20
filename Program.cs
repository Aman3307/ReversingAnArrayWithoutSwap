using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
        {
            int[] arr = new int[size];


            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element at index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nOriginal Array:");
            DisplayArray(arr);


            ReverseArray(arr);

            Console.WriteLine("\nReversed Array:");
            DisplayArray(arr);

            //SoretdArray(arr);
            //Console.WriteLine("\nSorted Array:");
            //DisplayArray(arr);
            Console.ReadKey();
        }
        
    }

    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        int mid = length / 2;

        
        for (int i = 0; i < mid; i++)
        {
            
            int temp = array[i];
            array[i] = array[length - 1 - i];
            array[length - 1 - i] = temp;
        }
    }


    static void SoretdArray(int[] array)
    {
        int len = array.Length;

        for (int i = 0; i < len - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }

    static void DisplayArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
