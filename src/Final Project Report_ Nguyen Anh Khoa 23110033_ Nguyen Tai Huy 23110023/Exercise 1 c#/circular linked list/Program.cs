using System;
using CircularLinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the Circular Linked List
        CirLinkedList list1 = new CirLinkedList();
        CirLinkedList list2 = new CirLinkedList();

        // Add some nodes to the list1
        list1.AddNode(10);
        list1.AddNode(20);
        list1.AddNode(30);

        // Add some nodes to the list2
        list2.AddNode(40);
        list2.AddNode(50);

        // Main menu loop
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Circular Linked List Operations:");
            Console.WriteLine("1. Display List");
            Console.WriteLine("2. Add Node at Beginning");
            Console.WriteLine("3. Add Node at End");
            Console.WriteLine("4. Add Node After a Specific Node");
            Console.WriteLine("5. Delete First Node");
            Console.WriteLine("6. Delete Last Node");
            Console.WriteLine("7. Delete Node After a Specific Node");
            Console.WriteLine("8. Search for a Node");
            Console.WriteLine("9. Selection Sort");
            Console.WriteLine("10. QuickSort");
            Console.WriteLine("11. Merge with Another List");
            Console.WriteLine("12. Remove Nodes by Condition");
            Console.WriteLine("13. Reverse the List");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("\nCurrent List:");
                    list1.Display();
                    break;
                case "2":
                    Console.Write("Enter value to add at beginning: ");
                    int valueBegin = Convert.ToInt32(Console.ReadLine());
                    list1.AddNodeAtBeginning(valueBegin);
                    break;
                case "3":
                    Console.Write("Enter value to add at end: ");
                    int valueEnd = Convert.ToInt32(Console.ReadLine());
                    list1.AddNodeAtEnd(valueEnd);
                    break;
                case "4":
                    Console.Write("Enter node value to add after: ");
                    int nodeValue = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter value to insert after node: ");
                    int newValue = Convert.ToInt32(Console.ReadLine());
                    list1.AddNodeAfterNode(nodeValue, newValue);
                    break;
                case "5":
                    list1.DeleteFirstNode();
                    break;
                case "6":
                    list1.DeleteLastNode();
                    break;
                case "7":
                    Console.Write("Enter node value to delete after: ");
                    int deleteAfterValue = Convert.ToInt32(Console.ReadLine());
                    list1.DeleteNodeAfterNode(deleteAfterValue);
                    break;
                case "8":
                    Console.Write("Enter value to search for: ");
                    int searchValue = Convert.ToInt32(Console.ReadLine());
                    list1.SearchNode(searchValue);
                    break;
                case "9":
                    list1.SelectionSort();
                    break;
                case "10":
                    Console.WriteLine("\nBefore QuickSort:");
                    list1.Display();
                    list1.QuickSort();
                    Console.WriteLine("\nAfter QuickSort:");
                    list1.Display();
                    break;
                case "11":
                    list1.Merge(list2);
                    Console.WriteLine("\nAfter Merging with List 2:");
                    list1.Display();
                    break;
                case "12":
                    Console.WriteLine("\nSelect a condition for removal:");
                    Console.WriteLine("1. Remove nodes with value less than a specific value");
                    Console.WriteLine("2. Remove nodes with value greater than a specific value");
                    Console.Write("Choose condition: ");
                    string conditionChoice = Console.ReadLine();
                    Console.Write("Enter value to compare: ");
                    int conditionValue = Convert.ToInt32(Console.ReadLine());

                    if (conditionChoice == "1")
                    {
                        list1.RemoveNodesCondition(x => x < conditionValue);
                    }
                    else if (conditionChoice == "2")
                    {
                        list1.RemoveNodesCondition(x => x > conditionValue);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                    break;
                case "13":
                    list1.Reverse();
                    Console.WriteLine("\nAfter Reversing the List:");
                    list1.Display();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice, please try again.");
                    break;
            }

            // Wait before displaying the menu again
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
