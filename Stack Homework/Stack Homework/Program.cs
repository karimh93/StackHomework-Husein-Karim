using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

           
            Console.WriteLine($"The first element is:{stack.Peek()}");

            

            var laststack = stack.Last();

            Console.WriteLine($"The last element is:{ laststack}");

            
            


        }
    }
}
