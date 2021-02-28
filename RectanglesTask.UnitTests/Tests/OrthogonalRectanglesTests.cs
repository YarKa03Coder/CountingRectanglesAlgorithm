using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectanglesTask.UnitTests.Helpers;

namespace RectanglesTask.UnitTests
{
    [TestClass]
    public class OrthogonalRectanglesTests
    {
        [TestMethod]
        public void GetIntersectedCoordsCollection_ShouldThrowException_WhenDictionaryIsNull()
        {
            OrthogonalRectanglesTestsHelpers
                .GetIntersectedCoordsCollection_ShouldThrowException_WhenDictionaryIsNullHelper((Dictionary<int, List<int>>) null);
        }

        [TestMethod]
        public void GetIntersectedCoordsCollection_ShouldReturnCollection_WhenDictionaryIsNotNull()
        {
            OrthogonalRectanglesTestsHelpers
                .GetIntersectedCoordsCollection_ShouldReturnCollection_WhenDictionaryIsNotNullHelper(new List<List<int>>()
                {
                    new List<int> {0, 4, 8, 10}
                }, new Dictionary<int, List<int>>()
                {
                    {3, new List<int> {0, 4, 6, 8, 10}},
                    {6, new List<int> {0, 4, 8, 10} }
                });
            
            OrthogonalRectanglesTestsHelpers.GetIntersectedCoordsCollection_ShouldReturnCollection_WhenDictionaryIsNotNullHelper(new List<List<double>>()
            {
                new List<double> {0, 4, 8, 10},
                new List<double> {0, 8}
            }, new Dictionary<int, List<double>>()
            {
                {3, new List<double> {0, 4, 6, 8, 10}},
                {6, new List<double> {0, 4, 8, 10}},
                {8, new List<double> {0, 8, 12}}
            });
        }

        [TestMethod]
        public void CalculateRectanglesByCoordinates_ShouldThrowException_WhenCollectionIsNull()
        {
            OrthogonalRectanglesTestsHelpers.CalculateRectanglesByCoordinates_ShouldThrowException_WhenCollectionIsNullHelper();
        }

        [TestMethod]
        public void CalculateRectanglesByCoordinates_ShouldReturnIntegerResult_WhenCollectionIsNotNull()
        {
            var enumerableCollectionFirst = new List<List<int>> {new List<int> {0, 4, 8, 10}};
            var enumerableCollectionSecond = new List<List<int>>
            {
                new List<int> {0, 4, 8, 10}, 
                new List<int> {0, 8}
            };

            OrthogonalRectanglesTestsHelpers
                .CalculateRectanglesByCoordinates_ShouldReturnIntegerResult_WhenCollectionIsNotNullHelper(enumerableCollectionFirst, 6);

            OrthogonalRectanglesTestsHelpers
                .CalculateRectanglesByCoordinates_ShouldReturnIntegerResult_WhenCollectionIsNotNullHelper(enumerableCollectionSecond, 7);
        }
    }
}