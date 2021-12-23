
using System;

namespace pop
{
    class Program
    {
        //Завдання 1.4
        private static int[] Reverse(int[] arr)
        {
            int[] reversed = new int[arr.Length];

            for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversed[j] = arr[i];
            }
            return reversed;
        }
        // Завдання 1.5
        private static void Reverse(ref int[] arr)
        {
            int[] reversed = new int[arr.Length];

            for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversed[j] = arr[i];
            }

            arr = reversed;
        }
        private static void Reverse(int[] arr, out int[] reversed)
        {
            reversed = new int[arr.Length];

            for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversed[j] = arr[i];
            }
        }

        static void Main(string[] args)
        {
            //Завдання1 1.  Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)


             /* int digit;
             int reversed = 0;
             Console.Write("Enter digit: ");
             digit = Convert.ToInt32(Console.ReadLine());

             while (digit > 0)
             {
                 reversed = reversed * 10 + digit % 10;
                 digit /= 10;
             }
             Console.Write("Your reversed digit: " + reversed);*/

            //Завдання1 2.  Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
            /* 
              string str;
              Console.Write("Enter string: ");
              str = Console.ReadLine();
             Console.Write("Reversed: ");
             for (int i = str.Length-1; i >=0; i--)
              {
                  Console.Write(str[i]);
              } 
            */
            //Завдання1 3.  Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)

            /*string text = "123456.45678";
            Console.Write("Enter digit: ");
            text = Console.ReadLine();
            string[] words = text.Split(new char[] { '.' });
            int a;
            int b;


            a = Convert.ToInt32(words[0]);
            b = Convert.ToInt32(words[1]);

            int reverseda = reversed(a);
            int reversedb = reversed(b);

            Console.WriteLine("Reversed digit: " + reverseda + "." + reversedb);*/


            //Завдання 1.4.Реалізувати метод, що буде масив повертати задом навпаки(Використання Array.Reverse() заборонено!)

            /* int n = 5;
             int[] arr = new int[n];
             for (int i = 0; i < n; i++)
             {
                 Console.Write("Enter the" + (i + 1) + " digit in the array: ");
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine(string.Join(", ", Reverse(arr)));

             Reverse(ref arr);
             Console.WriteLine(string.Join(", ", arr));

             Reverse(arr, out int[] reversed);
             Console.WriteLine(string.Join(", ", reversed));
             */

            //Завдання 2 (6)  Перевірити істинність вислову: "Дане ціле число є непарним тризначним числом". 

            /* string stringNumber = Console.ReadLine();
             if (!int.TryParse(stringNumber, out int number))
             {
                 Console.WriteLine("Не ціле число!");
                 Console.ReadKey();
                 return;
             }
            Console.WriteLine(check(number));
            */
            //Завдання 3 Поміняти місцями мінімальний і максимальний елементи масиву розміру N. 
            int n = 5;
             double[] numbers = new double[n];
             for (int i = 0; i < n; i++)
             {
                 Console.Write("Enter the" + (i + 1) + " digit in the array: ");
                 numbers[i] = Convert.ToInt32(Console.ReadLine());
             }

int minValueIndex = 0;
             int maxValueIndex = 0;
             for (int i = 1; i < numbers.Length; i++)
             {
                 if (numbers[i] < numbers[minValueIndex])
                 {
                     minValueIndex = i;
                 }
                 if (numbers[i] > numbers[maxValueIndex])
                 {
                     maxValueIndex = i;
                 }
             }

             double tmp = numbers[minValueIndex];
             numbers[minValueIndex] = numbers[maxValueIndex];
             numbers[maxValueIndex] = tmp;

             Console.WriteLine(string.Join(", ", numbers));
             
            Console.ReadKey();
        }
        //Завдання 2 (6) Перевірити істинність вислову: "Дане ціле число є непарним тризначним числом".
        private static bool check(int number)
        {
            int numberAbs = Math.Abs(number);
            return numberAbs >= 100 && numberAbs < 1000 && numberAbs % 2 == 1;
        }
        //Завдання1.3.  Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
        static int reversed(int b)
        {
            int reversedb = 0;
            while (b > 0)
            {
                reversedb = reversedb * 10 + b % 10;
                b /= 10;
            }
            return reversedb;
        }
    }
}