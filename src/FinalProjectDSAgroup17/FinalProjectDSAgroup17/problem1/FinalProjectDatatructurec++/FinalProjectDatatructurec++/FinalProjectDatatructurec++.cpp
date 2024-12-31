#include <iostream>
#include <functional>
using namespace std;

// Node structure
typedef struct Node {
    int data;
    Node* next;
};

// Circular Linked List class
class CircularLinkedList {
private:
    Node* tail;

public:
    CircularLinkedList() : tail(nullptr) {}

    // Initialize the list
    void initializeList() {
        tail = nullptr;
    }

    // Create a new node
    Node* createNode(int value) {
        Node* newNode = new Node();
        newNode->data = value;
        newNode->next = nullptr;
        return newNode;
    }

    // Check if the list is empty
    bool isEmpty() {
        return tail == nullptr;
    }

    // Insert at the beginning
    void insertAtBeginning(int value) {
        Node* newNode = createNode(value);
        if (isEmpty()) {
            tail = newNode;
            tail->next = tail; // Circular link
        }
        else {
            newNode->next = tail->next;
            tail->next = newNode;
        }
    }

    // Insert at the end
    void insertAtEnd(int value) {
        Node* newNode = createNode(value);
        if (isEmpty()) {
            tail = newNode;
            tail->next = tail; // Circular link
        }
        else {
            newNode->next = tail->next;
            tail->next = newNode;
            tail = newNode;
        }
    }

    // Insert after a node
    void insertAfter(Node* node, int value) {
        if (node == nullptr) return;
        Node* newNode = createNode(value);
        newNode->next = node->next;
        node->next = newNode;
        if (node == tail) {
            tail = newNode;
        }
    }

    // Remove the first node
    void removeFirstNode() {
        if (isEmpty()) return;
        Node* first = tail->next;
        if (tail == first) {
            delete first;
            tail = nullptr;
        }
        else {
            tail->next = first->next;
            delete first;
        }
    }

    // Remove the last node
    void removeLastNode() {
        if (isEmpty()) return;
        Node* current = tail->next;
        if (current == tail) {
            delete tail;
            tail = nullptr;
        }
        else {
            while (current->next != tail) {
                current = current->next;
            }
            current->next = tail->next;
            delete tail;
            tail = current;
        }
    }

    // Remove a node after a specific node
    void removeAfter(Node* node) {
        if (isEmpty() || node == nullptr || node->next == nullptr) return;
        Node* temp = node->next;
        if (temp == tail) {
            tail = node;
        }
        node->next = temp->next;
        delete temp;
    }

    // Search for a node with a specific value
    Node* search(int value) {
        if (isEmpty()) return nullptr;
        Node* current = tail->next;
        do {
            if (current->data == value) {
                return current;
            }
            current = current->next;
        } while (current != tail->next);
        return nullptr;
    }

    // Search for nodes satisfying a criteria
    void searchByCriteria(function<bool(int)> criteria) {
        if (isEmpty()) return;
        Node* current = tail->next;
        do {
            if (criteria(current->data)) {
                cout << current->data << " ";
            }
            current = current->next;
        } while (current != tail->next);
        cout << endl;
    }

    // Print the list
    void printList() {
        if (isEmpty()) {
            cout << "List is empty." << endl;
            return;
        }
        Node* current = tail->next;
        do {
            cout << current->data << " ";
            current = current->next;
        } while (current != tail->next);
        cout << endl;
    }

    // Selection sort
    void selectionSort() {
        if (isEmpty()) return;
        Node* start = tail->next;
        do {
            Node* minNode = start;
            Node* current = start->next;
            while (current != tail->next) {
                if (current->data < minNode->data) {
                    minNode = current;
                }
                current = current->next;
            }
            swap(start->data, minNode->data);
            start = start->next;
        } while (start != tail->next);
    }

    // Quick sort helper functions
    Node* partition(Node* low, Node* high) {
        int pivot = high->data;
        Node* i = low;
        Node* j = low;
        while (j != high) {
            if (j->data < pivot) {
                swap(i->data, j->data);
                i = i->next;
            }
            j = j->next;
        }
        swap(i->data, high->data);
        return i;
    }

    void quickSort(Node* low, Node* high) {
        if (low != high && low != nullptr && high != nullptr && low != high->next) {
            Node* pi = partition(low, high);
            quickSort(low, pi);
            quickSort(pi->next, high);
        }
    }

    void quickSort() {
        if (!isEmpty()) {
            quickSort(tail->next, tail);
        }
    }

