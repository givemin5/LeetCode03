using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode03
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            char[] chars = s.ToCharArray();
            List<string> tmps = new List<string>();
            for (int i = 0; i < chars.Length; i++)
            {
                

                int currentIndex = i;
                string tmp = "";

                while (currentIndex < chars.Length  && !TempIsExistCharInChars(tmp,chars,currentIndex) )
                {
                    var key = chars[currentIndex];
                    tmp = tmp + key;
                    currentIndex = currentIndex + 1;
                }

                tmps.Add(tmp);
                tmp = "";



            }

            return tmps.Select(x => x.Length).Max(x => x);
          
        }

        private bool TempIsExistCharInChars(string tmp, char[] chars, int i)
        {
            var key = chars[i];
            return tmp.Any(x => x == key);
        }
    }
}
