using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Daily
{
    public class CountAPI
    {
        public string[] countAPI(string[] calls)
        {
            var tree = new ApiTree();

            foreach (var call in calls) {
                var match = Regex.Match(call, "/(.*?)/(.*?)/(.*)", RegexOptions.None);

                Insert(tree, "", "", match.Groups[1].Value, 1);
                Insert(tree, match.Groups[1].Value, "", match.Groups[2].Value, 2);
                Insert(tree, match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value, 3);
            }

            var output = new List<string>();
            Print(tree, ref output, 1);
            return output.ToArray();
        }

        private void Insert(ApiTree tree, string project, string subproject, string title, int level)
        {
            ApiTree leaf;

            if (level == 1) {
                leaf = tree;
            } else if (level == 2) {
                leaf = tree.Children.Single(t => t.Title == project);
            } else {
                leaf = tree.Children.Single(t => t.Title == project)
                    .Children.Single(t => t.Title == subproject);
            }

            foreach (var child in leaf.Children) {
                    if (child.Title == title) {
                        child.Count++;
                        return;
                    }
                }

            leaf.Children.Add(new ApiTree {Count = 1, Title = title});
        }

        private void Print(ApiTree tree, ref List<string> output, int level)
        {
            foreach (var child in tree.Children) {
                output.Add($"{string.Concat(Enumerable.Repeat("--", level))}{child.Title} ({child.Count})");
                Print(child, ref output, level + 1);
            }
        }

        public class ApiTree
        {
            public string Title { get; set; }

            public int Count { get; set; }

            public List<ApiTree> Children { get; set; }

            public ApiTree()
            {
                Children = new List<ApiTree>();
            }
        }

    }
}

