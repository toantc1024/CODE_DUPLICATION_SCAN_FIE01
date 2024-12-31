using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_2
{
    public class Menu
    {
        public static void DisplayMenu(CircularLinkedList list)
        {
            int choice, subChoice, value, target, n;

            do
            {
                Console.Clear();
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Check if the list is empty");
                Console.WriteLine("2. Add nodes to the list");
                Console.WriteLine("3. Print the list");
                Console.WriteLine("4. Insert node");
                Console.WriteLine("5. Remove node");
                Console.WriteLine("6. Search node");
                Console.WriteLine("7. Sort the list (Selection Sort)");
                Console.WriteLine("8. Operations on the list");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Is list empty? " + (list.IsEmpty() ? "Yes" : "No"));
                        WaitForKeyPress();
                        break;
                    case 2:
                        Console.Write("Enter the number of nodes to add: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write($"Enter value for node {i + 1}: ");
                            value = int.Parse(Console.ReadLine());
                            list.InsertAtEnd(value);
                        }
                        WaitForKeyPress();
                        break;
                    case 3:
                        Console.Write("Linked List: ");
                        list.PrintList();
                        WaitForKeyPress();
                        break;
                    case 4:
                        Console.WriteLine("\nInsert Node:");
                        Console.WriteLine("1. Insert at the beginning");
                        Console.WriteLine("2. Insert at the end");
                        Console.WriteLine("3. Insert after a specific node");
                        Console.Write("Enter your choice: ");
                        subChoice = int.Parse(Console.ReadLine());

                        switch (subChoice)
                        {
                            case 1:
                                Console.Write("Enter value to insert at the beginning: ");
                                value = int.Parse(Console.ReadLine());
                                list.InsertAtBeginning(value);
                                break;
                            case 2:
                                Console.Write("Enter value to insert at the end: ");
                                value = int.Parse(Console.ReadLine());
                                list.InsertAtEnd(value);
                                break;
                            case 3:
                                Console.Write("Enter target node value: ");
                                target = int.Parse(Console.ReadLine());
                                Console.Write($"Enter value to insert after {target}: ");
                                value = int.Parse(Console.ReadLine());
                                list.InsertAfterNode(value, target);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Returning to main menu.");
                                break;
                        }
                        WaitForKeyPress();
                        break;
                    case 5:
                        Console.WriteLine("\nRemove Node:");
                        Console.WriteLine("1. Remove the first node");
                        Console.WriteLine("2. Remove the last node");
                        Console.WriteLine("3. Remove after a specific node");
                        Console.Write("Enter your choice: ");
                        subChoice = int.Parse(Console.ReadLine());

                        switch (subChoice)
                        {
                            case 1:
                                list.RemoveFirst();
                                break;
                            case 2:
                                list.RemoveLast();
                                break;
                            case 3:
                                Console.Write("Enter target node value to remove after: ");
                                target = int.Parse(Console.ReadLine());
                                list.RemoveAfter(target);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Returning to main menu.");
                                break;
                        }
                        WaitForKeyPress();
                        break;
                    case 6:
                        Console.WriteLine("\nSearch Node:");
                        Console.WriteLine("1. Search for a specific node");
                        Console.WriteLine("2. Search nodes by criteria (even numbers)");
                        Console.Write("Enter your choice: ");
                        subChoice = int.Parse(Console.ReadLine());

                        switch (subChoice)
                        {
                            case 1:
                                Console.Write("Enter value to search: ");
                                value = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Value {value} {(list.SearchNode(value) ? "found" : "not found")} in the list.");
                                break;
                            case 2:
                                Console.Write("Nodes with even values: ");
                                list.SearchNodesByCriteria(CircularLinkedList.IsEven);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Returning to main menu.");
                                break;
                        }
                        WaitForKeyPress();
                        break;
                    case 7:
                        Console.WriteLine("Sorting the list using Selection Sort.");
                        list.SelectionSort();
                        WaitForKeyPress();
                        break;
                    case 8:
                        Console.WriteLine("\nOperations on the List:");
                        Console.WriteLine("1. Remove duplicates");
                        Console.WriteLine("2. Remove nodes by criteria");
                        Console.WriteLine("3. Reverse the list");
                        Console.WriteLine("4. Find the Middle Node");
                        Console.Write("Enter your choice: ");
                        subChoice = int.Parse(Console.ReadLine());

                        switch (subChoice)
                        {
                            case 1:
                                list.RemoveDuplicates();
                                Console.WriteLine("Duplicates removed from the list.");
                                break;
                            case 2:
                                Console.WriteLine("\nRemove Nodes by Criteria:");
                                Console.WriteLine("1. Remove nodes with values greater than 5");
                                Console.WriteLine("2. Remove even nodes");
                                Console.Write("Enter your choice: ");
                                subChoice = int.Parse(Console.ReadLine());

                                switch (subChoice)
                                {
                                    case 1:
                                        list.RemoveNodesByCriteria(x => x > 5);
                                        Console.WriteLine("Nodes with values greater than 5 removed.");
                                        break;
                                    case 2:
                                        list.RemoveNodesByCriteria(x => x % 2 == 0);
                                        Console.WriteLine("Even nodes removed.");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice. Returning to main menu.");
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("Reversing the list.");
                                list.ReverseList();
                                break;
                            case 4:
                                Console.WriteLine("The middle node is: " + list.FindMiddle().data);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Returning to main menu.");
                                break;
                        }
                        WaitForKeyPress();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
        }

        public static void WaitForKeyPress()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
