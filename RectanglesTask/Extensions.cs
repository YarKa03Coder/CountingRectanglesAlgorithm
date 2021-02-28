using System;
using System.Collections;

namespace RectanglesTask
{
    public static class Extensions
    {
        /// <summary>
        /// Calculating elements of IEnumerable collection
        /// </summary>
        /// <param name="enumerableCollection">collection, which implements IEnumerable</param>
        /// <returns></returns>
        public static int CountElementsOfIEnumerable(this IEnumerable enumerableCollection)
        {
            if (enumerableCollection is null)
            {
                throw new ArgumentNullException(nameof(enumerableCollection),"Parameter can not be null");
            }
            
            if (enumerableCollection is ICollection collection)
            {
                return collection.Count;
            }

            var result = 0;

            var enumerator = enumerableCollection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                result++;
            }

            return result;
        }
    }
}