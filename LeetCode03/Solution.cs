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
            if (s == String.Empty)
                return 0;

            char[] chars = s.ToCharArray();
            List<string> tmps = new List<string>();
            string tmp = "";
            for (int i = 0; i < chars.Length; i++)
            {

                if (!TempIsExistCharInChars(tmp, chars, i))
                {
                    var key = chars[i];
                    tmp = tmp + key;

                    if (i == chars.Length - 1)
                    {
                        tmps.Add(tmp);
                    }
;
                }
                else
                {
                    tmps.Add(tmp);
                    tmp = tmp.Substring(1, tmp.Length-1);

                }

            }

            return tmps.Select(x => x.Length).Max(x => x);

        }

        private bool TempIsExistCharInChars(string tmp, char[] chars, int index)
        {
            var key = chars[index];
            return tmp.Any(x => x == key);
        }
    }
}
