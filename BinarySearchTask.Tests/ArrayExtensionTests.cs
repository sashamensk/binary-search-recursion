using System;
using NUnit.Framework;
using static BinarySearchTask.ArrayExtension;

#pragma warning disable CA1707

namespace BinarySearchTask.Tests
{
    public class ArrayExtensionTests
    {
        [TestCase(new[] { 6 }, 6, ExpectedResult = 0)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 6, ExpectedResult = 3)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 1, ExpectedResult = 0)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 11, ExpectedResult = 6)]
        [TestCase(new[] { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634 }, 144, ExpectedResult = 9)]
        [TestCase(new[] { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 }, 21, ExpectedResult = 5)]
        public int BinarySearch_ReturnIndexOfValueInArray(int[] source, int value)
        {
            return BinarySearch(source, value).Value;
        }

        [TestCase(new[] { 6 }, 7, ExpectedResult = null)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 0, ExpectedResult = null)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 14, ExpectedResult = null)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 11, ExpectedResult = 6)]
        [TestCase(new int[] { }, 144, ExpectedResult = null)]
        [TestCase(new[] { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 }, 21, ExpectedResult = 5)]
        public int? BinarySearch_ReturnNull(int[] source, int value)
        {
            return BinarySearch(source, value);
        }

        [Test]
        public void BinarySearch_SourceArrayIsNull_ThrowArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => BinarySearch(null, 1), "Source array cannot be null.");
        
        [TestCase(new[] { 6 }, 6, ExpectedResult = 0)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 6, ExpectedResult = 3)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 1, ExpectedResult = 0)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 11, ExpectedResult = 6)]
        [TestCase(new[] { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634 }, 144, ExpectedResult = 9)]
        [TestCase(new[] { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 }, 21, ExpectedResult = 5)]
        public int BinarySearchRecursively_ReturnIndexOfValueInArray(int[] source, int value)
        {
            return BinarySearchRecursively(source, value).Value;
        }

        [TestCase(new[] { 6 }, 7, ExpectedResult = null)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 0, ExpectedResult = null)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 14, ExpectedResult = null)]
        [TestCase(new[] { 1, 3, 4, 6, 8, 9, 11 }, 11, ExpectedResult = 6)]
        [TestCase(new int[] { }, 144, ExpectedResult = null)]
        [TestCase(new[] { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 }, 21, ExpectedResult = 5)]
        public int? BinarySearchRecursively_ReturnNull(int[] source, int value)
        {
            return BinarySearchRecursively(source, value);
        }

        [Test]
        public void BinarySearchRecursively_SourceArrayIsNull_ThrowArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => BinarySearchRecursively(null, 1), "Source array cannot be null.");

    }
}