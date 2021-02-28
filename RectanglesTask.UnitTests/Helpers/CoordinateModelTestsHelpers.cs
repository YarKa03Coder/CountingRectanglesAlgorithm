using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectanglesTask.UnitTests.Helpers
{
    public class CoordinateModelTestsHelpers
    {
        public static void SplitPoints_ShouldThrowException_WhenArrayIsNullHelper<T>()
        {
            Assert.ThrowsException<ArgumentNullException>(() => CoordinatesModel.SplitCoordinates((IReadOnlyList<T>) null),
                "Argument can not be null");
        }

        public static void SplitPoints_ShouldThrowException_WhenArrayCountIsNotEvenHelper<T>()
        {
            var random = new Random();
            var readOnlyList = (IReadOnlyList<T>) Enumerable
                .Range(0, 1 + 2 * random.Next(5))
                .Select(r => random.Next(10))
                .ToList();
            
            Assert.ThrowsException<ArgumentException>(() => CoordinatesModel.SplitCoordinates(readOnlyList),
                "The array must contain an even number of elements");
        }

        public static void SplitPoints_ShouldReturnDictionary_WhenArrayIsNotNullHelper<T>(IReadOnlyList<T> readOnlyCollection, Dictionary<T, List<T>> expectedDictionary)
        {
            var result = CoordinatesModel.SplitCoordinates(readOnlyCollection);
            
            expectedDictionary.Should().BeEquivalentTo(result);
        }
    }
}