﻿using System;

/// <summary>
/// Class named Queue
/// </summary>
class Queue<T>
{
    /// <summary>
    /// method that returns the queues type.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T value;
        public Node next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

        Node head;
        Node tail;
        int count;

        /// <summary>
        /// Method that creates a new node and adds it to the end of the queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            Node newNode = new Node(value);
            if(head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
                
            }
            count++;
        }
        /// <summary>
        /// Dequeue method. checks if queue is empty. removes first node in queue and returns its value.
        /// </summary>

        public void Dequeue()
        {
            if(head == null)
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            count --;
            Node node = head;
            head = node.next;
            return node.value;
        }

        /// <summary>
        /// Method that returns the number of nodes in a queue
        /// </summary>
        public int Count()
        {
            return count;
        }
    
}