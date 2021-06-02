using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTasks
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> filteredIntegers = new List<int>();
            foreach(var item in listOfItems)
            {
                if (item is int) filteredIntegers.Add(Convert.ToInt32(item));
            }

            return filteredIntegers;

            //Other possible solutions
            //===================================
            //return listOfItems.OfType<int>();
            //return listOfItems.Where(x => x is int).Select(x => (int)x);
        }
    }

}
