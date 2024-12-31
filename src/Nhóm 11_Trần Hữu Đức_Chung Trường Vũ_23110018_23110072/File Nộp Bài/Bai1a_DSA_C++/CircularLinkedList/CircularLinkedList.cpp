#include <iostream>
#include <cmath>
#include <list>

using namespace std;

//
struct CircularDoublyLinkedList {
    struct Node {
        int info;
        Node* pNext;
        Node* pPrev;
    };

    Node* pHead;

    CircularDoublyLinkedList() : pHead(nullptr) {}

    bool IsEmpty() {
        return pHead == nullptr;
    }

    void AddFirst(int value) {
        Node* newNode = new Node();
        newNode->info = value;

        if (IsEmpty()) {
            newNode->pNext = newNode;
            newNode->pPrev = newNode;
            pHead = newNode;
        }
        else {
            Node* tail = pHead->pPrev;
            newNode->pNext = pHead;
            newNode->pPrev = tail;
            tail->pNext = newNode;
            pHead->pPrev = newNode;
            pHead = newNode;
        }
    }

    void AddLast(int value) {
        Node* newNode = new Node();
        newNode->info = value;

        if (IsEmpty()) {
            AddFirst(value);
        }
        else {
            Node* tail = pHead->pPrev;
            newNode->pNext = pHead;
            newNode->pPrev = tail;
            tail->pNext = newNode;
            pHead->pPrev = newNode;
        }
    }

    void AddAfter(int value, Node* node) {
        if (node == nullptr) {
            cout << "Cannot add after null." << endl;
            return;
        }

        Node* newNode = new Node();
        newNode->info = value;

        newNode->pNext = node->pNext;
        newNode->pPrev = node;

        if (node->pNext) { 
            node->pNext->pPrev = newNode;
        }
        node->pNext = newNode;
    }
    
    void RemoveFirst() {
        if (IsEmpty()) {
            cout << "The List is empty." << endl;
            return;
        }

        if (pHead == pHead->pNext) {
            delete pHead;
            pHead = nullptr;
            return;
        }

        Node* tail = pHead->pPrev;
        Node* originalHead = pHead;
        Node* newHead = pHead->pNext;

        pHead = newHead;
        pHead->pPrev = tail;
        tail->pNext = pHead;

        delete originalHead;
    }



    void RemoveLast()
    {
        if (IsEmpty())
        {
            cout << "The List is empty." << endl;
            return;
        }

        if (pHead->pNext == pHead)
        {
            RemoveFirst();
            return;
        }

        Node* tail = pHead->pPrev;
        Node* beforeTail = tail->pPrev;
        pHead->pPrev = beforeTail;
        beforeTail->pNext = pHead;
        delete tail;
    }

    void RemoveAfter(Node* node) {
        if (node == nullptr) {
            cout << "Node removed can not be null" << endl;
            return;
        }

        if (pHead == node && pHead->pNext == node)
        { 
            cout << "Can not remove after the last node of the list." << endl;
            return;
        }

        Node* temp = node->pNext;
        if (temp == pHead) 
        {
            cout << "Can not remove after the last node of the list." << endl;
            return;
        }
        node->pNext = temp->pNext;
        temp->pNext->pPrev = node;
        delete temp;
    }

    Node* SearchNode(int value) {
        if (IsEmpty()) {
            cout << "The list is empty" << endl;
            return nullptr;
        }

        Node* current = pHead;
        do {
            if (current->info == value) {
                return current;
            }
            current = current->pNext;
        } while (current != pHead);

        cout << "Cannot find a node with " << value << endl;
        return nullptr;
    }
    void RemoveNode(Node* node) {
        if (node == nullptr) return;
        if (node == pHead) {
            if (pHead->pNext == pHead) {
                delete pHead;
                pHead = nullptr;
            }
            else {
                Node* temp = pHead;
                while (temp->pNext != pHead) {
                    temp = temp->pNext;
                }
                temp->pNext = pHead->pNext;
                delete pHead;
                pHead = temp->pNext;
            }
        }
        else {
            Node* temp = pHead;
            while (temp->pNext != node) {
                temp = temp->pNext;
            }
            temp->pNext = node->pNext;
            delete node;
        }
    }

    list<Node*> SearchNode(bool (*criteria)(Node*)) {
        list<Node*> result;
        if (IsEmpty()) {
            cout << "The list is empty" << endl;
            return result;
        }

        Node* current = pHead;
        do {
            if (criteria(current)) {
                result.push_back(current);
            }
            current = current->pNext;
        } while (current != pHead);

        return result;
    }

    static bool IsMoreThan5(Node* node) {
        return node->info > 5;
    }

    static bool IsSquared(Node* node) {
        int root = sqrt(node->info);
        return root * root == node->info;
    }

    void PrintList() {
        if (IsEmpty()) {
            cout << "The list is empty" << endl;
            return;
        }

        Node* current = pHead;
        do {
            cout << current->info << " ";
            current = current->pNext;
        } while (current != pHead);
        cout << endl;
    }

    void SelectionSort() {
        if (IsEmpty() || pHead->pNext == pHead) {
            return;
        }

        Node* sortedHead = nullptr;

        while (pHead != nullptr) {
            Node* min = pHead;
            Node* current = pHead->pNext;

            do {
                if (current->info < min->info) {
                    min = current;
                }
                current = current->pNext;
            } while (current != pHead);

            if (min->pNext == min && min->pPrev == min) {
                pHead = nullptr;
            }
            else {
                min->pPrev->pNext = min->pNext;
                min->pNext->pPrev = min->pPrev;

                if (min == pHead) {
                    pHead = min->pNext;
                }
            }

            if (sortedHead == nullptr) {
                sortedHead = min;
                min->pNext = min->pPrev = min;
            }
            else {
                Node* last = sortedHead->pPrev;
                last->pNext = min;
                min->pPrev = last;
                min->pNext = sortedHead;
                sortedHead->pPrev = min;
            }
        }

        pHead = sortedHead;
    }

