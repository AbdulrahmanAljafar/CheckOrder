using System;
using System.Collections.Generic;

namespace CheckOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkOrder("1234554321"));
            Console.WriteLine(checkOrder("9595"));
            Console.WriteLine(checkOrder("89339998"));
        }

        static bool checkOrder(string value)
        {
            Stack<char> stack = new Stack<char>();
            for(int i = 0;i< value.Length;i++)
            {
                if (stack.ToArray().Length == 0 || value[i] != stack.Peek())
                {
                    stack.Push(value[i]);
                }
                else
                {
                    stack.Pop();
                }
               
            }
            if (stack.ToArray().Length == 0)
            {
                return true;
            }
            return false;
        }
    }
}
