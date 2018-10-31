using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    static int Main(string[] args)
    {
            var c = "[bcdfghjklmnpqrstvxwz]+";
            var l = new [] {"Chruschtschov",  "Hristo",  "Nguyen",  "Dmitry",  "Madchen",  "Fujiyama",  "Connor" };

            int z = 0;
            foreach (var s in l) {

                int x = 0;
                var m = Regex.Matches(s.ToLower(), c);

                foreach (Match a in m) {
                    x += 1 << a.Length - 1;
                }
                
                z += (5 + x);
            }

            return z;

    }
}

class Solution
{
    private Stack<char> s = new Stack<char>();
    private Queue<char> q = new Queue<char>();

    void pushCharacter(char ch) => s.Push(ch);
    char popCharacter(char ch) => s.Pop();

    void enqueueCharacter(char ch) => q.Enqueue(ch);
    char dequeueCharacter(char ch) => q.Dequeue();
}

public class UVa725
{
    public static void CompleteSearch()
    {
        var N = 2;

        for (int fghij = 1234; fghij <= 98765 / N; fghij++) {
            int abcde = fghij * N; // this way, abcde and fghij are at most 5 digits
            int tmp, used = (fghij < 10000) ? 1 : 0; // if digit f=0, then we have to flag it
            tmp = abcde; while (tmp > 0) { used |= 1 << (tmp % 10); tmp /= 10; }
            tmp = fghij; while (tmp > 0) { used |= 1 << (tmp % 10); tmp /= 10; }
            if (used == (1 << 10) - 1) // if all digits are used, print it
                System.Console.WriteLine($"{abcde:00000} / {fghij:00000} = {N}");
        }
    }
}
