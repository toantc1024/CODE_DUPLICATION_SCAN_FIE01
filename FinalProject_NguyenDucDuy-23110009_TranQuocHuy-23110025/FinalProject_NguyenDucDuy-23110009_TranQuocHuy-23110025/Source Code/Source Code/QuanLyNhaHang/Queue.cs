using System;
using System.Collections;
using System.Collections.Generic;

namespace DSA
{
    public class Queue<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head; // Điểm đầu của hàng đợi
        private Node tail;  // Điểm cuối của hàng đợi
        private int count;  // Số lượng phần tử trong hàng đợi

        public int Count => count; // Lấy số lượng phần tử trong hàng đợi

        public Queue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // Thêm phần tử vào hàng đợi
        public void Enqueue(T item)
        {
            var newNode = new Node(item);

            if (tail == null)
            {
                // Hàng đợi rỗng
                head = newNode;
                tail = newNode;
            }
            else
            {
                // Thêm vào cuối
                tail.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        // Lấy phần tử đầu tiên khỏi hàng đợi
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Hàng đợi rỗng.");
            }

            var data = head.Data;
            head = head.Next;

            if (head == null)
            {
                tail = null; // Nếu hàng đợi rỗng, cập nhật rear
            }

            count--;
            return data;
        }

        // Kiểm tra hàng đợi có rỗng không
        public bool IsEmpty()
        {
            return count == 0;
        }

        // Xem phần tử đầu tiên trong hàng đợi mà không xóa nó
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Hàng đợi rỗng.");
            }

            return head.Data;
        }

        // Triển khai giao diện IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        // Triển khai giao diện IEnumerable (không kiểu)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
