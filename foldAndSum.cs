using System;
using System.Collections.Generic;
using System.Linq;

namespace foldAndSum
{
    class foldAndSum
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> firstAndLastNumbers = new List<int>();
            List<int> summedList = new List<int>();
            int rows = numbers.Count / 4;

            GetFirstAndLastNumbers(rows, numbers, firstAndLastNumbers);
            GetMiddleNumbers(rows, numbers);

            GetReversedList(numbers);
            GetReversedList(firstAndLastNumbers);

            GetFirstAndLastNumbers(rows, numbers, firstAndLastNumbers);
            GetMiddleNumbers(rows, numbers);

            GetReversedList(numbers);

            GetSummedList(numbers, firstAndLastNumbers, summedList);
            PrintEachElement(summedList);

        }

        static List<int> GetFirstAndLastNumbers(int rows, List<int> numbers, List<int> reworkedNumbers) 
        {
            for (int i = 0; i < rows; i++)
            {
                reworkedNumbers.Add(numbers[i]);
            }
            return reworkedNumbers;
        }

        static List<int> GetMiddleNumbers(int rows, List<int> numbers)
        {
            for (int i = 0; i < rows; i++)
            {
                numbers.RemoveAt(0);
            }
            return numbers;
        }

        static List<int> GetReversedList(List<int> numbers)
        {
            numbers.Reverse();
            return numbers;
        }

        static List<int> GetSummedList(List<int> firstAndLastNumbers, List<int> middleNumbers, List<int> finalResult)
        {
            for (int i = 0; i < firstAndLastNumbers.Count; i++)
            {
                var integer = firstAndLastNumbers[i] + middleNumbers[i];
                finalResult.Add(integer);
            }

            return finalResult;
        }

        static void PrintEachElement(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
