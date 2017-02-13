﻿using System;


namespace SumArrayElements
{
    public class Program
    {
      public  static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
