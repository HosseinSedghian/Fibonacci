using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sequenceLength, currentItem;
            Console.Write("Enter a number of sequences : ");
            sequenceLength = int.Parse(Console.ReadLine());
            List<int> FiboList = new List<int>();
            FiboList.Add(0);
            FiboList.Add(1);
            for (int i = 2; i< sequenceLength; i++)
            {
                currentItem = FiboList[i - 2] + FiboList[i - 1];
                FiboList.Add(currentItem);
            }
            foreach (int item in FiboList)
                Console.Write($"{item}, ");
            Console.Write("\b\b");
        }
    }
}
