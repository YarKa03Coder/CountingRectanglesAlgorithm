using System;


namespace RectanglesTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arr = new double[] {3, 10, 3, 8, 3, 6, 3, 4, 3, 0, 6, 0, 6, 4, 6, 8, 6, 10};

            try
            {
                var coordsCollection = OrthogonalRectangles.GetIntersectedCoordsCollection(CoordinatesModel.SplitCoordinates(arr));
                OrthogonalRectangles.CalculateRectanglesByCoordinates(coordsCollection);
                Console.WriteLine($"Amount of rectangles = {OrthogonalRectangles.Count}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{exception.TargetSite.Name} - {exception.Message}");
            }
            
            Console.ReadKey();
        }
    }
}
