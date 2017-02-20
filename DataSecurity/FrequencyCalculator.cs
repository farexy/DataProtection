using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity
{
    class FrequencyCalculator
    {
        public static Dictionary<char, int> CalculateFriquency(string text)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char i in text)
            {
                if (result.ContainsKey(i))
                {
                    result[i]++;
                }
                else
                {
                    result.Add(i, 1);
                }
            }

            return result;
        }
    }
}
