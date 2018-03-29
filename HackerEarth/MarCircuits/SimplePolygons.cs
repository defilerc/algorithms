namespace HackerEarth.MarCircuits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimplePolygons
    {
        public static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            while (t-- > 0) {
                var n = int.Parse(Console.ReadLine());
                var polygons = new Polygon[n];

                // create polygons
                for (var i = 0; i < n; i++) {
                    var k = int.Parse(Console.ReadLine());
                    polygons[i] = new Polygon();

                    for (var j = 0; j < k; j++) {
                        var vertice = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                        polygons[i].Points.Add(new Point(vertice[0], vertice[1]));
                    }
                    
                }

                // handle queries
                var q = int.Parse(Console.ReadLine());
                var points = new List<Point>();

                while (q-- > 0) {
                    var query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    if (query[0] == 1) {
                        points.Add(new Point(query[1], query[2]));
                        continue;
                    }

                    var p = FindNumberOfPointsInsidePolygon(points, polygons[query[1]-1]);
                    Console.WriteLine(p);
                }
            }
        }

        private static int FindNumberOfPointsInsidePolygon(List<Point> points, Polygon polygon)
        {
            var total = 0;
            foreach (var point in points) {
                if (IsInside(point, polygon)) {
                    total++;
                }
            }
            return total;
        }

          private static bool IsInside(Point p, Polygon polygon)
        {
            var n = polygon.Points.Count;

            // There must be at least 3 vertices in polygon[]
            if (n < 3) return false;

            // Create a point for line segment from p to infinite
            Point extreme = new Point(int.MaxValue, p.y);

            // Count intersections of the above line with sides of polygon
            int count = 0, i = 0;
            var sameYcoordPoints = new HashSet<Point>();
            do {
                int next = (i + 1) % n;

                // Check if the line segment from 'p' to 'extreme' intersects
                // with the line segment from 'polygon[i]' to 'polygon[next]'
                if (doIntersect(polygon.Points[i], polygon.Points[next], p, extreme)) {
                    // If the point 'p' is colinear with line segment 'i-next',
                    // then check if it lies on segment. If it lies, return true,
                    // otherwise false
                    if (orientation(polygon.Points[i], p, polygon.Points[next]) == 0) { 
                        return onSegment(polygon.Points[i], p, polygon.Points[next]);
                    }

                    bool invalidIntersection = false;
                    if (p.y == polygon.Points[i].y || p.y == polygon.Points[next].y) {

                        // Possible collision
                        if (sameYcoordPoints.Contains(polygon.Points[i]) ||
                          sameYcoordPoints.Contains(polygon.Points[next])) {
                            invalidIntersection = true;
                        }

                        if (p.y == polygon.Points[i].y)
                            sameYcoordPoints.Add(polygon.Points[i]);
                        else if (p.y == polygon.Points[next].y)
                            sameYcoordPoints.Add(polygon.Points[next]);
                    }

                    if (!invalidIntersection) {
                        count++;
                    }
                }
                i = next;
            } while (i != 0);

            // Return true if count is odd, false otherwise
            return count % 2 == 1;
        }

        // The function that returns true if line segment 'p1q1'
        // and 'p2q2' intersect.
        static bool doIntersect(Point p1, Point q1, Point p2, Point q2)
        {
            // Find the four orientations needed for general and
            // special cases
            int o1 = orientation(p1, q1, p2);
            int o2 = orientation(p1, q1, q2);
            int o3 = orientation(p2, q2, p1);
            int o4 = orientation(p2, q2, q1);

            // General case
            if (o1 != o2 && o3 != o4)
                return true;

            // Special Cases
            // p1, q1 and p2 are colinear and p2 lies on segment p1q1
            if (o1 == 0 && onSegment(p1, p2, q1)) return true;

            // p1, q1 and p2 are colinear and q2 lies on segment p1q1
            if (o2 == 0 && onSegment(p1, q2, q1)) return true;

            // p2, q2 and p1 are colinear and p1 lies on segment p2q2
            if (o3 == 0 && onSegment(p2, p1, q2)) return true;

            // p2, q2 and q1 are colinear and q1 lies on segment p2q2
            if (o4 == 0 && onSegment(p2, q1, q2)) return true;

            return false; // Doesn't fall in any of the above cases
        }

        // To find orientation of ordered triplet (p, q, r).
        // The function returns following values
        // 0 --> p, q and r are colinear
        // 1 --> Clockwise
        // 2 --> Counterclockwise
        static int orientation(Point p, Point q, Point r)
        {
            int val = (q.y - p.y) * (r.x - q.x) -
                      (q.x - p.x) * (r.y - q.y);

            if (val == 0) return 0;  // colinear
            return (val > 0) ? 1 : 2; // clock or counterclock wise
        }

        // Given three colinear points p, q, r, the function checks if
        // point q lies on line segment 'pr'
        static bool onSegment(Point p, Point q, Point r)
        {
            if (q.x <= Math.Max(p.x, r.x) && q.x >= Math.Min(p.x, r.x) &&
                    q.y <= Math.Max(p.y, r.y) && q.y >= Math.Min(p.y, r.y))
                return true;
            return false;
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x; this.y = y;
        }
    }

    public class Polygon
    {
        public List<Point> Points {  get; set; }

        public Polygon()
        {
            Points = new List<Point>();
        }
    }
}
