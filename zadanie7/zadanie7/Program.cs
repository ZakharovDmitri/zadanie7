using System;
using System.Collections;
using System.Collections.Generic;

namespace zadanie7
{
    class Program
    {
        public static void ShowAllCombinations<T>(IList<T> arr, string current = "")
        {
            if (arr.Count == 0) //если все элементы использованы, выводим на консоль получившуюся строку и возвращаемся
            {
                Console.WriteLine(current);
                return;
            }
            for (int i = 0; i < arr.Count; i++) //в цикле для каждого элемента прибавляем его к итоговой строке, создаем новый список из оставшихся элементов, и вызываем эту же функцию рекурсивно с новыми параметрами.
            {
                List<T> lst = new List<T>(arr);
                lst.RemoveAt(i);
                ShowAllCombinations(lst, current + arr[i].ToString());
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            string str = " - ";
            ShowAllCombinations(arr,str);
            Console.Read();
        }
        
    }
}
