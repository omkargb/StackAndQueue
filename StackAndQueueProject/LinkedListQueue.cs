using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueProject
{
    class LinkedListQueue
    {
        Node head;
        public void EnQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node newNode = head;
                while (newNode.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = node;
            }
            Console.WriteLine(" Element [" + node.data + "] inserted into the Queue.");
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine(" Queue is Empty... ");
            }
            else
            {
                Node newNode = head;
                while (newNode.next != null)
                {
                    Console.Write("\t"+ newNode.data);
                    newNode = newNode.next;
                }
                Console.Write("\t"+newNode.data);
            }
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine(" Queue is Empty... ");
            }
            else
            {
                Console.WriteLine("\n Element [" + head.data + "] Removed from the Queue.");
                head = head.next;
            }
        }
    }
}
