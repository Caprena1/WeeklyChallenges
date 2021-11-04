using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           return char.IsLetter(c);            
        }

         public bool CountOfElementsIsEven(string[] vals)
         {

             return vals.Count() % 2 == 0;
         }

         public bool IsNumberEven(int number)
         {
             return number % 2 == 0;
         }

         public bool IsNumberOdd(int num)
         {
             return num % 2 != 0;
         }

         public double SumOfMinAndMax(IEnumerable<double> numbers)
         {
             if (numbers == null || numbers.Count() == 0)
             {
                 return 0;
             }
             return numbers.Min() + numbers.Max();

         }

         public int GetLengthOfShortestString(string str1, string str2)
         {
             if (str1.Length > str2.Length)
             {
                 return (str2.Length);
             }
             else
             {
                 return str1.Length;
             }
         }

         public int Sum(int[] numbers)
         {
            int sum = 0;
            if (numbers == null)
                return 0;

            foreach (var num in numbers)
            {
                                        
                 sum += num;
             }
             return sum;
         }

         public int SumEvens(int[] numbersList)
         {
            int sum = 0;
            if (numbersList == null)
                return 0;
            
            for (int i = 0; i < numbersList.Length; i++)
            {
                if (numbersList[i] % 2 == 0)
                    sum += numbersList[i];
                    
            }
            return sum;
          
         }

        public bool IsSumOdd(List<int> numbers)
         {
            if (numbers == null)
                return false;
            int sum = numbers.Sum();
            if (sum % 2 != 0)
                return true;
            else
                return false;
        }





        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
        }

    }
}



    
          
         


    

