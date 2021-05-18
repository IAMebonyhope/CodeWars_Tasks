using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTasks
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            List<String> phoneNumber = new List<String>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0) phoneNumber.Add("(");
                phoneNumber.Add(Convert.ToString(numbers[i]));
                if (i == 2)
                {
                    phoneNumber.Add(") ");
                }
                if (i == 5) phoneNumber.Add("-");
            }

            return string.Join("", phoneNumber.ToArray());
        }
    }
}
