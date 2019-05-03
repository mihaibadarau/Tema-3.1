using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////

            // 1. Given an array of ints, write a C# method to total all the values that are even number.
            //int sum = 0;
            //int[] array = new [] { 34, 54, 23, 12, 32, 77, 55, 45, 76 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 ==0)
            //    {
            //        sum = sum + array[i];
            //        Console.WriteLine($"pozitia: {i} , val: {array[i]}");
            //    }
            //}
            //Console.WriteLine("Suma elementelor pare este: " + sum);

            //////////////////////////////////

            //2. How to find all pairs of elements in an integer array, whose sum is equal to a given number?

            //int[] array = new[] { 1, 2, 3, 5, 20,25 };
            //int suma = 0;

            //Console.WriteLine("introduceti suma: ", suma);
            //suma = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < array.Length; i++)
            //{
            //    {
            //        for (int j = 0; j < array.Length; j++)
            //        {
            //            if (j != i && (array[i] + array[j]) == suma)
            //            {
            //                Console.WriteLine("Numerele sunt: " + array[i] + "," + array[j]);
            //            }
            //        }
            //    }   
            //}

            //4.Algorithm to find if Array contains duplicates?

            //int[] array = { 2, 7, 3, 8, 3, 4, 8 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j =i+1; j < array.Length; j++)
            //    {
            //        if(array[i]==array[j])
            //        {
            //            Console.WriteLine(array[i]);
            //        }
            //    }
            //}

            //5.How to remove duplicates from a sorted linked list?

            //List<int> Lista = new List<int> { 1, 1, 2, 3, 3, 4, 4, 5, 9, 9 };

            //foreach (int value in Lista)
            //{
            //    Console.WriteLine("Inainte: {0}", value);
            //}
            //List<int> Distinct = Lista.Distinct().ToList();
            //foreach (var value in Distinct)
            //{
            //    Console.WriteLine("After : {0}", value);
            //}

            //6.How to find sum of digits of a number using Recursion?

            //int n, m;
            //int suma = 0;
            //Console.WriteLine("Introduceti un numar: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //while (n>0)
            //{
            //    m = n % 10;
            //    suma = suma + m;
            //    n = n / 10;
            //}
            //Console.WriteLine("Suma este: " + suma);

            //7.Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?

            //int[] array = new int [] { 3, 4, 5, 4, 4, 4 };
            //int Majority = 0;
            //int number, count;
            //number = count = 0;
            //for (int i = 0; i <= array.Length; i++)
            //{
            //    for (int j = i; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count > array.Length / 2)
            //    {
            //        Majority = count;
            //        number = array[i];
            //        count = 0;
            //    }
            //    count = 0;
            //}
            //Console.WriteLine("No. " + number + " comes " + Majority);

            //11.Write a function to print the nth number in Fibonacci series?

            //int p1 = 0, p2 = 1, p3 = 0;
            //Console.WriteLine("Introduceti pozitia: ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Console.Write(p1 + " " + p2);

            //for (int i = 2; i < count; i++)
            //{
            //    p3 = p1 + p2;
            //    Console.Write(" "+p3);
            //    p1 = p2;
            //    p2 = p3;
            //}
            //Console.WriteLine();

        }
    }
}

