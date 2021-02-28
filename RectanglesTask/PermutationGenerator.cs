using System;
using System.Collections;

namespace RectanglesTask
{
    public class PermutationGenerator
    {
        /// <summary>
        /// Calculating amount of rectangles from enumerableCollection, using combinations
        /// </summary>
        /// <param name="enumerableCollection">Collection of 'y' coordinates, grouped by 'x'</param>
        /// <returns></returns>
        public static int GetRectanglesAmountFromCollection(IEnumerable enumerableCollection)
        {
            if (enumerableCollection is null)
            {
                throw new ArgumentNullException(nameof(enumerableCollection), "Argument can not be null");
            }

            var elementsAmount = enumerableCollection.CountElementsOfIEnumerable();
            
            if (elementsAmount <= 1)
            {
                throw new ArgumentException("Collection has to have at least two elements");
            }

            return GetCombinationsNumberForCollection(elementsAmount);
        }

        /// <summary>
        /// Calculating the number of combinations from N by M
        /// </summary>
        /// <param name="n">Brute force elements</param>
        /// <param name="m">Number of elements to combine</param>
        /// <returns></returns>
        private static int GetCombinationsNumberForCollection(int n, int m = 2)
        {
            if (m == 0 || m == n)
            {
                return 1;
            }

            return GetCombinationsNumberForCollection(n - 1, m - 1) + GetCombinationsNumberForCollection(n - 1, m);
        }
    }
}