using System;
using System.Collections.Generic;
using System.Linq;

namespace RectanglesTask
{
    public class CoordinatesModel
    {
        /// <summary>
        /// Splitting the coordinates in the array by y, grouping them by x
        /// </summary>
        /// <typeparam name="T">Type of the elements of the array</typeparam>
        /// <param name="coordinatesArray">Array, that contains pairs of x, y coordinates</param>
        /// <returns></returns>
        public static Dictionary<T, List<T>> SplitCoordinates<T>(IReadOnlyList<T> coordinatesArray)
        {
            if (coordinatesArray is null)
            {
                throw new ArgumentNullException(nameof(coordinatesArray), "Argument can not be null");
            }

            if (coordinatesArray.Count % 2 != 0)
            {
                throw new ArgumentException("The array must contain an even number of elements");
            }

            var dictionary = new Dictionary<T, List<T>>();

            var keys = coordinatesArray.Where((x, index) => index % 2 == 0).Distinct().OrderBy(x=>x);

            foreach (var key in keys)
            {
                var yArray = coordinatesArray
                    .Where((y, index) => index % 2 != 0 && coordinatesArray[index - 1].Equals(key))
                    .OrderBy(y => y)
                    .Distinct()
                    .ToList();

                dictionary.Add(key, yArray);
            }

            return dictionary;
        }
    }
}