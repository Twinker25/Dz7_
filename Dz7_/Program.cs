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
                        Console.Write("Enter sort number for less element array: ");
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

                        break;
                    default: 
                        Console.WriteLine("Error! Try again!"); 
                        break;
                }
            } while (ch < 1 || ch > 3); 
        }
    }
}