    int distance(Node* p) {
        int count = 0;
        Node* current = pHead;
        while (current != p) {
            current = current->pNext;
            count++;
        }
        return count;
    }

    Node* back(int step) {
        Node* runner = pHead;
        for (int i = 0; i < step; i++) {
            runner = runner->pNext;
        }
        return runner;
    }

    Node* Partition(Node* low, Node* high) {
        Node* pivot = high;
        Node* i = low->pPrev;

        Node* j = low;
        while (j != high) {
            if (j->info < pivot->info) {
                i = (i == nullptr) ? low : i->pNext;
                swap(i, j);
            }
            j = j->pNext;
        }

        i = (i == nullptr) ? low : i->pNext;
        swap(i, high);

        return i;
    }


    void QuickSortRecursive(Node* low, Node* high) {
        if (low == nullptr || high == nullptr || low == high || low == high->pPrev) {
            return;
        }

        Node* pivot = Partition(low, high);

        if (pivot != low) {
            QuickSortRecursive(low, pivot->pPrev);
        }
        if (pivot != high) {
            QuickSortRecursive(pivot->pNext, high);
        }
    }

    void QuickSort() {
        if (pHead == nullptr) return;

        Node* tail = pHead->pPrev;
        QuickSortRecursive(pHead, tail);
    }

    void MergeLists(CircularDoublyLinkedList& list2) {
        if (IsEmpty()) {
            pHead = list2.pHead;
            return;
        }

        if (list2.IsEmpty()) {
            return;
        }

        Node* tail1 = pHead->pPrev;
        Node* tail2 = list2.pHead->pPrev;

        tail1->pNext = list2.pHead;
        list2.pHead->pPrev = tail1;

        tail2->pNext = pHead;
        pHead->pPrev = tail2;
    }

    void RemoveAllNodesByCriteria(bool (*criteria)(Node*)) {
        if (IsEmpty()) {
            cout << "The list is empty." << endl;
            return;
        }

        Node* current = pHead;
        Node* nextNode = nullptr;
        Node* prevNode = nullptr;

        do {
            nextNode = current->pNext;
            if (criteria(current)) {
                if (current == pHead) {
                    pHead = nextNode;
                    if (pHead == current) {
                        pHead = nullptr;
                    }
                }

                RemoveNode(current);

                if (IsEmpty()) {
                    break;
                }
            }
            else {
                prevNode = current;
            }

            current = nextNode;
        } while (current != pHead);

        if (!IsEmpty() && prevNode) {
            prevNode->pNext = pHead;
        }
    }


    void ReverseList() {
        if (IsEmpty() || pHead->pNext == pHead) {
            return;
        }

        Node* current = pHead;
        do {
            Node* temp = current->pNext;
            current->pNext = current->pPrev;
            current->pPrev = temp;

            current = current->pPrev;
        } while (current != pHead);

        pHead = pHead->pPrev;
    }
};

int main() 
{
    CircularDoublyLinkedList list1;
    CircularDoublyLinkedList list2;
    list1.AddFirst(10);
    list1.AddLast(20);
    list1.AddLast(30);
    list1.AddFirst(5);
    list2.AddFirst(15);
    list2.AddLast(25);
    list2.AddLast(35);

    cout << "List 1 after adding elements: ";
    list1.PrintList();
    cout << "List 2 after adding elements: ";
    list2.PrintList();

    list1.MergeLists(list2);
    cout << "List 1 after merging with List 2: ";
    list1.PrintList();

    list1.ReverseList();
    cout << "List 1 after reversing: ";
    list1.PrintList();

    list1.SelectionSort();
    cout << "List 1 after selection sort: ";
    list1.PrintList();

    list1.QuickSort();
    cout << "List 1 after quick sort: ";
    list1.PrintList();

    CircularDoublyLinkedList::Node* node = list1.SearchNode(20);
    if (node) {
        cout << "Found node with value: " << node->info << endl;
    }

    list1.RemoveNode(node);
    cout << "List 1 after removing node with value 20: ";
    list1.PrintList();

    node = list1.SearchNode(30);
    if (node) {
        list1.RemoveAfter(node);
        cout << "List 1 after removing node after 30: ";
        list1.PrintList();
    }

    list1.RemoveFirst();
    cout << "List 1 after removing the first node: ";
    list1.PrintList();

    list1.RemoveLast();
    cout << "List 1 after removing the last node: ";
    list1.PrintList();

    list1.RemoveAllNodesByCriteria(list1.IsMoreThan5);
    cout << "List 1 after removing nodes greater than 5: ";
    list1.PrintList();

    list1.RemoveAllNodesByCriteria(list1.IsSquared);
    cout << "List 1 after removing squared nodes: ";
    list1.PrintList();

    list1.RemoveFirst();

    list1.AddFirst(10);
    list1.AddLast(20);
    list1.AddLast(30);
    list1.AddFirst(5);
    cout << " Reconstruct list 1: ";
    list1.PrintList();

    node = list1.SearchNode(20);
    if (node) {
        list1.RemoveAfter(node);
        cout << "List 1 after removing node after 20: ";
        list1.PrintList();
    }

    list1.RemoveFirst();
    cout << "List 1 after removing the first node: ";
    list1.PrintList();

    list1.RemoveLast();
    cout << "List 1 after removing the last node: ";
    list1.PrintList();

    list1.RemoveAllNodesByCriteria(list1.IsSquared);
    cout << "List 1 after removing squared nodes: ";
    list1.PrintList();

    return 0;
}

