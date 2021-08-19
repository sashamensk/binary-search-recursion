using System;

namespace BinarySearchTask
{
    /// <summary>
    /// Class for basic array operations.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Implements binary search recursively, see https://en.wikipedia.org/wiki/Binary_search_algorithm.
        /// </summary>
        /// <param name="source">Source sorted array.</param>
        /// <param name="value">Value to search.</param>
        /// <returns>
        /// The position of an element with a given value in sorted array.
        /// If element is not found returns null.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <example>
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 11 => 6,
        /// source = {1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634}, value = 144 => 9,
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 0 => null,
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 14 => null.
        /// source = { }, value = 14 => null.
        /// </example>
        public static int? BinarySearch(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return BSAlgorithm(source, value, 0, source.Length - 1);
        }

        public static int? BSAlgorithm(int[] source, int value, int left, int right)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (left <= right)
            {
                int i = left + ((right - left) / 2);
                if (source[i] == value)
                {
                    return i;
                }

                if (source[i] < value)
                {
                    left = i + 1;                    
                    return BSAlgorithm(source, value, left, right);
                }
                else 
                {
                    right = i - 1;
                    return BSAlgorithm(source, value, left, right);
                }                
            }

            return null;
        }
    }
}
