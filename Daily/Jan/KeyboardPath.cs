using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Daily.Jan
{
    public class TypingDinstanceAlgo
    {
        public int typingDistance(string[] keyboard, string message)
        {
            if (message == "") { // can be removed, can be caught by FindStart
                return 0;
            }

            message = Regex.Replace(message, "[A-Z]", m => "^" + m.ToString().ToLower());

            var start = FindStart(keyboard, message[0]);

            if (start.X == -1 && start.Y == -1) { // check only X or Y
                return 0;
            }

            int matched = 1, totalDistance = 0;
            var queue = new List<Coord>(new [] {start});

            while (matched != message.Length) {
                for (var i = 0; i < queue.Count; i++) {
                    var distance = ExploreAdjacentNodes(queue, i, queue[i].C, keyboard, message[matched], out var target);
                    if (distance > 0) {
                        queue.Clear();
                        target.C = 0;
                        queue.Add(target);

                        totalDistance += distance;
                        matched++;
                    }
                }
            }

            return totalDistance;
        }

        private int ExploreAdjacentNodes(List<Coord> queue, int i, int count, string[] keyboard, char message, out Coord target)
        {
            // check adj node if out of bounds
            var up = new Coord {Y = queue[i].Y - 1, X = queue[i].X, C = count + 1}; 
            var down = new Coord {Y = queue[i].Y + 1, X = queue[i].X, C = count + 1}; 
            var left = new Coord {Y = queue[i].Y, X = queue[i].X - 1, C = count + 1}; 
            var right = new Coord {Y = queue[i].Y, X = queue[i].X + 1, C = count + 1};

            foreach (var dir in new[] { up, down, left, right }) {

                if (!OutOfBounds(dir, keyboard) && !ExistsBetter(dir, queue)) {
                    if (message == keyboard[dir.Y][dir.X]) {
                        target = dir;
                        return dir.C;
                    }

                    queue.Add(dir);
                }
            }

            target = null;
            return 0;
        }

        private bool ExistsBetter(Coord dir, List<Coord> queue)
        {
            return queue.Exists(q => q.X == dir.X && q.Y == dir.Y && q.C <= dir.C);
        }

        private bool OutOfBounds(Coord dir, string[] keyboard)
        {
            if (dir.Y < 0 || dir.Y >= keyboard.Length || dir.X < 0 || dir.X >= keyboard[dir.Y].Length) {
                return true;
            }

            return false;
        }

        Coord FindStart(string[] keyboard, char c) {
            for (var i = 0; i < keyboard.Length; i++) {
                if (keyboard[i].Contains(c)) {
                    return new Coord { Y = i, X = keyboard[i].IndexOf(c) };

                }
            }

            return new Coord { Y = -1, X = -1 };
        }

        public class Coord
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int C { get; set; } // count

            public override string ToString()
            {
                return $"X = {X}, Y = {Y}, C = {C}";
            }
        }
    }
}