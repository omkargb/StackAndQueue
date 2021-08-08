using System;

namespace StackAndQueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Stack and Queue implementation program \n");

            LinkedListStack stak = new LinkedListStack();
            //adding elements to stack
            Console.WriteLine(" Adding Elements to stack... - Last Element is 'TOP'.");
            stak.Push(70);
            stak.Push(30);
            stak.Push(56);
            stak.IsEmpty();
        }
    }
}
