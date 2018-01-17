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
                var key = chars[i];
                if (!TempIsExistCharInChars(tmp, chars, i))
                {
                    
                    tmp = tmp + key;

                    if (i == chars.Length - 1)
                    {
                        tmps.Add(tmp);
                    }

                }
                else
                {
                    tmps.Add(tmp);

                    var startIndex = tmp.IndexOf(key)+1;

                    tmp = tmp.Length == startIndex ? "" : tmp.Substring(startIndex, tmp.Length - startIndex);

                    tmp = tmp + key;

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
