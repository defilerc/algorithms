using System;
using System.Linq;

namespace Daily.Jan
{
    public class HitmanAlgo
    {
        public string hitman(string[] people)
        {
            var l = people.ToList();

            while (l.Count > 1) {
                l.RemoveAt(0);
                l.Insert(l.Count, l[0]);
                l.RemoveAt(0);
            }

            return l[0];
        }

        public string hitmanShort(string[] p)
        {
            int i = p.Length, f = (int) Math.Pow(2, Math.Floor(Math.Log(i, 2)));

            return i == f ? p[f - 1] : p[2 * (i - f) - 1];
        }
    }
}
