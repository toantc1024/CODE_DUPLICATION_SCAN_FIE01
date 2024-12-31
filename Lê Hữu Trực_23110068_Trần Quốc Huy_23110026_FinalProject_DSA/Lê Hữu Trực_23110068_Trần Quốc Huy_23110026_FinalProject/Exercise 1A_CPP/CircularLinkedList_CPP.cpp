//Le Huu Truc - 23110068
//Tran Quoc Huy - 231110026
//EXERCISE 1: USE C++ TO IMPLEMENT A CIRCULAR LINKED LIST
#include <iostream>
using namespace std;

using TYPE = int;

struct Node {
	TYPE info;
	Node* next;

    Node() {
        next = nullptr;
    }

    Node(TYPE value) {
        info = value;
        next = nullptr;
    } 
};

struct CLinkedList {
	Node* head;
	Node* tail;

	CLinkedList() {
		head = nullptr;
		tail = nullptr;
	}

    bool empty() {
        if (head == nullptr) return true;
        return false;
    }
};

void add_back(CLinkedList& list, Node* newNode) {
    if (newNode == nullptr) {
        cout << "New node cannot be null";
        return;
    }
    //empty list
    if (list.empty())
    {
        list.head = newNode;
        list.tail = newNode;
        list.tail->next = newNode;
        return;
    }
    //normal case
    newNode->next = list.head;
    list.tail->next = newNode;
    list.tail = newNode;
}
void add_back(CLinkedList& list, TYPE value) {
    Node* newNode = new Node(value);
    add_back(list, newNode);
}

void add_first(CLinkedList& list, Node* newNode) {
    if (newNode == nullptr) {
        cout << "New node cannot be null";
        return;
    }
    //empty list
    if (list.empty())
    {
        list.head = newNode;
        list.tail = newNode;
        list.tail->next = newNode;
        return;
    }
    //normal case
    newNode->next = list.head;
    list.tail->next = newNode;
    list.head = newNode;
}
void add_first(CLinkedList& list, TYPE value) {
    Node* newNode = new Node(value);
    add_first(list, newNode);
}

void add_after(CLinkedList& list, Node* addAfterNode, Node* newNode) {
    if (newNode == nullptr) {
        cout << "New node cannot be null";
        return;
    }
    //empty list | 1 node | last nde
    if (list.empty() || list.head == list.tail || addAfterNode == list.tail)
    {
        add_back(list, newNode);
        return;
    }
    //normal case
    newNode->next = addAfterNode->next;
    addAfterNode->next = newNode;
}
void add_after(CLinkedList& list, Node* addAfterNode, TYPE value) {
    Node* newNode = new Node(value);
    add_after(list, addAfterNode, newNode);
}

void remove_back(CLinkedList& list) {
    //empty list
    if (list.empty()) {
        cout << "Empty list!";
        return;
    }
    //1 node
    if (list.head == list.tail) {
        delete list.head;
        list.head = nullptr;
        list.tail = nullptr;
        return;
    }
    Node* current = list.head;
    do {
        if (current->next == list.tail) {
            delete list.tail;
            list.tail = current;
            list.tail->next = list.head;
            return;
        }
        current = current->next;
    } while (current != list.head);
}
void remove_first(CLinkedList& list) {
    //empty list
    if (list.empty()) {
        cout << "Empty list!";
        return;
    }
    //1 node
    if (list.head == list.tail) {
        delete list.head;
        list.head = nullptr;
        list.tail = nullptr;
        return;
    }
    list.tail->next = list.head->next;
    delete list.head;
    list.head = list.tail->next;
}
void remove_after(CLinkedList& list, Node* removeAfterNode) {
    //empty list
    if (list.empty()) {
        cout << "Empty list!" << endl;
        return;
    }

    if (!removeAfterNode) {
        cout << "Invalid node!" << endl;
        return;
    }

    //one node
    if (list.head == list.tail && removeAfterNode == list.head) {
        // Removing the only node
        delete list.head;
        list.head = nullptr;
        list.tail = nullptr;
        return;
    }

    Node* nodeToRemove = removeAfterNode->next;
    if (nodeToRemove == list.head) {
        list.head = nodeToRemove->next;
    }
    if (nodeToRemove == list.tail) {
        list.tail = removeAfterNode;
    }
    //remove the node
    removeAfterNode->next = nodeToRemove->next;
    delete nodeToRemove;
}
void remove(CLinkedList& list, Node* removeNode) {
    // Invalid node check
    if (!removeNode) {
        cout << "Invalid node!";
    }

    // Empty list check
    if (list.empty()) {
        cout << "Empty list!";
    }

    // Case 1: Only one node in the list
    if (list.head == list.tail && list.head == removeNode) {
        remove_first(list);
        return;
    }

    // Case 2: Removing the head
    if (removeNode == list.head) {
        remove_first(list);
        return;
    }

    // Case 3: Removing the tail
    if (removeNode == list.tail) {
        remove_back(list);
        return;
    }

    // Case 4: Removing a middle node
    Node* current = list.head;
    do {
        if (current->next == removeNode) {
            remove_after(list, current); // Use remove_after to remove the target node
            return;
        }
        current = current->next;
    } while (current != list.head);

    // If the node is not found
    cout << "Node not found in the list!";
}

