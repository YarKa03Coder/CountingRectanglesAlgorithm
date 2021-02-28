using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RectanglesTask
{
    public class OrthogonalRectangles
    {
        public static int Count { get; private set; } = 0;

        /// <summary>
        /// Get the collection of intersected y coordinates 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary">Collection of y coordinates grouped by x coordinates</param>
        /// <returns></returns>
        public static List<List<TValue>> GetIntersectedCoordsCollection<TKey, TValue>(IDictionary<TKey, List<TValue>> dictionary)
        {
            if (dictionary is null)
            {
                throw new ArgumentNullException(nameof(dictionary), "Parameter can not be null");
            }
            
            var yCoordsList = dictionary.Select(coordinates => coordinates.Value).ToList();

            var result = new List<List<TValue>>();

            for (var i = 0; i < yCoordsList.Count - 1; i++)
            {
                for (var j = i + 1; j < yCoordsList.Count; j++)
                {
                    var resultOfIntersections = yCoordsList[i].Intersect(yCoordsList[j]).ToList();
                    if (!result.Any((x) => x.SequenceEqual(resultOfIntersections)))
                    {
                        result.Add(resultOfIntersections);
                    }
                }
            }

            return result;
        }
        
        /// <summary>
        /// Calculates count of rectangles from inputted y coordinates collection
        /// </summary>
        /// <param name="enumerableCoordinatesCollection">Coordinates y collection</param>
        public static void CalculateRectanglesByCoordinates(IEnumerable<IEnumerable> enumerableCoordinatesCollection)
        {
            if (enumerableCoordinatesCollection is null)
            {
                throw new ArgumentNullException(nameof(enumerableCoordinatesCollection), "Argument can not be null");
            }

            Count = default;
            
            using (var enumerator = enumerableCoordinatesCollection.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Count += PermutationGenerator.GetRectanglesAmountFromCollection(enumerator.Current);
                }
            }
        }
    }
}