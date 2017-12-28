using System.Collections.Generic;
using System.Linq;

namespace Daily
{
    public class ArithmeticPredicate
    {
        public bool arithmeticPredicate(string p) {
            var e = p.Split('=');
            
            return E(e[0].Trim()) == E(e[1].Trim());
        }

        int E(string e) {
            var s = e.Split(' ');
            var o = "+-/*";
            var n = new Stack<int>();
            var p = new Stack<string>();

            foreach (var t in s) {
                if (t == "(") {
                    p.Push(t);
                } else if (t == ")") {
                    while (p.Peek() != "(") {
                        D(p, n);
                    }
                    p.Pop();
                } else if (o.Contains(t)) {
                    while (p.Count > 0 &&
                           o.IndexOf(p.Peek()) >= o.IndexOf(t)) {
                        D(p, n);
                    }
                    p.Push(t);
                } else {
                    n.Push(int.Parse(t));
                }
            }

            while (p.Count > 0) {
                D(p, n);
            }

            return n.Pop();
        }

        void D(Stack<string> o, Stack<int> v) {
            var p = o.Pop();
            int b = v.Pop(), a = v.Pop();

            v.Push(p == "*" ? a * b : p == "/" ? a / b : p == "+" ? a + b : a - b);

            if (p == "*") {
                v.Push(a * b);
            } 
            if (p == "/") {
                v.Push(a / b);
            } 
            if (p == "+") {
                v.Push(a + b);
            } 
            if (p == "-") {
                v.Push(a - b);
            }
        }
    }
}
