using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerise1_B
{
    public class Coffee
    {
        public string Name;
        public int Cost;
        public Coffee Next;

        public Coffee(string name, int cost)
        {
            Name = name;
            Cost = cost;
            Next = null;
        }
    }

    public class CoffeeList
    {
        public Coffee Head;

        // Create a new Coffee node
        private Coffee CreateCoffee(string name, int cost)
        {
            return new Coffee(name, cost);
        }
        // Check whether a Coffee node is empty or not 
        public bool IsEmpty()
        {
            return Head == null;
        }
        // Insert a new Coffee at the beginning of the list
        public void InsertAtTheBeginning(string name, int cost)
        {
            Coffee newCoffee = CreateCoffee(name, cost);
            if (IsEmpty())
            {
                Head = newCoffee;
                Head.Next = Head;
            }
            else
            {
                Coffee temp = Head;
                while (temp.Next != Head)
                {
                    temp = temp.Next;
                }
                newCoffee.Next = Head;
                temp.Next = newCoffee;
                Head = newCoffee;
            }
        }
        // Insert a new Coffee at the end of the list
        public void InsertAtTheEnd(string name, int cost)
        {
            Coffee newCoffee = CreateCoffee(name, cost);
            if (IsEmpty())
            {
                Head = newCoffee;
                Head.Next = Head;
            }
            else
            {
                Coffee temp = Head;
                while (temp.Next != Head)
                {
                    temp = temp.Next;
                }
                temp.Next = newCoffee;
                newCoffee.Next = Head;
            }
        }

        // Insert a new Coffee after a Coffee we choose of the list 
        public void InsertAfter(string afterName, string name, int cost)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Coffee temp = Head;
            do
            {
                if (temp.Name == afterName)
                {
                    Coffee newCoffee = CreateCoffee(name, cost);
                    newCoffee.Next = temp.Next;
                    temp.Next = newCoffee;
                    Console.WriteLine($"Coffee inserted after {afterName}.");
                    return;
                }
                temp = temp.Next;
            } while (temp != Head);
            Console.WriteLine("Not found!");
        }
        //Remove the first Coffee node of the list
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }

            if (Head.Next == Head)
            {
                Head = null;
            }
            else
            {
                Coffee temp = Head;
                while (temp.Next != Head)
                {
                    temp = temp.Next;
                }
                temp.Next = Head.Next;
                Head = Head.Next;
            }
        }
        //Remove the last Coffee node of the list 
        public void RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }

            if (Head.Next == Head)
            {
                Head = null;
            }
            else
            {
                Coffee temp = Head;
                while (temp.Next.Next != Head)
                {
                    temp = temp.Next;
                }
                temp.Next = Head;
            }
        }
        //Remove a Coffee node after a Coffee node of the list 
        public void RemoveAfter(string afterName)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }
            Coffee temp = Head;
            do
            {
                if (temp.Name == afterName && temp.Next != Head)
                {
                    temp.Next = temp.Next.Next;
                    Console.WriteLine($"Coffee after {afterName} removed");
                    return;
                }
                temp = temp.Next;
            } while (temp != Head);
            Console.WriteLine("Not found!");
        }
        //Search a Coffee in the list by name
        public void SearchName(string name)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Coffee temp = Head;
            do
            {
                if (temp.Name == name)
                {
                    Console.WriteLine($"Coffee found: {temp.Name}, Cost: {temp.Cost}");
                    return;
                }
                temp = temp.Next;
            } while (temp != Head);
            Console.WriteLine("Not found!");
        }
        //Search a Coffee in the list by cost
        public void SearchCost(int cost)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            bool found = false;
            Coffee temp = Head;
            do
            {
                if (temp.Cost == cost)
                {
                    Console.WriteLine($"Coffee found: {temp.Name}, Cost: {temp.Cost}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != Head);

            if (!found)
            {
                Console.WriteLine("No Coffees found with this Cost!");
            }
        }
        // Print the list
        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Coffee temp = Head;
            Console.WriteLine("Coffee List:");
            do
            {
                Console.WriteLine($"Name: {temp.Name}, Cost: {temp.Cost}");
                temp = temp.Next;
            } while (temp != Head);
        }

        // Selection Sort
        public void SelectionSort()
        {
            if (IsEmpty()) return;

            Coffee i = Head;
            do
            {
                Coffee min = i;
                Coffee j = i.Next;

                while (j != Head)
                {
                    if (min.Cost > j.Cost)
                    {
                        min = j;
                    }
                    j = j.Next;
                }
                if (min != i)
                {
                    string tempName = i.Name;
                    int tempCost = i.Cost;
                    i.Name = min.Name;
                    i.Cost = min.Cost;
                    min.Name = tempName;
                    min.Cost = tempCost;
                }
                i = i.Next;
            } while (i != Head);
        }
        // Reverse the list
        public void ReverseList()
        {
            if (IsEmpty() || Head.Next == Head)
            {
                Console.WriteLine("List is too short to reverse");
                return;
            }

            Coffee prev = null;
            Coffee current = Head;
            Coffee next = null;

            do
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            } while (current != Head);

            Head.Next = prev;
            Head = prev;

        }
        // Delete the entire list
        public void DeleteList()
        {
            Head = null;
        }
        // Save list to a text file
        public void SaveList(string file)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!Nothing to save!");
                return;
            }

            using (StreamWriter sw = new StreamWriter(file))
            {
                Coffee temp = Head;
                do
                {
                    sw.WriteLine($"Name: {temp.Name}, Cost: {temp.Cost}");
                    temp = temp.Next;
                } while (temp != Head);
            }
        }

    }
}
