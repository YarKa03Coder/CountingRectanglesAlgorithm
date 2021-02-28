using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RectanglesTask.UnitTests
{
    [TestClass]
    public class PermutationGeneratorTests
    {
        private const double Delta = 0.00000001;

        [TestMethod]
        
        [DataTestMethod]
        [DataRow(new float[] {1.0f, 2.0f},1)]
        [DataRow(new double[] {0, 4, 8}, 3)]
        [DataRow(new int[] {0, 4, 8, 10}, 6)]
        [DataRow(new object[] {false, "1", 2, '3', 4.0, 5, .6f, 7, 8, 9}, 45)]
        [DataRow(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}, 105)]

        public void GetRectanglesAmountFromCollection_ShouldReturnAmountOfRectangles_WhenParameterIsValid(IEnumerable enumerableCollection, int expectedResult)
        {
            // Act
            var result = PermutationGenerator.GetRectanglesAmountFromCollection(enumerableCollection);
            
            // Assert
            Assert.AreEqual(expectedResult, result, Delta);
        }
       
        [TestMethod]
        
        [DataTestMethod]
        [DataRow(null)]
        public void GetRectanglesAmountFromCollection_ShouldThrownArgumentNullException_WhenParameterIsNull(IEnumerable enumerableCollection)
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => PermutationGenerator.GetRectanglesAmountFromCollection(enumerableCollection),
                "Argument can not be null");
        }

        [TestMethod]

        [DataTestMethod]
        [DataRow(new int[] {0})]
        public void GetRectanglesAmountFromCollection_ShouldThrownArgumentException_WhenCollectionCountIsLessThanTwo(IEnumerable enumerableCollection)
        {
            Assert.ThrowsException<ArgumentException>(
                () => PermutationGenerator.GetRectanglesAmountFromCollection(enumerableCollection),
                "Collection has to have at least two elements");
        }
    }
}
