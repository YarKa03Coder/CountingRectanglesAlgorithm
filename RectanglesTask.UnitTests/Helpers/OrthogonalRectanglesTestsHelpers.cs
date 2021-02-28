using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectanglesTask.UnitTests.Helpers
{
    public class OrthogonalRectanglesTestsHelpers
    {
        public static void GetIntersectedCoordsCollection_ShouldThrowException_WhenDictionaryIsNullHelper<TKey, TValue>(IDictionary<TKey, List<TValue>> dictionary)
        {
            Assert.ThrowsException<ArgumentNullException>(() => OrthogonalRectangles.GetIntersectedCoordsCollection(dictionary), "Parameter can not be null");
        }

        public static void GetIntersectedCoordsCollection_ShouldReturnCollection_WhenDictionaryIsNotNullHelper<TKey, TValue>(List<List<TValue>> expectedList, IDictionary<TKey, List<TValue>> dictionary)
        {
            expectedList.Should().BeEquivalentTo(OrthogonalRectangles.GetIntersectedCoordsCollection(dictionary));
        }

        public static void CalculateRectanglesByCoordinates_ShouldThrowException_WhenCollectionIsNullHelper()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OrthogonalRectangles.CalculateRectanglesByCoordinates(null),
                "Argument can not be nul");
        }

        public static void CalculateRectanglesByCoordinates_ShouldReturnIntegerResult_WhenCollectionIsNotNullHelper(IEnumerable<IEnumerable> enumerable, int expectedResult)
        {
            OrthogonalRectangles.CalculateRectanglesByCoordinates(enumerable);
            
            var actualResult = OrthogonalRectangles.Count;
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}