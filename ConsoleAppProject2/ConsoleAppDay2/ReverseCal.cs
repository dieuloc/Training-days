using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay2
{
    class ReverseCal
    {
        public  void ReverseCalc()
        {

            int[] numbers = GenerateNumbers();

            Reverse(numbers);

            PrintNumbers(numbers);
        }

        public int[] GenerateNumbers(params int[] nums)
        {
            Console.WriteLine("Enter your array = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(s[i]);
            }
            return arr;
        }
        public static int[] Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
            return array;
        }
        public static void PrintNumbers(int[] array)
        {
            Console.WriteLine(String.Join(',', array));
        }
    }
}
