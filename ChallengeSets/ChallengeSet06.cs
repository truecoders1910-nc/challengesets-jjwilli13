using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            if (ignoreCase == true)
            {
                words = words.Where(s => !String.IsNullOrEmpty(s)).ToArray();
                foreach (var item in words)
                {
                    var m = item.ToLower();
                    if (m == word)
                    {
                        return true;
                    }
                }
                return false;
            }
            else if (ignoreCase == false)
            {
                foreach (var item in words)
                {
                    if (item == word)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 0 || num == 1)
            {
                return false;
            }
            else

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
            return true;

        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var occurrenceChar = new Dictionary<char, int>();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (occurrenceChar.ContainsKey(str[i]))
                    occurrenceChar[str[i]]++;
                else
                    occurrenceChar.Add(str[i], 1);
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                var occurrence = occurrenceChar[str[i]];
                if (occurrence == 1)
                    return i;
            }

            return -1;
        }


        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (numbers[i] == numbers[k])
                    {
                        count++;
                        if (count > max)
                            max = count;
                    }
                    else
                    {
                        count = 0;
                    }
                    
                }
            }
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] emptyArr = new double[] { };
            if (elements == null || n<= 0)
            {
                return emptyArr;
            }
            double[] result = new double[elements.Count / n];
            for (int i = n-1; i < elements.Count; i+=n)
            {
                result[i / n] = elements[i];
            }
            return result;

        }
    }
}
