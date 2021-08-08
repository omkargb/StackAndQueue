using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueProject
{
    public class LinkedListStack
    {
        Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.Write(" [" + node.data + "] →");
        }
    }
}