Node* search_first(CLinkedList& list, TYPE searchValue) {
    if (list.empty()) {
        cout << "Empty list!";
        return nullptr;
    }
    Node* current = list.head;
    do {
        if (current->info == searchValue) {
            return current;
        }
        current = current->next;
    } while (current != list.head);
    return nullptr;
}
Node* search_first(CLinkedList& list, Node* searchNode) {
    if (list.empty()) {
        cout << "Empty list!";
        return nullptr;
    }
    Node* current = list.head;
    do {
        if (current == searchNode) {
            return current;
        }
        current = current->next;
    } while (current != list.head);
    return nullptr;
}
CLinkedList search_largers(CLinkedList list, TYPE value) {
    CLinkedList result;
    if (list.empty()) {
        cout << "Empty list!";
        return result;
    }
    Node* current = list.head;
    do {
        if (current->info > value) {
            add_back(result, current->info);
        }
        current = current->next;
    } while (current != list.head);
    return result;
}

void cpyList(CLinkedList& source, CLinkedList listToCopy) {
    Node* current = listToCopy.head;
    if (listToCopy.empty()) return;
    do {
        add_back(source, new Node(current->info));
        current = current->next;
    } while (current != listToCopy.head);
}
Node* find_min(CLinkedList list) {
    Node* current = list.head;
    Node* min = current;
    do {
        if (min->info > current->info) min = current;
        current = current->next;
    } while (current != list.head);
    return min;
}
CLinkedList asc_selection_sort(CLinkedList list) {
    CLinkedList tmpList;
    cpyList(tmpList, list); //copy to make sure it's not affected when remove nodes
    CLinkedList sortedList;
    while (tmpList.head != nullptr) {
        Node* tmp = find_min(tmpList);
        add_back(sortedList, new Node(tmp->info));
        remove(tmpList, tmp);
    }
    return sortedList;
}

void merge(CLinkedList& list, CLinkedList addList)
{
    if (list.head == nullptr)
    {
        Node* tmp = addList.head;
        do
        {
            add_back(list, new Node(tmp->info));
            tmp = tmp->next;
        } while (tmp != addList.head);
        return;
    }
    if (addList.empty()) cout << "The input list is empty";
    addList.tail->next = list.head;
    list.tail->next = addList.head;
    list.tail = addList.tail;
}
void des_quick_sort_run(CLinkedList& list)
{
    if (list.head == nullptr || list.head->next == list.head) return;

    TYPE pivot = list.head->info;

    CLinkedList T1;
    CLinkedList T2;
    CLinkedList T3;

    Node* tmp = list.head;
    do
    {
        if (tmp->info > pivot) add_back(T1, new Node(tmp->info));
        else if (tmp->info == pivot) add_back(T2, new Node(tmp->info));
        else add_back(T3, new Node(tmp->info));
        tmp = tmp->next;
    } while (tmp != list.head);

    //Sort each sub array
    des_quick_sort_run(T1);
    des_quick_sort_run(T3);

    list.head = nullptr;

    //Merge sub arrays to form the result
    if (!T1.empty()) merge(list, T1);
    if (!T2.empty()) merge(list, T2);
    if (!T3.empty()) merge(list, T3);
}
CLinkedList des_quick_sort(CLinkedList list)
{
    des_quick_sort_run(list);

    return list;
}

