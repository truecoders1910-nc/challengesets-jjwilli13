using System.Collections.Generic;
using System.Linq;
using System;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }

            }
            return sum;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            int shortestLength = 0;

            if (str1.Length > shortestLength)
            {
                shortestLength = str1.Length;

                if (str2.Length < shortestLength)
                {
                    shortestLength = str2.Length;
                }
                if (str3.Length < shortestLength)
                {
                    shortestLength = str3.Length;

                }
                if (str4.Length < shortestLength)
                {
                    shortestLength = str4.Length;
                }


            }
            return shortestLength;
        }


        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {

            int smallestNum = int.MinValue;

            if (number1 > smallestNum)
            {
                smallestNum = number1;

                if (number2 < smallestNum)
                {
                    smallestNum = number2;
                }

                if (number3 < smallestNum)
                {
                    smallestNum = number3;
                }

                if (number4 < smallestNum)
                {
                    smallestNum = number4;
                }


            }
            return smallestNum;


        }


        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if (sideLength1 + sideLength2 > sideLength3)
            {

                if (sideLength1 + sideLength3 > sideLength2)
                {


                    if (sideLength2 + sideLength3 > sideLength1)
                    {

                        return true;

                    }
                }

            }
            return false;

        }

        public bool IsStringANumber(string input)
        {

            double i = 0;

            return Double.TryParse(input, out i);


        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            int majorityNull = objs.Count(s => s == null);
            int notNull = objs.Count(s => s != null);

            if (majorityNull > notNull)
            {
                return true;
            }
            return false;

        }

        public double AverageEvens(int[] numbers)
        {
            
            double count = 0;
            double sum = 0;


            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                    sum += numbers[i];
                
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return sum / count;
            
        }


        public int Factorial(int number)
        { 

                if (number < 0) throw new ArgumentOutOfRangeException();

                if (number <= 1)
                    return 1;
                return number * Factorial(number - 1);


            
        }
    }
}