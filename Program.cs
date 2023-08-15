using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            StacksEvent stack = new StacksEvent(10);

            for (int i = 0; i < 3; i++)
            {
                stack.Push("Squirtle");
                stack.Push("Pickachu");
                stack.Push("Charmander");
            }
            stack.Pop();
            // used to see the value/item at the top
            Console.WriteLine("Word at top: " + stack.Peek());
            while (!stack.isEmpty())
            {
                var value = stack.Pop();
                Console.WriteLine(value);
            }
             /// ********N.B we can also use ther microsoft version of stacvks which will make the StackEvent class useless since it will do all the work for us
        }
    }
}
