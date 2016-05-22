using System;
using System.Collections.Generic;

class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

class Solution
{
    static void levelOrder(Node root)
    {
        //Write your code here
        Queue<Node> n = new Queue<Node>();
        n.Enqueue(root);

        while (n.Count > 0)
        {
            Node actual = n.Dequeue();
            Console.Write(actual.data + " ");

            if (actual.left != null) n.Enqueue(actual.left);
            if (actual.right != null) n.Enqueue(actual.right);
        }
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    static void Main(string[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        levelOrder(root);
    }
}
