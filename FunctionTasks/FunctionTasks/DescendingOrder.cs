using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTasks
{
    public static class DescendingOrder
    {
        public static int DescendingOrderFunction(int num)
        {
            List<int> descendingNumberList = new List<int>();

            while(num > 0)
            {
                descendingNumberList.Add(num % 10);
                num /= 10;
            }

            if (descendingNumberList.Count == 0)
            {
                return 0;
            }

            descendingNumberList.Sort();
            descendingNumberList.Reverse();
            int descendingNumber = descendingNumberList[0];

            for(int i=1; i<descendingNumberList.Count; i++)
            {
                descendingNumber = (descendingNumber * 10) + descendingNumberList[i];
            }

            return descendingNumber;
        }

        //char[] arr = num.ToString().ToCharArray();
        //Array.Sort(arr);
        //Array.Reverse(arr);
        //return Convert.ToInt32(new string (arr));
    }

}
