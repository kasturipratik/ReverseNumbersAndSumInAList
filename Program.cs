using System;

namespace ReverseIntElementInAnArrayAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 579, 20001 };
            int totalReverseSum = 0;
            int stringTotalReverseSum = 0;
            foreach(int num in numbers)
            {
                totalReverseSum += ReverseNum(num);
                stringTotalReverseSum += ReverseNumWithString(num);
            }

            Console.WriteLine("Total sum of reversed num: "+ totalReverseSum);
            Console.WriteLine("Total sum of reversed num using string: " + totalReverseSum);
        }

        // fist solution
        static int ReverseNum(int num)
        {
            int reversed = 0;
            while(num != 0)
            {
                // get the last digit as remainder (calculate remainder in an interger after dividing by 10)
                int digit = num % 10;

                // create additional place holder and add digit infront
                reversed = reversed * 10 + digit;
                // remove placeholder in num (how many times is it divisible)
                num /= 10;
            }
            return reversed;
        }

        // convert int into string, revers it and convert back to num
        static int ReverseNumWithString(int num)
        {
            var flag = false;
            if (num < 0)
            {
                flag = true;
                num *= -1;
            }
            var convertNum = num.ToString();
            var reversedConvertedString = new Char[convertNum.Length];
            for (int i = 1; i <= convertNum.Length; i++)
            {
                reversedConvertedString[convertNum.Length - i] = convertNum[i - 1];
            }
            convertNum = new string(reversedConvertedString);
            try
            {
                if (flag)
                {
                    return Convert.ToInt32(convertNum) * -1;
                }
                return Convert.ToInt32(convertNum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
    }
}