void remove_larger(CLinkedList& list, TYPE value)
{
    if (list.empty()) {
        cout << "The list is empty!" << endl;
        return;
    }

    Node* current = list.head;
    bool foundLarger = false;

    do {
        Node* nextNode = current->next;

        if (current->info > value) {
            foundLarger = true;
            remove(list, current);  
            current = nextNode;  //move to the next node after removal
        }
        else {
            current = nextNode;
        }

    } while (current != list.head);  

    if (foundLarger)
        remove_larger(list, value);  //repeat if larger values were found
}

void reverse(CLinkedList& list)
{
    if (list.head == nullptr) cout << "Empty list";
    if (list.head == list.tail) return;

    Node* prev = nullptr;
    Node* current = list.head;
    Node* next = nullptr;
    Node* lastNode = list.tail; //save the tail

    do
    {
        next = current->next; //store the next node
        current->next = prev; //reverse the current link
        prev = current;      //move prev to the current node
        current = next;      //move current to the next node
    } while (current != list.head);

    // change head and tail
    list.tail = list.head;
    list.tail->next = prev;
    list.head = prev;
}

void display(CLinkedList list) {
    if (list.empty()) {
        cout << "List is empty!" << endl;
        return;
    }
    Node* current = list.head;
    do {
        cout << current->info << " ";
        current = current->next;
    } while (current != list.head);
    cout << endl;
}

void run() {
    CLinkedList list;

    // Test add_first() and add_last()
    cout << "Adding back 10, 20, 30:\n";
    add_back(list, 10);  // Add 10 to the end
    add_back(list, 20);  // Add 20 to the end
    add_back(list, 30);  // Add 30 to the end
    display(list);

    cout << "Adding first 5:\n";
    add_first(list, 5);  // Add 5 to the beginning
    display(list); 

    // Test add_after()
    cout << "Adding 15 after the first element:" << endl;
    add_after(list, list.head, 15); // Add 15 after the first node (5)
    display(list); 

    // Test remove_first()
    cout << "Removing the first element:" << endl;
    remove_first(list); // Remove 5
    display(list); 

    // Test remove_back()
    cout << "Removing the last element:" << endl;
    remove_back(list); // Remove 30
    display(list); 

    // Test search_first()
    cout << "Searching for node with value 10:" << endl;
    Node* foundNode = search_first(list, 10);
    if (foundNode) {
        cout << "Found node with value: " << foundNode->info << endl;
    }
    else {
        cout << "Node not found." << endl;
    }

    // Test find_min()
    cout << "Finding the minimum value in the list:" << endl;
    Node* minNode = find_min(list);
    cout << "Minimum value: " << minNode->info << endl;

    // Test asc_selection_sort()
    cout << "Sorting the list in ascending order:" << endl;
    CLinkedList sortedList = asc_selection_sort(list);
    display(sortedList); // Should display the list sorted in ascending order

    // Test merge()
    cout << "Merging two lists:" << endl;
    CLinkedList anotherList;
    add_back(anotherList, 25);
    add_back(anotherList, 35);
    merge(list, anotherList);
    display(list); 

    // Test des_quick_sort()
    cout << "Sorting the list in descending order using quick sort:" << endl;
    CLinkedList sortedDescList = des_quick_sort(list);
    display(sortedDescList); // Should display the list sorted in descending order

    // Test reverse()
    cout << "Reversing the list:" << endl;
    CLinkedList reverseList;
    cpyList(reverseList, list);
    reverse(reverseList);
    display(reverseList); // Should display the reversed list
    cout << "Original list: ";
    display(list);

    // Test remove larger()
    cout << "Remove all nodes that are larger than 20:" << endl;
    remove_larger(list, 20);
    display(list);
}


int main() {
    run();
    return 0;
}