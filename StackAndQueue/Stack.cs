using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Stack
    {
        internal Node head;
        internal void Push(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} is inserted into stack", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        internal void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            this.head = this.head.next;
        }
        public void Peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Peek element is :" + this.head.data);
            }
        }
    }
}
