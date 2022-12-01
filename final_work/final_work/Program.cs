// Программа из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа. 
using System;

namespace final_work
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
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





    }
}
