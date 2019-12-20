using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {

        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool contains = false;

            for (var i = 0; i < vals.Length; i++)
            {
                if (vals [i] == false)
                {
                    return true;
                }

            }
            return contains;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {

                return false;

            }
            int sum = 0;
            bool odd = false;

            foreach (var number in numbers)
            {
                sum += number;
            }
            if (sum % 2 != 0)
            {
                odd = true;
                
            }
            return odd;






        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;


        }

        public char GetFirstLetterOfString(string val)
        {


            return val[0];


        }



        public char GetLastLetterOfString(string val)
        {


            return val[^1];


        }


        public decimal Divide(decimal dividend, decimal divisor)
        {

            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;

        }



        public int LastMinusFirst(int[] nums)
        {

            return nums[nums.Length - 1] - nums[0];


        }



        public int[] GetOddsBelow100()
        {

            List<int> numbers = new List<int>();

            { for (int i = 1; i <= 100; i++)
            
                if (i % 2 != 0)
                {
                  numbers.Add(i);
                
                }

            }
            int[] numbers1 = new int[numbers.Count];
            for (int j = 0; j < numbers.Count; j++)
            {

                numbers1[j] = numbers[j];
            }
            return numbers1;
                    

        }
        


        public void ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();

        }
    }
}
