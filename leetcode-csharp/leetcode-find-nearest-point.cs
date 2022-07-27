public class SolutionNearestPoint {
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        List<(int[], int, int)> validPoints = new List<(int[], int, int)>();
        for (int i = 0; i < points.Length; i++)
        {
            // Find the valid points.
            if (points[i][0] == x | points[i][1] == y)
            {
                // Calculate the Manhattan distance to the valid points.
                int manhattanDistance = Math.Abs(points[i][0]-x) + Math.Abs(points[i][1]-y);
                validPoints.Add((points[i], manhattanDistance, i));
            }
        }
        // If there are no valid points, return -1. 
        if (validPoints.Count == 0)
        {
            return -1;
        }
        // Find the point(s) with the smallest Manhattan distance.
        List<(int[], int, int)> validPointsOrdered = validPoints.OrderBy(tuple=>tuple.Item2).ToList();
        List<(int[], int, int)> closestValidPoints = new List<(int[], int, int)>();
        // In case of several such points, return the one with
        // the smallest index.
        closestValidPoints = validPointsOrdered.Where(tuple => tuple.Item2 == validPointsOrdered.First().Item2).ToList();
        int closestValidPointIdx = closestValidPoints.OrderBy(tuple => tuple.Item3).First().Item3;
        return closestValidPointIdx;
    }
}