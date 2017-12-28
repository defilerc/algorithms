using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.HeapStackQueue
{
    public class SimplifyPath
    {
        public string simplifyPath(string path)
        {
            var splitted = path.Split('/');
            var simple = new Stack<string>();

            foreach (var value in splitted) {
                if (value == ".." && simple.Any()) {
                    simple.Pop();
                } else if (value != "." && !string.IsNullOrWhiteSpace(value)) {
                    simple.Push(value);
                }
            }

            var simplePath = new StringBuilder();
            foreach (var value in simple) {
                simplePath.Insert(0, $"/{value}");
            }

            return simple.Any() ? simplePath.ToString() : "/";
        }
    }
}
