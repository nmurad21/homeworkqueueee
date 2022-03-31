using System;
using System.Collections.Generic;

namespace homeworkqueueee
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> queue = new Stack<string>();
            queue.Push("Salam");
            queue.Push("234");
            queue.Push("Malas");
            queue.Push("Hello");
            queue.Push("qwert");
            queue.Push("zxcv");
            queue.Push("uiop");
            queue.Push("luyrt");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