    // Proposed operations
    void merge(CircularLinkedList& other) {
        if (other.isEmpty()) return;
        if (isEmpty()) {
            tail = other.tail;
        }
        else {
            Node* temp = tail->next;
            tail->next = other.tail->next;
            other.tail->next = temp;
            tail = other.tail;
        }
        other.tail = nullptr;
    }

    void removeByCriteria(function<bool(int)> criteria) {
        if (isEmpty()) return;
        Node* current = tail->next;
        Node* prev = tail;
        do {
            if (criteria(current->data)) {
                if (current == tail) {
                    tail = prev;
                }
                prev->next = current->next;
                delete current;
                current = prev->next;
            }
            else {
                prev = current;
                current = current->next;
            }
        } while (current != tail->next);
    }

    CircularLinkedList copyList() {
        CircularLinkedList newList;
        if (!isEmpty()) {
            Node* current = tail->next;
            do {
                newList.insertAtEnd(current->data);
                current = current->next;
            } while (current != tail->next);
        }
        return newList;
    }
};

// Main function for testing
int main() {
    CircularLinkedList list;
    int choice, value, position;

    do {
        cout << "\n--- Circular Linked List Menu ---\n";
        cout << "1. Initialize list\n";
        cout << "2. Insert at beginning\n";
        cout << "3. Insert at end\n";
        cout << "4. Insert after a specific value\n";
        cout << "5. Remove first node\n";
        cout << "6. Remove last node\n";
        cout << "7. Remove after a specific value\n";
        cout << "8. Search for a value\n";
        cout << "9. Search nodes by criteria\n";
        cout << "10. Print list\n";
        cout << "11. Sort list (Selection sort)\n";
        cout << "12. Sort list (Quick sort)\n";
        cout << "13. Merge another list\n";
        cout << "14. Remove nodes by criteria\n";
        cout << "15. Exit\n";
        cout << "Enter your choice: ";
        cin >> choice;

        switch (choice) {
        case 1:
            list.initializeList();
            cout << "List initialized.\n";
            break;

        case 2:
            cout << "Enter value to insert at beginning: ";
            cin >> value;
            list.insertAtBeginning(value);
            break;

        case 3:
            cout << "Enter value to insert at end: ";
            cin >> value;
            list.insertAtEnd(value);
            break;

        case 4: {
            cout << "Enter value after which to insert: ";
            cin >> value;
            Node* node = list.search(value);
            if (node) {
                cout << "Enter value to insert: ";
                cin >> position;
                list.insertAfter(node, position);
            }
            else {
                cout << "Value not found in the list.\n";
            }
            break;
        }

        case 5:
            list.removeFirstNode();
            cout << "First node removed.\n";
            break;

        case 6:
            list.removeLastNode();
            cout << "Last node removed.\n";
            break;

        case 7: {
            cout << "Enter value after which to remove node: ";
            cin >> value;
            Node* node = list.search(value);
            if (node) {
                list.removeAfter(node);
            }
            else {
                cout << "Value not found in the list.\n";
            }
            break;
        }

        case 8:
            cout << "Enter value to search: ";
            cin >> value;
            if (list.search(value)) {
                cout << "Value found in the list.\n";
            }
            else {
                cout << "Value not found.\n";
            }
            break;

        case 9:
            cout << "Enter value to search nodes greater than: ";
            cin >> value;
            cout << "Nodes satisfying the criteria: ";
            list.searchByCriteria([value](int x) { return x > value; });
            break;

        case 10:
            cout << "Current list: ";
            list.printList();
            break;

        case 11:
            list.selectionSort();
            cout << "List sorted using selection sort.\n";
            break;

        case 12:
            list.quickSort();
            cout << "List sorted using quick sort.\n";
            break;

        case 13: {
            CircularLinkedList otherList;
            int n, val;
            cout << "Enter number of elements in the second list: ";
            cin >> n;
            cout << "Enter elements: ";
            for (int i = 0; i < n; i++) {
                cin >> val;
                otherList.insertAtEnd(val);
            }
            list.merge(otherList);
            cout << "Lists merged.\n";
            break;
        }

        case 14:
            cout << "Enter value to remove nodes less than: ";
            cin >> value;
            list.removeByCriteria([value](int x) { return x < value; });
            cout << "Nodes removed based on criteria.\n";
            break;

        case 15:
            cout << "Exiting...\n";
            break;

        default:
            cout << "Invalid choice. Try again.\n";
        }
    } while (choice != 15);

    return 0;
}