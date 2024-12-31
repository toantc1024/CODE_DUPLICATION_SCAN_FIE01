using System;
using System.Collections.Generic;
namespace Circular_linked_list
{
    public class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList list = new CircularLinkedList();

            Console.WriteLine("=== Kiem tra ham AddFirst ===");
            list.Init();
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
            Console.WriteLine("Danh sach sau khi them dau: ");
            list.PrintList();

            Console.WriteLine("\n=== Kiem tra ham AddLast ===");
            list.AddLast(40);
            list.AddLast(50);
            Console.WriteLine("Danh sach sau khi them cuoi: ");
            list.PrintList();

            Console.WriteLine("\n=== Kiem tra ham RemoveFirst ===");
            list.RemoveFirst();
            Console.WriteLine("Danh sach sau khi xoa dau: ");
            list.PrintList();

            Console.WriteLine("\n=== Kiem tra ham RemoveLast ===");
            list.RemoveLast();
            Console.WriteLine("Danh sach sau khi xoa cuoi: ");
            list.PrintList();

            Console.WriteLine("\n=== Kiem tra ham SearchNode ===");
            var node = list.SearchNode(20);
            Console.WriteLine(node != null ? $"Tim thay node co gia tri: {node.info}" : "Khong tim thay node.");

            Console.WriteLine("\n=== Kiem tra ham SearchNodes ===");
            var nodes = list.SearchNodes(25, 3); // Tim cac node lon hon 25
            Console.WriteLine("Cac node co gia tri lon hon 25:");
            foreach (var n in nodes)
            {
                Console.Write(n.info + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\n=== Kiem tra ham RemoveNodes ===");
            list.RemoveNodes(20, 1); // Xoa tat ca node co gia tri bang 20
            Console.WriteLine("Danh sach sau khi xoa cac node co gia tri bang 20:");
            list.PrintList();

            Console.WriteLine("\n=== Kiem tra ham FindMaxNode ===");
            var maxNode = list.FindMaxNode();
            Console.WriteLine(maxNode != null ? $"Node lon nhat: {maxNode.info}" : "Danh sach rong.");

            Console.WriteLine("\n=== Kiem tra ham SelectionSort ===");
            list.AddLast(30);
            list.AddLast(10);
            list.AddLast(40);
            list.AddLast(20);
            Console.WriteLine("Danh sach truoc khi sap xep:");
            list.PrintList();
            list.SelectionSort();

            Console.WriteLine("\n=== Kiem tra ham MergeTwoLists ===");
            CircularLinkedList list2 = new CircularLinkedList();
            list2.AddFirst(5);
            list2.AddFirst(15);
            list2.AddFirst(25);
            Console.WriteLine("Danh sach 1:");
            list.PrintList();
            Console.WriteLine("Danh sach 2:");
            list2.PrintList();
            CircularLinkedList mergedList = list.MergeTwoLists(list, list2);
            Console.WriteLine("Danh sach sau khi gop:");
            mergedList.PrintList();

            Console.WriteLine("\n=== Ket thuc kiem tra ===");
            Console.Read();

        }
    }
}
