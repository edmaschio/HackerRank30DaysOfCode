using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    class Program
    {
        public static Node insert(Node head, int data)
        {
            Node n = new Node(data);

            if (head == null)
                return n;
            else if (head.next == null)
                head.next = n;
            else
                insert(head.next, data);

            return head;
        }

        public static void display(Node head)
        {
            Node start = head;

            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);

            Console.ReadKey();
        }
    }
}
