using System;
using System.Collections.Generic;
using System.Linq;

namespace Daily
{
    public class Roadmap
    {
        public string[][] roadmap(string[][] tasks, string[][] queries)
        {
            var output = new List<string[]>();

            foreach (var query in queries) {
                var ptasks = tasks
                    .Where(t => t.Contains(query[0]) &&
                        DateTime.Parse(t[1]) <= DateTime.Parse(query[1]) &&
                        DateTime.Parse(query[1]) <= DateTime.Parse(t[2]))
                    .OrderBy(t => t[2])
                    .ThenBy(t => t[0])
                    .Select(t => t[0])
                    .ToArray();

                output.Add(ptasks);
            }

            return output.ToArray();
        }
    }
}
