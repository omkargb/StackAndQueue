using System;

namespace StackAndQueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Stack and Queue implementation program \n");

            LinkedListQueue llqueue = new LinkedListQueue();

            //add elements to queue -- enqueue
            llqueue.EnQueue(56);
            llqueue.EnQueue(30);
            llqueue.EnQueue(70);

            //dispaly queue elements
            Console.Write(" Queue elements : [Top] →");
            llqueue.Display();

            //remove first added element
            llqueue.Dequeue();
            llqueue.Display();

            //adding elements to stack
            //Console.WriteLine(" Adding Elements to stack... - Last Element is 'TOP'.");
            //stak.Push(70);
            //stak.Push(30);
            //stak.Push(56);
            //stak.IsEmpty();
        }
    }
}
