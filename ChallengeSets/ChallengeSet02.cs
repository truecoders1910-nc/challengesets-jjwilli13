using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {

            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;

        }


        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;

            }
            return false;

        }

        public bool IsNumberOdd(int num)
        {
           if (num % 2 == 0)
           {
             return false;

           }
             return true;

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double minValue = 200000.00;
            double maxValue = 0;

            foreach (double dub in numbers.ToList())
            {
                if (dub < minValue)
                {
                    minValue = dub;
                }
                if (dub > maxValue)
                {
                    maxValue = dub;
                }


                
            }
            return maxValue + minValue;
        }   


        

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {

            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;

        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sumOfEvens = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sumOfEvens += i;
                }
            }
            return sumOfEvens;


        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = Sum(numbers.ToArray());
            if (sum % 2 == 0)
            {
                return false;
            }
            return true;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddCount = 0;

            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;

        }
        
    }
}