#include <bits/stdc++.h>
using namespace std;
struct Goods
{
    string id;
    string name;
    double price;
};
struct Node
{
    Goods data;
    Node *pNext;
};
struct CircularLinkedList
{
    Node *pHead;
    Node *pTail;
};
void initializeList(CircularLinkedList &myList)
{
    myList.pHead = nullptr;
    myList.pTail = nullptr;
}
Node *CreateNode(Goods p)
{
    Node *newNode = new Node();
    newNode->data = p;
    newNode->pNext = nullptr;
    return newNode;
}
bool isEmptyNode(Node* p){
    return p == nullptr;
}
bool isEmptyList(CircularLinkedList &myList)
{
    return isEmptyNode(myList.pHead);
}
void InsertFirst(CircularLinkedList &myList, Node* p)
{
    if (isEmptyList(myList))
    {
        myList.pHead = myList.pTail = p;
        myList.pTail->pNext = myList.pHead;
        return;
    }
    p->pNext = myList.pHead;
    myList.pHead = p;
    myList.pTail->pNext = myList.pHead;
}
void InsertLast(CircularLinkedList &myList, Node* p)
{
    if (isEmptyList(myList))
    {
        myList.pHead = myList.pTail = p;
        myList.pTail->pNext = myList.pHead;
        return;
    }
    myList.pTail->pNext = p;
    myList.pTail = p;
    myList.pTail->pNext = myList.pHead;
}
void InsertAfter(CircularLinkedList &myList, Node* p, int pos)
{
    if (isEmptyList(myList)){
        InsertFirst(myList, p);
        return;
    }
    Node *temp = myList.pHead;
    while(pos--){
        temp = temp->pNext;
    }
    if(temp == myList.pTail){
        InsertLast(myList, p);
        return;
    }
    p->pNext = temp->pNext;
    temp->pNext = p;
}
void RemoveFirst(CircularLinkedList &myList)
{
    if (isEmptyList(myList))
        return;
    Node *p = myList.pHead;
    if (myList.pHead == myList.pTail)
    {
        myList.pHead = myList.pTail = nullptr;
    }
    else
    {
        myList.pHead = myList.pHead->pNext;
        myList.pTail->pNext = myList.pHead;
    }
    delete p;
}
void RemoveLast(CircularLinkedList &myList)
{
    if (isEmptyList(myList))
        return;

    if (myList.pHead == myList.pTail)
    {
        delete myList.pHead;
        myList.pHead = myList.pTail = nullptr;
        return;
    }

    Node *p = myList.pHead;
    while (p->pNext != myList.pTail)
    {
        p = p->pNext;
    }
    Node *temp = myList.pTail;
    myList.pTail = p;
    myList.pTail->pNext = myList.pHead;
    delete temp;
}
void RemoveAfter(CircularLinkedList &myList, int pos)
{
    if (isEmptyList(myList))
        return;
    Node *temp = myList.pHead;
    while(pos--){
        temp = temp->pNext;
    }
    if(temp->pNext == myList.pTail){
        RemoveLast(myList);
        return;
    }
    if(temp->pNext == myList.pHead){
        RemoveFirst(myList);
        return;
    }
    Node *p = temp->pNext;
    temp->pNext = p->pNext;
    delete p;
}
void SearchByName(CircularLinkedList &myList, string name)
{
    if (isEmptyList(myList))
    {
        cout << "This list is empty\n";
        return;
    }
    Node *node = myList.pHead;
    int pos = 0;
    do
    {
        if (node->data.name == name)
        {
            cout << "Found at position: " << pos << endl;
            return;
        }
        node = node->pNext;
        pos++;
    } while (node != myList.pHead);
    cout << "Not found\n";
}
void SearchItemsHavePriceLargerOrEquals(CircularLinkedList &myList, double price)
{
    if (isEmptyList(myList))
    {
        cout << "This list is empty\n";
        return;
    }
    Node *node = myList.pHead;
    int pos = 0;
    do
    {
        if (node->data.price >= price)
        {
            cout << node->data.id << " " << node->data.name << " " << node->data.price << " at position " << pos << endl;
        }
        node = node->pNext;
        pos++;
    } while (node != myList.pHead);
}
void PrintList(CircularLinkedList myList)
{
    if (isEmptyList(myList))
    {
        cout << "List is empty.\n";
        return;
    }
    Node *p = myList.pHead;
    do
    {
        cout << p->data.id << " " << p->data.name << " " << p->data.price << endl;
        p = p->pNext;
    } while (p != myList.pHead);
}
void AddRange(CircularLinkedList &myList, CircularLinkedList sourceList)
{
    if(isEmptyList(sourceList)) return;
    if(isEmptyList(myList)){
        myList.pHead = sourceList.pHead;
        myList.pTail = sourceList.pTail;
        return;
    }
    myList.pTail->pNext = sourceList.pHead;
    sourceList.pTail->pNext = myList.pHead;
    myList.pTail = sourceList.pTail;
}
void SelectionSort(CircularLinkedList &myList, int type)
{
    if (isEmptyList(myList))
        return;
    if (myList.pHead == myList.pTail)
        return;
    CircularLinkedList sorted;
    initializeList(sorted);
    while (!isEmptyList(myList))
    {
        Node *min = myList.pHead;
        Node *prevMin = myList.pHead;
        Node *cur = myList.pHead->pNext;
        Node *prev = myList.pHead;
        do
        {
            if (cur->data.name < min->data.name)
            {
                min = cur;
                prevMin = prev;
            }
            prev = cur;
            cur = cur->pNext;
        } while (cur != myList.pHead);
        if (min == myList.pHead)
        {
            if (myList.pHead->pNext == myList.pHead)
            {
                myList.pHead = nullptr;
            }
            else
            {
                Node *last = myList.pHead;
                while (last->pNext != myList.pHead)
                {
                    last = last->pNext;
                }
                myList.pHead = min->pNext;
                last->pNext = myList.pHead;
            }
        }
        else
        {
            prevMin->pNext = min->pNext;
        }
        min->pNext = nullptr;
        if (type == 0) // tang
        {
            InsertLast(sorted, min);
        }
        else if (type == 1)
        {
            InsertFirst(sorted, min);
        }
    }
    myList.pHead = sorted.pHead;
    myList.pTail = sorted.pTail;
}
void QuickSort(CircularLinkedList &myList){
    if(myList.pHead == myList.pTail) return;
    myList.pTail->pNext = nullptr;
    CircularLinkedList l1, l2;
    Node *pivot, *p;
    initializeList(l1);
    initializeList(l2);
    pivot = myList.pHead;
    myList.pHead = myList.pHead->pNext;
    pivot->pNext = nullptr;
    while(myList.pHead != nullptr){
        p = myList.pHead;
        myList.pHead = myList.pHead->pNext;
        p->pNext = nullptr;
        if(p->data.price <= pivot->data.price){
            InsertFirst(l1, p);
        }
        else{
            InsertFirst(l2, p);
        }
    }
    QuickSort(l1);
    QuickSort(l2);
    if(l1.pHead != nullptr){
        myList.pHead = l1.pHead;
        l1.pTail->pNext = pivot;
    }
    else myList.pHead = pivot;
    pivot->pNext = l2.pHead;
    if(l2.pHead != nullptr){
        myList.pTail = l2.pTail;
    }
    else myList.pTail = pivot;
    myList.pTail->pNext = myList.pHead;
}
void RemoveAbovePrice(CircularLinkedList &myList, double flag)
{
    if(isEmptyList(myList)) return;
    int pos = 0;
    Node *p = myList.pHead;
    do
    {
        while (p->pNext->data.price > flag)
        {
            RemoveAfter(myList, pos);
        }
        p = p->pNext;
        pos++;
    } while (p != myList.pHead);
}
void SplitByPrice(CircularLinkedList &original, CircularLinkedList &below, CircularLinkedList &above, double flag)
{
    initializeList(below);
    initializeList(above);

    if (isEmptyList(original))
        return;

    Node *current = original.pHead;
    do
    {
        if (current->data.price <= flag)
        {
            InsertLast(below, CreateNode(current->data));
        }
        else
        {
            InsertLast(above, CreateNode(current->data));
        }
        current = current->pNext;
    } while (current != original.pHead);
}
void ReverseList(CircularLinkedList &myList)
{
    if (isEmptyList(myList))
        return;
    if (myList.pHead == myList.pTail)
        return;
    Node *prev = myList.pTail;
    Node *cur = myList.pHead;
    Node *next = myList.pHead->pNext;
    do
    {
        cur->pNext = prev;
        prev = cur;
        cur = next;
        next = next->pNext;
    } while (cur != myList.pHead);
    myList.pHead = prev;
}
int main()
{
    CircularLinkedList list1, list2, below, above;
    initializeList(list1);
    initializeList(list2);
    initializeList(below);
    initializeList(above);

    int choice;
    do
    {
        cout << "\n=== GOODS MANAGEMENT SYSTEM ===\n";
        cout << "1. Insert new item to List 1\n";
        cout << "2. Insert new item to List 2\n";
        cout << "3. Display List\n";
        cout << "4. Sort items by name\n";
        cout << "5. Sort items by price\n";
        cout << "6. Split list by price threshold\n";
        cout << "7. Merge lists\n";
        cout << "8. Search item by name\n";
        cout << "9. Search items have price larger of equal\n";
        cout << "10. Remove items have price above\n";
        cout << "11. Reverse List\n";
        cout << "12. Exit\n";
        cout << "Enter your choice: ";
        cin >> choice;

        switch (choice)
        {
            case 1:
            {
                int numItems;
                cout << "Enter number of items to insert: ";
                cin >> numItems;

                for (int i = 0; i < numItems; i++)
                {
                    Goods item;
                    cout << "\nEnter details for item " << (i + 1) << ":\n";
                    cout << "ID: ";
                    cin >> item.id;
                    cin.ignore();
                    cout << "Name: ";
                    getline(cin, item.name);
                    cout << "Price: ";
                    cin >> item.price;

                    InsertLast(list1, CreateNode(item));
                }
                cout << numItems << " items inserted to List 1 successfully!\n";
                break;
            }

            case 2:
            {
                int numItems;
                cout << "Enter number of items to insert: ";
                cin >> numItems;

                for (int i = 0; i < numItems; i++)
                {
                    Goods item;
                    cout << "\nEnter details for item " << (i + 1) << ":\n";
                    cout << "ID: ";
                    cin >> item.id;
                    cin.ignore();
                    cout << "Name: ";
                    getline(cin, item.name);
                    cout << "Price: ";
                    cin >> item.price;
                    InsertLast(list2, CreateNode(item));
                }
                cout << numItems << " items inserted to List 2 successfully!\n";
                break;
            }
            case 3:
            {
                int listChoice;
                do{
                    cout << "Please choose list to display (1 or 2): ";
                    cin >> listChoice;
                }while(listChoice != 1 && listChoice != 2);
                if (listChoice == 1)
                {
                    cout << "\nList 1:\n";
                    PrintList(list1);
                }
                else
                {
                    cout << "\nList 2:\n";
                    PrintList(list2);
                }
                break;
            }
            case 4:
            {
                int listChoice;
                do{
                    cout << "Please choose list to sort (1 or 2): ";
                    cin >> listChoice;
                    if (listChoice == 1)
                    {
                        SelectionSort(list1, 0);
                        cout << "\nSorted List 1:\n";
                        PrintList(list1);
                    }
                    else if (listChoice == 2)
                    {
                        SelectionSort(list2, 0);
                        cout << "\nSorted List 2:\n";
                        PrintList(list2);
                    }
                }while(listChoice != 1 && listChoice != 2);
                break;
            }
            case 5:
            {
                CircularLinkedList sortedList;
                initializeList(sortedList);
                int listChoice;
                do{
                    cout << "Please choose list to sort (1 or 2): ";
                    cin >> listChoice;
                    if (listChoice == 1)
                    {
                        QuickSort(list1);
                        cout << "\nSorted List 1:\n";
                        PrintList(list1);
                    }
                    else if (listChoice == 2)
                    {
                        QuickSort(list2);
                        cout << "\nSorted List 2:\n";
                        PrintList(list2);
                    }
                }while(listChoice != 1 && listChoice != 2);
                break;
            }
            case 6:
            {
                cout << "Which list to split (1 or 2)? ";
                int listChoice;
                do{
                    cout << "Enter list to search (1 or 2): ";
                    cin >> listChoice;
                }while(listChoice != 1 && listChoice != 2);
                float threshold;
                cout << "Enter price threshold: ";
                cin >> threshold;
                if (listChoice == 1)
                {
                    SplitByPrice(list1, below, above, threshold);
                }
                else
                {
                    SplitByPrice(list2, below, above, threshold);
                }
                cout << "\nItems below or equal to " << threshold << ":\n";
                PrintList(below);
                cout << "\nItems above " << threshold << ":\n";
                PrintList(above);
                break;
            }
            case 7:
            {
                AddRange(list1, list2);
                cout << "Lists merged successfully!\n";
                cout << "Merged list:\n";
                PrintList(list1);
                initializeList(list2); // Reset list2 after merging
                break;
            }
            case 8:
            {
                int listChoice;
                do{
                    cout << "Enter list to search (1 or 2): ";
                    cin >> listChoice;
                }while(listChoice != 1 && listChoice != 2);
                string name;
                cout << "Enter name to search: ";
                cin.ignore();
                getline(cin, name);
                if(listChoice == 1){
                    SearchByName(list1, name);
                }
                else{
                    SearchByName(list2, name);
                }
                break;
            }
            case 9:
            {
                int listChoice;
                do{
                    cout << "Enter list to search (1 or 2): ";
                    cin >> listChoice;
                }while(listChoice != 1 && listChoice != 2);
                double price;
                cout << "Enter price to search: ";
                cin >> price;
                if(listChoice == 1){
                    SearchItemsHavePriceLargerOrEquals(list1, price);
                }
                else{
                    SearchItemsHavePriceLargerOrEquals(list2, price);
                }
                break;
            }
            case 10:
            {
                int listChoice;
                do{
                    cout << "Enter list to operate (1 or 2): ";
                    cin >> listChoice;
                }while(listChoice != 1 && listChoice != 2);
                double flag;
                cout << "Enter price threshold: ";
                cin >> flag;
                if(listChoice == 1){
                    RemoveAbovePrice(list1, flag);
                    cout << "List after removing items above " << flag << ":\n";
                    PrintList(list1);
                }
                else{
                    RemoveAbovePrice(list2, flag);
                    cout << "List after removing items above " << flag << ":\n";
                    PrintList(list2);
                }
                break;
            }
            case 11:
            {
                int listChoice;
                do{
                    cout << "Enter list to operate (1 or 2): ";
                    cin >> listChoice;
                }while(listChoice != 1 && listChoice != 2);
                cout << "List after reversing:\n";
                if(listChoice == 1){
                    ReverseList(list1);
                    PrintList(list1);
                }
                else{
                    ReverseList(list2);
                    PrintList(list2);
                }
                break;
            }
            case 12:
            {
                cout << "Exiting program...\n";
                break;
            }
            default:
            {
                cout << "Invalid choice! Please try again.\n";
            }
        }
    } while (choice != 12);

    return 0;
}