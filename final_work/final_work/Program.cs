// Программа из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа. 
using System;

namespace final_work
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] array = CreateArray();
            ShowArray(array);

            string[] shortArray = ShortStrings(array);
            ShowArray(shortArray);

            Console.ReadKey();
        }

        static string[] CreateArray()
        {
            string[] arr = new string[] { "integer", ":-)!!!", "Try", "IF" };
            return arr;

        }

        static string[] ShortStrings(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > 3)
                {
                    arr[i] = arr[i].Remove(3);
                }

            }

            return arr;
        }

        static void ShowArray(string[] arr)
        {
            Console.WriteLine(String.Empty);
            for (int i = 0; ; i++)
            {
                if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
                else if (i == arr.Length - 1)
                {
                    Console.Write(arr[i] + ".");
                    Console.WriteLine(String.Empty);
                    return;
                }
            }
        }




    }
}
