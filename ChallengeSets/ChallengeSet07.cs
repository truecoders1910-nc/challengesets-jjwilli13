using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            int sum = 0;

            if (businesses == null)
            {
                return 0;
            }
         
            foreach (var business in businesses)
            {
                if (business.TotalRevenue < business.TotalExpenses)
                {
                    sum++;
                }
            }
            return sum;
            
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {

            var list = businesses.Where(x => x.TotalRevenue - x.TotalExpenses > 0).Select(x => x.Name);
            return String.Join(",", list);
                                                  
     
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            
            if (business.ParentCompany == null)
            {
                return business.Name;
            }
            business.Name = GetNameOfHighestParentCompany(business.ParentCompany);
            return business.Name;
  
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            throw new NotImplementedException();
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers.Length == 0 || numbers == null)
            {
                return false;
            }

           int count= 0;

            foreach (int[] nums in numbers)
            {
                if (nums.Contains(targetNumber))
                {
                    count++;
                }
            }
            if (count == numbers.Length)
            {
                return true;
            }
            return false;

        }
    }
}
