using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingTheCodingInterview.ArraysAndString;
using CrackingTheCodingInterview;

namespace TestCases
{
    [TestClass]
    public class ArraysAndString
    {
        [TestMethod]
        public void UniqueCharacters()
        {
            string correctValue = "abcdefgh";
            string incorrectValue = "abcdefagh";

            Assert.AreEqual(CheckAllUniqueCharacters.IsAllCharactersUnique(correctValue), true);
            Assert.AreEqual(CheckAllUniqueCharacters.IsAllCharactersUnique(incorrectValue), false);
        }

        [TestMethod]
        public void UniqueCharactersUsingBitManipulations()
        {
            string correctValue = "abcdefgh";
            string incorrectValue = "abcdefagh";

            Assert.AreEqual(CheckAllUniqueCharacters.IsCharactersUniqueUsingBitManipulations(correctValue), true);
            Assert.AreEqual(CheckAllUniqueCharacters.IsCharactersUniqueUsingBitManipulations(incorrectValue), false);
        }


        string original = "abcde";
        string permutation = "cbdea";
        string notPermutation = "cdeaf";

        [TestMethod]
        public void IsPermutationSorting()
        {
            Assert.AreEqual(CheckPermutation.IsPermutationBySorting(original, permutation), true);
            Assert.AreEqual(CheckPermutation.IsPermutationBySorting(original, notPermutation), false);
        }

        [TestMethod]
        public void IsPermutationCharCount()
        {
            Assert.AreEqual(CheckPermutation.IsPermutationCharCount(original, permutation), true);
            Assert.AreEqual(CheckPermutation.IsPermutationCharCount(original, notPermutation), false);
        }

        [TestMethod]
        public void IsPermutation()
        {
            Assert.AreEqual(CheckPermutation.IsPermutation(original, permutation), true);
            Assert.AreEqual(CheckPermutation.IsPermutation(original, notPermutation), false);
        }

        [TestMethod]
        public void UrlifyCTCISoln()
        {
            string str = "Mr John Smith        ";
            char[] strChar = str.ToCharArray();
            URLify.ReplaceSpaces(strChar, 13);
            // if i do not trim the result, it would fail since there will be remaining spaces to handle
            var ans = new String(strChar).Trim();
            Assert.AreEqual(ans, "Mr%20John%20Smith");
        }

        [TestMethod]
        public void UrlifyStringBuilderSoln()
        {
            string str = "Mr John Smith        ";
            char[] strChar = str.ToCharArray();
            Assert.AreEqual(URLify.ReplaceSpacesUsingStringBuilder(strChar, 13), "Mr%20John%20Smith");
        }

        [TestMethod]
        public void PalindromePermutationSoln1()
        {
            string s1 = "liril";
            string s2 = "abcdedccbbaa";
            Assert.AreEqual(PalindromePermutation.Solution1(s1), true);
            Assert.AreEqual(PalindromePermutation.Solution1(s2), false);

            Assert.AreEqual(PalindromePermutation.Solution2(s1), true);
            Assert.AreEqual(PalindromePermutation.Solution2(s2), false);
        }

        [TestMethod]
        public void OneEditAwaySoln1()
        {
            string str = "pale";
            string str2 = "ple";
            string str3 = "pales";
            string str4 = "bale";
            string str5 = "bae";

            Assert.AreEqual(OneEditAway.Solution1(str, str2), true);
            Assert.AreEqual(OneEditAway.Solution1(str3, str), true);
            Assert.AreEqual(OneEditAway.Solution1(str, str4), true);
            Assert.AreEqual(OneEditAway.Solution1(str, str5), false);
        }

        [TestMethod]
        public void OneEditAwaySoln2()
        {
            string str = "pale";
            string str2 = "ple";
            string str3 = "pales";
            string str4 = "bale";
            string str5 = "bae";

            Assert.AreEqual(OneEditAway.IsOneEditAway(str, str2), true);
            Assert.AreEqual(OneEditAway.IsOneEditAway(str3, str), true);
            Assert.AreEqual(OneEditAway.IsOneEditAway(str, str4), true);
            Assert.AreEqual(OneEditAway.IsOneEditAway(str, str5), false);
        }

        [TestMethod]
        public void StringCompressionSoln1()
        {
            string s1 = "aabcccccaaa";
            string s2 = "abcd";

            Assert.AreEqual(StringCompressions.Solution1(s1), "a2b1c5a3");
            Assert.AreEqual(StringCompressions.Solution1(s2), "abcd");
        }

        [TestMethod]
        public void StringCompressionSoln2()
        {
            string s1 = "aabcccccaaa";
            string s2 = "abcd";

            Assert.AreEqual(StringCompressions.Solution2(s1), "a2b1c5a3");
            Assert.AreEqual(StringCompressions.Solution2(s2), "abcd");
        }

        [TestMethod]
        public void MatrixRotation()
        {
            int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int[,] rotatedMatrix = new int[4, 4] { { 13, 9, 5, 1 }, { 14, 10, 6, 2 }, { 15, 11, 7, 3 }, { 16, 12, 8, 4 } };
            var result = RotateMatrix.Solution1(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j< matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(matrix[i, j], rotatedMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void ZeroMatrixTest()
        {
            int[,] matrix = new int[4, 4] { { 1, 2, 0, 4 }, { 5, 6, 7, 8 }, { 1, 0, 1, 2 }, { 3, 4, 5, 6 } };
            int[,] zeroedMatrix = new int[4, 4] { { 0, 0, 0, 0 }, { 5, 0, 0, 8 }, { 0, 0, 0, 0 }, { 3, 0, 0, 6 } };
            ZeroMatrix.Solution1(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(zeroedMatrix[i, j], matrix[i,j]);
                }
            }
        }

        [TestMethod]
        public void StringRotationTest()
        {
            string s1 = "HelloBuddy";
            string rotated = "BuddyHello";
            string notRotated = "BudyHelo32";

            Assert.AreEqual(StringRotation.IsRotation(s1, rotated), true);
            Assert.AreEqual(StringRotation.IsRotation(s1, notRotated), false);
        }
    }
}
