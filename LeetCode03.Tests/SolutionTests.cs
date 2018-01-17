﻿using NUnit.Framework;
using LeetCode03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode03.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void LengthOfLongestSubstringTest_abcabcbb_ShouldBe_abc()
        {
            var input = "abcabcbb";
            Solution solution = new Solution();

            var actual = solution.LengthOfLongestSubstring(input);

            var expected = 3;

            Assert.AreEqual(expected,actual);

        }
    }
}