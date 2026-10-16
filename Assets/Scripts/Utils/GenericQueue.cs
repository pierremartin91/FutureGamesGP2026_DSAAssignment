using NUnit.Framework;
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Utils
    {
    [Serializable]
    public class GenericQueue<T> {
        public List<T> queue;

        public GenericQueue() {
            queue = new List<T>();
        }

        public void Enqueue(T item) {
            queue.Add(item);
        }

        public T Peek() {
            if (queue.Count == 0) {
                throw new Exception("Queue is empty, cannot peak");
            }

            return queue[0];
        }

        public T Dequeue() {
            if (queue.Count == 0) {
                throw new Exception("Queue is empty, cannot dequeue");
            }

            T topOfQueue = queue[0];
            queue.RemoveAt(0);

            return topOfQueue;
        }

        public void Clear() {
            queue.Clear();
        }
    }
}

