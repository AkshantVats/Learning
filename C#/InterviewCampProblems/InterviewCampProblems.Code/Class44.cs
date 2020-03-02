/*
Implement a data structure for a Least Recently Used (LRU) cache.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{
    public class LRUCache<K, V>
    {
        Dictionary<K, Node<K, V>> map;

        Node<K, V> head;
        Node<K, V> tail;

        int capacity;


        public LRUCache(int capacity)
        {
            this.map = new Dictionary<K, Node<K, V>>();
            this.capacity = capacity;

        }

        public V Read(K key)
        {
            var node = map.GetValueOrDefault(key);
            if (node == null)
            {
                return default(V);
            }

            Remove(key);
            Add(node.GetKey(), node.GetValue());
            return node.GetValue();
        }

        public void Write(K key, V value)
        {
            if (map.Count == capacity)
            {
                Remove(head.GetKey());
            }

            Add(key, value);

        }

        private void Remove(K Key)
        {
            if (!map.ContainsKey(Key))
            {
                return;
            }

            var toRemove = map.GetValueOrDefault(Key);
            RemoveFromLinkedList(toRemove);
            map.Remove(Key);
        }

        private void Add(K key, V value)
        {
            Node<K, V> nodeToAdd = new Node<K, V>(key, value);
            AppendToLinkedList(nodeToAdd);
            map.Add(key, nodeToAdd);
        }


        public void AppendToLinkedList(Node<K, V> toAdd)
        {

            if (head == null)
            {
                head = toAdd;
            }

            else
            {
                tail.SetNext(toAdd);
                toAdd.SetPrevious(tail);
            }

            tail = toAdd;

        }

        public void RemoveFromLinkedList(Node<K, V> toRemove)
        {
            if (toRemove.GetPrevious() != null)
            {
                toRemove.GetPrevious().SetNext(toRemove.GetNext());
            }

            if (toRemove.GetNext() != null)
            {
                toRemove.GetNext().SetPrevious(toRemove.GetPrevious());
            }

            if (toRemove == head)
            {
                head = toRemove.GetNext();
            }

            if (toRemove == tail)
            {
                tail = toRemove.GetPrevious();
            }
        }

        public V[] ToArray()
        {
            return map.Values.Select(a => a.GetValue()).ToArray();

        }
    }

    public class Node<K, V>
    {
        Node<K, V> next;
        Node<K, V> prev;

        K key;
        V value;

        public Node(K key, V value)
        {
            this.key = key;
            this.value = value;
        }
        public Node<K, V> GetNext()
        {
            return next;
        }

        public Node<K, V> GetPrevious()
        {
            return prev;
        }

        public void SetNext(Node<K, V> next)
        {
            this.next = next;
        }

        public void SetPrevious(Node<K, V> prev)
        {
            this.prev = prev;
        }

        public K GetKey()
        {
            return key;
        }
        public V GetValue()
        {
            return value;
        }

    }


}