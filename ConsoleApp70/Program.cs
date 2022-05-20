using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesDelivered = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            int sum = 0;
            int racks = 1;

            for (int i = 0; i < clothesDelivered.Length; i++)
            {
                stack.Push(clothesDelivered[i]);
            }
            while (stack.Count > 0)
            {
                if (sum < rackCapacity)
                {
                    sum += stack.Peek();
                    if (sum > rackCapacity)
                    {
                        sum = 0;
                        racks++;
                        sum += stack.Peek();
                        stack.Pop();
                        continue;
                    }
                    stack.Pop();
                }
                else if (sum == rackCapacity)
                {
                    if (stack.Count != 0)
                    {
                        sum = 0;
                        racks++;
                        sum += stack.Peek();
                        stack.Pop();

                    }
                    
                }
               
            }

            Console.WriteLine(racks);
            
        }
    }
}
