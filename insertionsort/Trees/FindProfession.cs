using System;

namespace AlgoTests.Trees
{
    public class FindProfession
    {
        public string findProfession(int level, int pos)
        {
            var parentPos = default(decimal);
            var travelRight = 0;

            while (level > 1) {
                if (pos % 2 == 0) {
                    travelRight++;
                }

                parentPos = Math.Ceiling( (decimal)pos / 2);

                pos = (int)parentPos;
                level--;
            }

            return (travelRight % 2 == 0)
                ? "Engineer"
                : "Doctor";
        }

    }
}
