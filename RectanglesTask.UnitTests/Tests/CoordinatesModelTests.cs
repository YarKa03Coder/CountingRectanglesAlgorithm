using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectanglesTask.UnitTests.Helpers;

namespace RectanglesTask.UnitTests
{
    [TestClass]
    public class CoordinatesModelTests
    {
        [TestMethod]
        public void SplitPoints_ShouldReturnDictionary_WhenArrayIsNotNull()
        {
           CoordinateModelTestsHelpers.SplitPoints_ShouldReturnDictionary_WhenArrayIsNotNullHelper(new int[] {3, 10, 3, 8, 3, 6, 3, 4, 3, 0, 6, 0, 6, 4, 6, 8, 6, 10},
               new Dictionary<int, List<int>>()
               {
                   {3, new List<int> {0, 4, 6, 8, 10} },
                   {6, new List<int> {0, 4, 8, 10} }
               });
           CoordinateModelTestsHelpers.SplitPoints_ShouldReturnDictionary_WhenArrayIsNotNullHelper(new float[]{1, 0, 6, 2, 8, 0, 6, 5, 6, 7, 6, 8, 8, 12, 1, 2, 1, 9, 8, 8, 1, 11},
               new Dictionary<float, List<float>>()
               {
                   {1, new List<float> {0, 2, 9, 11}},
                   {6, new List<float> {2, 5, 7, 8}},
                   {8, new List<float> {0, 8, 12} }
               });
           CoordinateModelTestsHelpers.SplitPoints_ShouldReturnDictionary_WhenArrayIsNotNullHelper<double>(new double[]{1, 0, 1, 0, 1, 1, 2, 2, 2, 3, 2, 2, 3, 5, 3, 4, 3, 4, 3, 5},
               new Dictionary<double, List<double>>()
               {
                   {1, new List<double> {0, 1}},
                   {2, new List<double> {2, 3} },
                   {3, new List<double> {4, 5}}
               });
        }

        [TestMethod]
        public void SplitPoints_ShouldThrowException_WhenArrayIsNull()
        {
            CoordinateModelTestsHelpers.SplitPoints_ShouldThrowException_WhenArrayIsNullHelper<int>();
            CoordinateModelTestsHelpers.SplitPoints_ShouldThrowException_WhenArrayIsNullHelper<float>();
            CoordinateModelTestsHelpers.SplitPoints_ShouldThrowException_WhenArrayIsNullHelper<double>();
        }

        [TestMethod]
        public void SplitPoints_ShouldThrowException_WhenArrayCountIsNotEven()
        {
            CoordinateModelTestsHelpers.SplitPoints_ShouldThrowException_WhenArrayCountIsNotEvenHelper<int>();
            CoordinateModelTestsHelpers.SplitPoints_ShouldThrowException_WhenArrayIsNullHelper<float>();
            CoordinateModelTestsHelpers.SplitPoints_ShouldThrowException_WhenArrayIsNullHelper<double>();
        }
    }
}