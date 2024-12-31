#include <iostream>
#include <fstream>
#include <sstream>
#include <vector>
using namespace std;

struct Node {
    int data;
    Node* next;
    Node* prev;
    Node(int value) {
        data = value;
        next = nullptr;
    }
};
bool isEmpty(Node* last) {
    return last == nullptr;
}
Node* insertAtBeginning(Node* last, int value){
    Node* newNode = new Node(value);
    if (last == nullptr) {
        newNode->next = newNode;
        return newNode;
    }
    newNode->next = last->next;
    last->next = newNode;
    return last;
}
Node *insertEnd(Node *tail, int value){
    Node *newNode = new Node(value);
    if (tail == nullptr)
    {
        tail = newNode;
        newNode->next = newNode;
    }
    else
    {
        newNode->next = tail->next;
        tail->next = newNode;
        tail = newNode;
    }
    return tail;
}
Node *insertAtPosition(Node *last, int data, int pos){
    if (last == nullptr){
        if (pos != 1){
            cout << "Invalid position!" << endl;
            return last;
        }
        Node *newNode = new Node(data);
        last = newNode;
        last->next = last;
        return last;
    }
    Node *newNode = new Node(data);
    Node *curr = last->next;
    if (pos == 1){
        newNode->next = curr;
        last->next = newNode;
        return last;
    }
    for (int i = 1; i < pos - 1; ++i) {
        curr = curr->next;

        if (curr == last->next){
            cout << "Invalid position!" << endl;
            return last;
        }
    }
    newNode->next = curr->next;
    curr->next = newNode;
    if (curr == last) last = newNode;

    return last;
}
Node *insertInEmptyList(Node *last, int data){
    if (last != nullptr) return last;
    Node *newNode = new Node(data);
    newNode->next = newNode;
    last = newNode;
    return last;
}
Node* deleteFirstNode(Node* last) {
    if (last == nullptr) {
        cout << "List is empty" << endl;
        return nullptr;
    }
    Node* head = last->next;
    if (head ==last) {
        delete head;
        last = nullptr;
    } else {
        last->next = head->next;
        delete head;
    }
    return last;
}
Node* deleteLastNode(Node* last) {
    if (last == nullptr) {
        // If the list is empty
        cout << "List is empty, nothing to delete." << endl;
        return nullptr;
    }
    Node* head = last->next;

    // If there is only one node in the list
    if (head == last) {
        delete last;
        last = nullptr;
        return last;
    }
    // Traverse the list to find the second last node
    Node* curr = head;
    while (curr->next != last) {
        curr = curr->next;
    }
    // Update the second last node's next pointer
    // to point to head
    curr->next = head;
    delete last;
    last = curr;

    return last;
}
Node* deleteSpecificNode(Node* last, int key) {
    if (last == nullptr) {
        cout << "List is empty, nothing to delete." << endl;
        return nullptr;
    }
    Node* curr = last->next;
    Node* prev = last;
    if (curr == last && curr->data == key) {
        delete curr;
        last = nullptr;
        return last;
    }
    if (curr->data == key) {
        last->next = curr->next;
        delete curr;
        return last;
    }
    while (curr != last && curr->data != key) {
        prev = curr;
        curr = curr->next;
    }
    if (curr->data == key) {
        prev->next = curr->next;
        if (curr == last) {
            last = prev;
        }
        delete curr;
    } else {
        cout << "Node with data " << key
          << " not found." << endl;
    }
    return last;
}
vector<int> search(Node* last, int key) {
    vector<int> positions;

    if (last == nullptr) {
        return positions; // Danh sách trống, trả về danh sách rỗng
    }

    Node* head = last->next;
    Node* curr = head;
    int position = 1;

    do {
        if (curr->data == key) {
            positions.push_back(position);
        }
        curr = curr->next;
        position++;
    } while (curr != head);

    return positions;
}
void findOddNumbers(Node* last) {
    if (last == nullptr) {
        cout << "List is empty, no odd numbers to find." << endl;
        return;
    }
    cout << "Odd numbers in the list: ";
    Node* head = last->next;
    Node* curr = head;
    bool hasOdd = false;
    do {
        if (curr->data % 2 != 0) {
            cout << curr->data << " ";
            hasOdd = true;
        }
        curr = curr->next;
    } while (curr != head);

    if (!hasOdd) {
        cout << "None";
    }
    cout << endl;
}
Node* selectionSort(Node* last) {
    if (last == nullptr || last->next == last) {
        return last;
    }
    Node* head = last->next;
    Node* current = head;
    do {
        Node* minNode = current;
        Node* temp = current->next;
        while (temp != head) {
            if (temp->data < minNode->data) {
                minNode = temp;
            }
            temp = temp->next;
        }
        if (minNode != current) {
            swap(current->data, minNode->data);
        }
        current = current->next;
    } while (current != head);

    return last;
}
Node* partition(Node* head, Node* tail) {
    Node* pivot = head;
    Node* pre = head;
    Node* curr = head->next;

    while (curr != tail->next) {
        if (curr->data > pivot->data) {
            pre = pre->next;
            std::swap(curr->data, pre->data);
        }
        curr = curr->next;
    }
    std::swap(pivot->data, pre->data);
    return pre;
}
void quickSortHelper(Node* head, Node* tail) {
    if (head == nullptr || head == tail || head == tail->next) {
        return;
    }
    Node* pivot = partition(head, tail);
    quickSortHelper(head, pivot->prev);
    quickSortHelper(pivot->next, tail);
}
Node* quickSort(Node* head, Node* last){
    quickSortHelper(head, last);
    return head;
}
Node* mergeLists(Node* last1, Node* last2) {
    if (last1 == nullptr) return last2;
    if (last2 == nullptr) return last1;
    Node* head1 = last1->next;
    Node* head2 = last2->next;
    last1->next = head2;
    last2->next = head1;
    return last2;
}
Node* removeGreaterThan(Node* last, int value) {
    if (last == nullptr) {
        cout << "List is empty, nothing to remove." << endl;
        return nullptr;
    }
    Node* head = last->next;
    Node* curr = head;
    Node* prev = last;
    bool modified = false;
    do {
        if (curr->data > value) {
            if (curr == head) {
                head = head->next;
                last->next = head;
                delete curr;
                curr = head;
            } else {
                prev->next = curr->next;
                if (curr == last) {
                    last = prev;
                }
                delete curr;
                curr = prev->next;
            }
            modified = true;
        } else {
            prev = curr;
            curr = curr->next;
        }
    } while (curr != head);

    if (!modified) {
        cout << "No values greater than " << value << " were found." << endl;
    }
    if (head == last && head->data > value) {
        delete head;
        last = nullptr;
    }

    return last;
}
void splitList(Node* last, Node*& evenList, Node*& oddList) {
    if (last == nullptr) {
        cout << "List is empty, nothing to split." << endl;
        evenList = nullptr;
        oddList = nullptr;
        return;
    }

    Node* head = last->next;
    Node* curr = head;

    do {
        if (curr->data % 2 == 0) {
            evenList = insertEnd(evenList, curr->data);
        } else {
            oddList = insertEnd(oddList, curr->data);
        }
        curr = curr->next;
    } while (curr != head);
}
void printList(Node* last) {
    if(last == NULL) return ;
    Node* head = last->next;
    while (true){
        cout << head->data << " ";
        head = head->next;
        if (head == last->next) break;
    }
    cout << endl;
}
int main()
{
    ifstream f("Project1a.inp");
    ifstream g("Project1aMerge");
    int a;
    Node* last = nullptr;
    Node* last2 = nullptr;
    if (isEmpty(last)) {
        cout << "List is empty." << endl;
    }
    else cout<< "List isn't empty"<<endl;
    f >> a;
    last = insertInEmptyList(last, a);
    string line;
    int k = 1;
    while (getline(f, line))
    {
        istringstream iss(line);
        while (iss >> a)
        {
            if (k %2==0)
            {
                last = insertEnd(last, a);
                cout<<"List after insert "<<a<<" in the End of list: ";
                printList(last);
            }
            else
            {
                cout<<"List after insert "<<a<<" in the Beginning of list: ";
                last = insertAtBeginning(last, a);
                printList(last);
            }
        }
        k++;
    }
    if (isEmpty(last))
    {
        cout << "List is empty." << endl;
    }
    else cout<< "List isn't empty"<<endl;
    g>>a;
    last2=insertInEmptyList(last2,a);
    while (getline(g,line))
    {
        istringstream iss(line);
        while (iss >> a)
            last2 = insertEnd(last2, a);
    }
    last=insertAtPosition(last,5,2);
    cout<<"List after insert 5 in the 2nd position: ";
    printList(last);
    last=deleteFirstNode(last);
    cout<<"List after delete first node: ";
    printList(last);
    last=deleteLastNode(last);
    cout<<"List after delete last node: ";
    printList(last);
    last=deleteSpecificNode(last,5);
    cout<<"List after delete 5th node: ";
    printList(last);
    int key = 3;
    vector<int> positions = search(last, key);
    if (!positions.empty()) {
        cout << "Value " << key << " found at positions: ";
        for (int pos : positions) {
            cout << pos << " ";
        }
        cout << endl;
    } else {
        cout<< "Value " << key << " not found in the list." << endl;
    }
    findOddNumbers(last);
    last = selectionSort(last);
    cout << "Sorted list (ascending order): ";
    printList(last);
    Node* head =last->next;
    head = quickSort(head,last);
    cout << "Sorted list (descending order): ";
    printList(last);
    cout<< "List 2 is: ";
    printList(last2);
    last = mergeLists(last, last2);
    cout << "Merged list: ";
    last = selectionSort(last);
    printList(last);
    last = removeGreaterThan(last, 5);
    cout << "List after removing values greater than 5: ";
    printList(last);
    Node* evenList = nullptr;
    Node* oddList = nullptr;
    splitList(last, evenList, oddList);
    cout << "Even list: ";
    printList(evenList);
    cout << "Odd list: ";
    printList(oddList);
    return 0;
}
