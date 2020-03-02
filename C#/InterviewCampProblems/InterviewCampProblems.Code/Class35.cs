/*
Linked List Implementation
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{

    public class LinkedList
    {
        Node head;

        public LinkedList(Node head)
        {
            this.head = head;
        }

        public LinkedList()
        {
            this.head = null;
        }

        public Node GetHead()
        {
            return head;
        }
        public void SetHead(Node head)
        {
            this.head = head;
        }

        public Node GetNode(int n)
        {
            Node node = head;
            for (int i = 0; i < n - 1; i++)
            {
                // move forward n-1 times
                if (node != null)
                    node = node.GetNext();
                else { throw new IndexOutOfRangeException("No node at index " + n); }
            }
            if (node == null)
            {
                throw new IndexOutOfRangeException("No node at index " + n);
            }
            return node;
        }

        public void SetNodeData(int n, int data)
        {
            var node = GetNode(n);
            node.SetData(data);
        }

        public void InsertNode(int n, Node node)
        {
            var previousNode = GetNode(n);
            var nextNode = previousNode.GetNext();
            node.SetNext(nextNode);
            previousNode.SetNext(node);
        }

        public Node GetLastNode()
        {
            var current = GetHead();
            while (current != null && current.GetNext() != null)
            {
                current = current.GetNext();
            }
            return current;
        }

        public void AppendNode(Node node)
        {
            var item = new Node(null, node.GetData());
            var lastNode = GetLastNode();
            if (lastNode == null)
            {
                SetHead(item);
            }
            else
            {
                lastNode.SetNext(item);
            }
        }

        public void AppendLinkedList(Node node)
        {
            var lastNode = GetLastNode();
            if (lastNode == null)
            {
                SetHead(node);
            }
            else
            {
                lastNode.SetNext(node);
            }
        }

        public void AppendNodes(List<Node> nodes)
        {
            var lastNode = GetLastNode();
            if (lastNode == null)
            {
                var item = new Node(null, nodes[0].GetData());
                SetHead(item);
                lastNode = item;
            }
            foreach (var node in nodes.Skip(1))
            {
                var item = new Node(null, node.GetData());
                lastNode.SetNext(item);
                lastNode = item;
            }

        }

        public void RemoveNode(int n)
        {
            if (n == 1)
            {
                RemoveHead();
                return;
            }
            var nodeToRemove = GetNode(n);
            var previousNode = GetNode(n - 1);
            previousNode.SetNext(nodeToRemove.GetNext());
        }

        public void RemoveHead()
        {
            var node = GetHead();
            if (node != null)
            {
                var nextNode = node.GetNext();
                SetHead(nextNode);
                node.SetNext(null);
            }
        }

        public int[] ToArray()
        {
            Node node = head;
            List<int> result = new List<int>();
            while (node != null)
            {
                result.Add(node.GetData());
                node = node.GetNext();
            }
            return result.ToArray();
        }
    }

    public class Node
    {
        Node next;
        int data;

        public Node(Node next, int data)
        {

            this.next = next;
            this.data = data;
        }
        public Node GetNext()
        {
            return next;
        }

        public void SetNext(Node next)
        {
            this.next = next;
        }

        public int GetData()
        {
            return data;
        }

        public void SetData(int data)
        {
            this.data = data;
        }
    }

}