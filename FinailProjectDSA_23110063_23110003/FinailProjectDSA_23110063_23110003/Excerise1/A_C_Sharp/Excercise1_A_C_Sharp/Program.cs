using Excercise1_A_C_Sharp;
using System;
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
    private Coffee head;

    // Initialize the list 
    public void InitializeList()
    {
        Console.Write("Enter the number of products : ");
        int numCoffees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numCoffees; i++)
        {
            Console.WriteLine($"\nEnter details for Coffee {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Cost: ");
            int cost = int.Parse(Console.ReadLine());
            InsertAtTheEnd(name, cost);
        }
    }
    // Create a new Coffee node
    private Coffee CreateCoffee(string name, int cost)
    {
        return new Coffee(name, cost);
    }
    // Check whether a Coffee node is empty or not 
    public bool IsEmpty()
    {
        return head == null;
    }
    // Insert a new Coffee at the beginning of the list
    public void InsertAtTheBeginning(string name, int cost)
    {
        Coffee newCoffee = CreateCoffee(name, cost);
        if (IsEmpty())
        {
            head = newCoffee;
            head.Next = head;
        }
        else
        {
            Coffee temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            newCoffee.Next = head;
            temp.Next = newCoffee;
            head = newCoffee;
        }
    }
    // Insert a new Coffee at the end of the list
    public void InsertAtTheEnd(string name, int cost)
    {
        Coffee newCoffee = CreateCoffee(name, cost);
        if (IsEmpty())
        {
            head = newCoffee;
            head.Next = head;
        }
        else
        {
            Coffee temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newCoffee;
            newCoffee.Next = head;
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

        Coffee temp = head;
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
        } while (temp != head);
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

        if (head.Next == head)
        {
            head = null;
        }
        else
        {
            Coffee temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = head.Next;
            head = head.Next;
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

        if (head.Next == head)
        {
            head = null;
        }
        else
        {
            Coffee temp = head;
            while (temp.Next.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = head;
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
        Coffee temp = head;
        do
        {
            if (temp.Name == afterName && temp.Next != head)
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine($"Coffee after {afterName} removed");
                return;
            }
            temp = temp.Next;
        } while (temp != head);
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

        Coffee temp = head;
        do
        {
            if (temp.Name == name)
            {
                Console.WriteLine($"Coffee found: {temp.Name}, Cost: {temp.Cost}");
                return;
            }
            temp = temp.Next;
        } while (temp != head);
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
        Coffee temp = head;
        do
        {
            if (temp.Cost == cost)
            {
                Console.WriteLine($"Coffee found: {temp.Name}, Cost: {temp.Cost}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

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

        Coffee temp = head;
        Console.WriteLine("Coffee List:");
        do
        {
            Console.WriteLine($"Name: {temp.Name}, Cost: {temp.Cost}");
            temp = temp.Next;
        } while (temp != head);
    }

    // Selection Sort
    public void SelectionSort()
    {
        if (IsEmpty()) return;

        Coffee i = head;
        do
        {
            Coffee min = i;
            Coffee j = i.Next;

            while (j != head)
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
        } while (i != head); 
    }
    // QuickSort
    public void QuickSort()
    {
        if (IsEmpty() || head.Next == head) return;
        QuickSortHelper(head, GetLastNode(head));
    }

    private void QuickSortHelper(Coffee low, Coffee high)
    {
        if (high != null && low != high && low != high.Next)
        {
            Coffee pivot = Partition(low, high);
            QuickSortHelper(low, pivot);
            QuickSortHelper(pivot.Next, high);
        }
    }

    private Coffee Prev(Coffee node)
    {
        Coffee temp = head;
        while (temp.Next != node)
        {
            temp = temp.Next;
        }
        return temp;
    }
    private Coffee Partition(Coffee low, Coffee high)
    {
        int pivotValue = high.Cost;
        Coffee i = GetPreviousNode(low);

        for (Coffee j = low; j != high; j = j.Next)
        {
            if (j.Cost <= pivotValue)
            {
                i = (i == null) ? low : i.Next;
                Swap(i, j);
            }
        }
        i = (i == null) ? low : i.Next;
        Swap(i, high);
        return i;
    }

    private Coffee GetPreviousNode(Coffee node)
    {
        Coffee temp = head;
        while (temp.Next != node)
        {
            temp = temp.Next;
        }
        return temp;
    }

    private void Swap(Coffee a, Coffee b)
    {
        string tempName = a.Name;
        int tempCost = a.Cost;
        a.Name = b.Name;
        a.Cost = b.Cost;
        b.Name = tempName;
        b.Cost = tempCost;
    }

    private Coffee GetLastNode(Coffee node)
    {
        while (node.Next != head)
        {
            node = node.Next;
        }
        return node;
    }

    // Reverse the list
    public void ReverseList()
    {
        if (IsEmpty() || head.Next == head)
        {
            Console.WriteLine("List is too short to reverse");
            return;
        }

        Coffee prev = null;
        Coffee current = head;
        Coffee next = null;

        do
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        } while (current != head);

        head.Next = prev; 
        head = prev; 

    }
    // Delete the entire list
    public void DeleteList()
    {
        head = null;
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
            Coffee temp = head;
            do
            {
                sw.WriteLine($"Name: {temp.Name}, Cost: {temp.Cost}");
                temp = temp.Next;
            } while (temp != head);
        }
    }

}

public class Program
{
    public static void Main()
    {
        CoffeeList list = new CoffeeList();
        int cost;
        string name, afterName, file;
        list.InitializeList();
        list.PrintList();

        //Console.Write("Enter name: ");
        //name = Console.ReadLine();
        //Console.Write("Enter cost: ");
        //cost = int.Parse(Console.ReadLine());
        //list.InsertAtTheBeginning(name, cost);
        //list.PrintList();

        //Console.Write("Enter name: ");
        //name = Console.ReadLine();
        //Console.Write("Enter cost: ");
        //cost = int.Parse(Console.ReadLine());
        //list.InsertAtTheEnd(name, cost);
        //list.PrintList();

        //Console.Write("Enter name Coffee: ");
        //afterName = Console.ReadLine();
        //Console.Write("Enter name: ");
        //name = Console.ReadLine();
        //Console.Write("Enter cost: ");
        //cost = int.Parse(Console.ReadLine());
        //list.InsertAfter(afterName, name, cost);
        //list.PrintList();

        //list.RemoveFirst();
        //list.PrintList();

        //list.RemoveLast();
        //list.PrintList();

        //list.SelectionSort();
        //list.PrintList();

        //list.QuickSort();
        //list.PrintList();

        //Console.Write("Enter name Coffee: ");
        //afterName = Console.ReadLine();
        //list.RemoveAfter(afterName);
        //list.PrintList();

        //list.PrintList();
        //Console.Write("Enter customer name: ");
        //name = Console.ReadLine();
        //list.SearchName(name);

        //list.PrintList();
        //Console.Write("Enter cost: ");
        //cost = int.Parse(Console.ReadLine());
        //list.SearchCost(cost);

        //list.ReverseList();
        //list.PrintList();

        //list.DeleteList();

        //Console.Write("Enter name file to save to: ");
        //file = Console.ReadLine();
        //list.SaveList(file);
    }
}
