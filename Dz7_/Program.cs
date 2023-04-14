using System;
namespace Dz7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.Write("Enter task (1 - 3): ");
                ch = int.Parse(Console.ReadLine());
                switch (ch) 
                {
                    case 1:
                        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        Array myArray = new Array(arr);
                        Console.Write("\nEnter sort number for less element array: ");
                        int less = int.Parse(Console.ReadLine());
                        Console.Write("Enter sort number for greater element array: ");
                        int greater = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Number of values less than {less}: " + myArray.Less(less));
                        Console.WriteLine($"Number of values greater than {greater}: " + myArray.Greater(greater));
                        break;
                    case 2:
                        int[] arr_ = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        Task2.Array_ array_ = new Task2.Array_(arr_);
                        array_.ShowEven();
                        array_.ShowOdd();
                        break;
                    case 3:
                        int[] data = { 1, 2, 3, 4, 5, 1, 2, 3 };
                        Task3._Array _array = new Task3._Array(data);
                        Console.Write("\nEnter number for equal element array: ");
                        int equal = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Number of distinct values: {_array.CountDistinct()}");
                        Console.WriteLine($"Number of values equal to {equal}: {_array.EqualToValue(equal)}");
                        break;
                    default: 
                        Console.WriteLine("Error! Try again!"); 
                        break;
                }
            } while (ch < 1 || ch > 3); 
        }
    }
}