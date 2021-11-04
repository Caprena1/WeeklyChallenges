using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            } 

            var list = new List<int>();
            foreach (var num in numbers)
            {
                if(num % 2 != 0)
                {
                    list.Add(num);
                }
                                                                   
            }
            var sumOdds = list.Sum();
            return (sumOdds % 2 != 0);


        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
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
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor; 
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length -1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int oddNum = 1;
            int[] x = new int[50];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = oddNum;
                oddNum += 2;
            }
            return x;

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
