using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<int> Q = new();
        Q.Enqueue(5);
        Q.Enqueue(11);
        Q.Enqueue(6);
        Q.Enqueue(9);
        Q.Enqueue(3);

        Console.WriteLine(IsMagic(new Queue<int>(Q), 1));
        Console.WriteLine(IsMagic(new Queue<int>(Q), 2));
    }

    public static bool IsMagic(Queue<int> Q1, int m)
    {
        Queue<int> q = Q1;
        if (m < 1 || m > q.Count) return false;


        for (int i = 0; i < m; i++)
        {
            q.Dequeue();
        }

        int MMinus1 = q.Dequeue();
        int M = q.Dequeue();
        int MPlus1 = q.Dequeue();
        return MPlus1 + MMinus1 == M;
    }
    public static bool NMagic(Queue<int> q, int n)
    {
        while (n < q.Count)
        {
            if (!IsMagic(q, n))
            {
                return false;
            }
            n += n;
        }
        return true;
    }
}
