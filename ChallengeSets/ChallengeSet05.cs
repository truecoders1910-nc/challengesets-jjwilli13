﻿using System.Linq;
using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            return ((startNumber / n) + 1) *n;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED";
                }
            }

        }
 
        public bool IsAscendingOrder(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }   

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;

        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
                

            }
            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if (sentence.Length == 0)
            {
                return "";
            }
            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();

            for (int i = 3; i < elements.Count; i +=4)
            {

                everyFourth.Add(elements[i]);

            }
            return everyFourth.ToArray();


        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}
