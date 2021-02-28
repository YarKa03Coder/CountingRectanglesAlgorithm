using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectanglesTask.UnitTests
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]

        [DataTestMethod]
        [DataRow(new int[] { 1 }, 1)]
        [DataRow(new float[] { 1, 2, 3, 4, 5 }, 5)]
        [DataRow(new double[] { 3, 10, 3, 8, 3, 6, 3, 4, 3, 0, 6, 0, 6, 4, 6, 8, 6, 10 }, 18)]

        public void CountElementsOfIEnumerable_ShouldReturnNumberOfElements_WhenCollectionIsValid(IEnumerable enumerableCollection, int expectedResult)
        {
            var actualResult = enumerableCollection.CountElementsOfIEnumerable();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        
        [DataTestMethod]
        [DataRow(null)]
        
        public void CountElementsOfIEnumerable_ShouldReturnNumberOfElements_ShouldThrowException_WhenCollectionIsNull(IEnumerable enumerableCollection)
        {
            Assert.ThrowsException<ArgumentNullException>(() => enumerableCollection.CountElementsOfIEnumerable(), "Parameter can not be null");
        }
    }
}