using System.Collections.Generic;
using HackerEarth.CodeMonk.Checkpoint2;
using HackerEarth.Graphs;
using HackerEarth.PriorityQueue;

public class Program
{
    static void Main(string[] args)
    {
        //MaxInQueueAlgo.Main(new string[0]);
        BellmanFord.Main(new string[0]);
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
