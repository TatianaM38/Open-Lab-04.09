using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            List<string> str = new List<string>();
            foreach (string original in strings)
            {
                if (!str.Contains(original))
                {
                    str.Add(original);
                }
            }

            return str.ToArray();
        }
    }
}
