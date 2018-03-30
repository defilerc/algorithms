using HackerRank;
using HackerEarth.MarCircuits;
using HackerEarth.Graphs;
using System.Collections.Generic;
using HackerEarth.Disjoint;

public class Program
{
    static void Main(string[] args)
    {
        DisjointAlgo.Main(new string[0]);
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
