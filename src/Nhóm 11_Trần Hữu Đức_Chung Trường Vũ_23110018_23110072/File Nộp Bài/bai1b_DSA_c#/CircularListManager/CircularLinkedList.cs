using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CircularListManager
{
    public class CircularLinkedList
    {
        private Node head;
        private ListBox listBox; // Tham chiếu đến ListBox hiển thị sản phẩm

        // Constructor
        public CircularLinkedList(ListBox listBox)
        {
            this.listBox = listBox;
            head = null;
        }

        // Kiểm tra danh sách rỗng
        public bool IsEmpty()
        {
            return head == null;
        }

        // Tạo một node mới
        public Node CreateNode(Product product)
        {
            return new Node(product);
        }

        // Cập nhật giao diện (ListBox)
        private void UpdateUI()
        {
            listBox.Items.Clear();

            if (IsEmpty())
            {
                listBox.Items.Add("The list is empty.");
                return;
            }

            Node temp = head;
            do
            {
                string productInfo = $"Name: {temp.Data.Name}, Price: {temp.Data.Price}";
                listBox.Items.Add(productInfo);
                temp = temp.Next;
            } while (temp != head);
        }

        // Thêm node vào đầu danh sách
        public void AddFirst(Node newNode)
        {
            if (IsEmpty())
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
            }
            else
            {
                Node tail = head.Prev;
                newNode.Next = head;
                newNode.Prev = tail;
                head.Prev = newNode;
                tail.Next = newNode;
                head = newNode;
            }
            UpdateUI();
        }

        // Thêm node vào cuối danh sách
        public void AddLast(Node newNode)
        {
            if (IsEmpty())
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
            }
            else
            {
                Node tail = head.Prev;
                newNode.Next = head;
                newNode.Prev = tail;
                tail.Next = newNode;
                head.Prev = newNode;
            }
            UpdateUI();
        }

        // Thêm node sau một node cụ thể
        public void AddAfter(Node newNode, string afterProductName)
        {
            if (IsEmpty())
            {
                MessageBox.Show("The list is empty.");
                return;
            }

            Node temp = head;
            do
            {
                if (temp.Data.Name == afterProductName)
                {
                    Node right = temp.Next;
                    temp.Next = newNode;
                    right.Prev = newNode;
                    newNode.Prev = temp;
                    newNode.Next = right;
                    UpdateUI();
                    return;
                }
                temp = temp.Next;
            } while (temp != head);
        }

        // Xóa node đầu tiên
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                MessageBox.Show("The list is empty.");
                return;
            }

            if (head.Next == head)
            {
                head = null;
            }
            else
            {
                Node tail = head.Prev;
                head = head.Next;
                head.Prev = tail;
                tail.Next = head;
            }
            UpdateUI();
        }

        // Xóa node cuối cùng
        public void RemoveLast()
        {
            if (IsEmpty())
            {
                MessageBox.Show("The list is empty.");
                return;
            }

            if (head.Next == head)
            {
                head = null;
            }
            else
            {
                Node tail = head.Prev;
                Node newTail = tail.Prev;
                newTail.Next = head;
                head.Prev = newTail;
            }
            UpdateUI();
        }

        // Xóa node sau một sản phẩm cụ thể
        public void RemoveAfter(string afterProductName)
        {
            if (IsEmpty())
            {
                MessageBox.Show("The list is empty.");
                return;
            }

            Node temp = head;
            do
            {
                if (temp.Data.Name == afterProductName)
                {
                    Node nodeToRemove = temp.Next;

                    if (nodeToRemove == head)
                    {
                        MessageBox.Show("No node exists after the specified product.");
                        return;
                    }

                    temp.Next = nodeToRemove.Next;
                    nodeToRemove.Next.Prev = temp;
                    UpdateUI();
                    return;
                }
                temp = temp.Next;
            } while (temp != head);

            MessageBox.Show("The product to remove after was not found.");
        }

        // Tìm kiếm node theo tên sản phẩm
        public Node SearchNode(string productName)
        {
            if (IsEmpty())
            {
                MessageBox.Show("The list is empty.");
                return null;
            }

            Node temp = head;
            do
            {
                if (temp.Data.Name == productName)
                {
                    return temp;
                }
                temp = temp.Next;
            } while (temp != head);

            MessageBox.Show($"Product '{productName}' not found.");
            return null;
        }
        //selection sort 
        public void SelectionSort()
        {
            if (head == null) return;

            CircularLinkedList sortedList = new CircularLinkedList(listBox);

            while (head != null)
            {
                Node min = head;
                Node current = head.Next;

                // find the min node
                while (current != head)
                {
                    if (min.Data.Price > current.Data.Price)
                    {
                        min = current;
                    }
                    current = current.Next;
                }
                // throw this node to other list
                RemoveNode(min);
                sortedList.AddLast(min);
            }
            // update
            this.head = sortedList.head;
        }
        // removenode
        public void RemoveNode(Node nodeToRemove)
        {
            if (IsEmpty() || nodeToRemove == null) return;


            if (nodeToRemove == head)
            {
                RemoveFirst();
            }

            else if (nodeToRemove == head.Prev)
            {
                RemoveLast();
            }
            else
            {
                nodeToRemove.Prev.Next = nodeToRemove.Next;
                nodeToRemove.Next.Prev = nodeToRemove.Prev;
            }
        }

        // quicksort
        private int distance(Node p)
        {
            int count = 0;
            for (Node i = head; i != p; i = i.Next) count++;
            return count;
        }

        private Node back(int step)
        {
            Node runner = head;
            for (int i = 1; i <= step; i++) runner = runner.Next;
            return runner;
        }
        private Node Partition(Node low, Node high)
        {
            Node pivot = high;
            Node i = low;
            while (i != pivot)
            {
                if (i.Data.Price < pivot.Data.Price)
                {
                    Node j = i.Next;
                    RemoveNode(i);
                    AddAfter(i, pivot.Data.Name);
                    i = j;
                }
                else i = i.Next;
            }

            return pivot;
        }

        public void QuickSortRecursive(Node low, Node high)
        {

            if (low != high)
            {
                if (low.Next == high && low.Data.Price > high.Data.Price) return; // loại trường hợp kề đúng vị trí 4 3
                int dislow = distance(low);
                int dishigh = distance(high);
                Node pivot = Partition(low, high);
                low = back(dislow);
                high = back(dishigh);
                if (pivot != high)
                {
                    QuickSortRecursive(low, pivot);
                    QuickSortRecursive(pivot.Next, high);
                }
                else
                {
                    pivot = pivot.Prev;
                    QuickSortRecursive(low, pivot);
                    QuickSortRecursive(pivot.Next, high);
                }
            }
        }
        public void QuickSort()
        {

            if (head == null) return;

            Node tail = head.Prev;
            QuickSortRecursive(head, tail);
        }
        // Lấy danh sách dưới dạng chuỗi
        public List<string> GetListAsString()
        {
            List<string> productStrings = new List<string>();
            Node current = head;  // head là nút đầu tiên trong CircularLinkedList
            if (current != null)
            {
                do
                {
                    productStrings.Add(current.Data.ToString());  // Chuyển đổi Product thành chuỗi
                    current = current.Next;  // Di chuyển đến nút kế tiếp
                } while (current != head);  // Duy trì vòng tròn
            }
            return productStrings;
        }
        // Reverse the list
        public void ReverseList()
        {
            CircularLinkedList otherList = new CircularLinkedList(listBox);
            if (IsEmpty()) return;
            Node runner = head;
            do
            {
                Node tmp = runner.Next;
                RemoveNode(runner);
                otherList.AddFirst(runner);
                runner = tmp;
            }
            while (!IsEmpty());
            head = otherList.head;
        }
        // Merge 2 lists
        public void MergeSortedLists(CircularLinkedList otherList)
        {
            if (otherList.IsEmpty()) return; // other list is empty

            if (this.IsEmpty())// this list is empty
            {
                this.head = otherList.head;
                return;
            }
            // 2 list is not empty
            Node tail = this.head.Prev;
            Node othertail = otherList.head.Prev;

            tail.Next = otherList.head;
            otherList.head.Prev = tail;
            othertail.Next = head;
            head.Prev = othertail;
        }
        // remove all nodes satisfying a specific criteria
        public void RemoveNodesByCondition(Func<Product, bool> condition)
        {
            if (IsEmpty()) return;
            CircularLinkedList otherList = new CircularLinkedList(listBox);
            Node current = head;

            do
            {
                if (condition(current.Data))
                {

                    current = current.Next;
                }
                else
                {

                    Node tmp = current.Next;
                    RemoveNode(current);
                    otherList.AddFirst(current);
                    current = tmp;
                }
            } while (!IsEmpty() && current != head);
            head = otherList.head;
        }

        public void InitializeList(List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                MessageBox.Show("Product list cannot be empty.");
                return;
            }

            foreach (var product in products)
            {
                AddLast(CreateNode(product)); // Thêm sản phẩm vào cuối danh sách
            }

            MessageBox.Show("Product list has been initialized.");
        }
        public void Clear()
        {
            head = null;
            UpdateUI();  // Cập nhật lại giao diện nếu cần
        }

    }
}
