// Linked_List.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <functional>
using namespace std;

struct Node {
    int data;
    struct Node* next;
};

struct Node* createNode(int data)
{
    struct Node* newNode
        = (struct Node*)malloc(sizeof(struct Node));
    newNode->data = data;
    newNode->next = NULL;
    return newNode;
}

// Ktr xem List co rong khong
bool IsEmpty(struct Node* head) {
    return head == NULL;
}

void AddFirst(struct Node** head, int data)
{
    struct Node* newNode = createNode(data);
    if (*head == NULL) {
        *head = newNode;
        newNode->next = *head;
    }
    else {
        struct Node* temp = *head;
        while (temp->next != *head) {
            temp = temp->next;
        }
        temp->next = newNode;
        newNode->next = *head;
        *head = newNode;
    }
}

void AddLast(struct Node** head, int data)
{
    struct Node* newNode = createNode(data);
    if (*head == NULL) {
        *head = newNode;
        newNode->next = *head;
    }
    else {
        struct Node* temp = *head;
        while (temp->next != *head) {
            temp = temp->next;
        }
        temp->next = newNode;
        newNode->next = *head;
    }
}

// Add node `q` after node `p`
void AddAfter(struct Node** head, struct Node* p, struct Node* q)
{
    if (*head == NULL || p == NULL || q == NULL) {
        printf("Invalid operation. List or nodes are NULL.\n");
        return;
    }

    struct Node* temp = *head;

    // Traverse to find node p in the circular list
    do {
        if (temp == p) {
            // Insert node q after node p
            q->next = p->next;
            p->next = q;
            return;
        }
        temp = temp->next;
    } while (temp != *head); 

    printf("Node with given pointer not found.\n");
}

void RemoveFirst(struct Node** head)
{
    if (*head == NULL) {
        return;
    }
    else if ((*head)->next == *head) {
        free(*head);
        *head = NULL;
    }
    else {
        struct Node* temp = *head;
        while (temp->next != *head) {
            temp = temp->next;
        }
        temp->next = (*head)->next;
        struct Node* toDelete = *head;
        *head = (*head)->next;
        free(toDelete);
    }
}

void RemoveLast(struct Node** head)
{
    if (*head == NULL) {
        return;
    }
    else if ((*head)->next == *head) {
        free(*head);
        *head = NULL;
    }
    else {
        struct Node* secondLast = *head;
        while (secondLast->next->next != *head) {
            secondLast = secondLast->next;
        }
        struct Node* last = secondLast->next;
        secondLast->next = *head;
        free(last);
    }
}

// Xóa node sau `p` trong danh sách liên k?t v?ng
void RemoveAfter(struct Node** head, struct Node* p)
{
    if (*head == NULL || p == NULL) {
        printf("Invalid operation. List or node p is NULL.\n");
        return;
    }

    struct Node* temp = *head;
    do {
        if (temp == p) {
            if (p->next == *head) {
                printf("No node to remove after the given node.\n");
                return;
            }

            struct Node* nodeToRemove = p->next;  
            p->next = nodeToRemove->next;  

            free(nodeToRemove);  
            return;
        }
        temp = temp->next;
    } while (temp != *head); 

    printf("Node with given pointer not found.\n");
}

// Tim kiem node:
// Function to search for a node with a given key
int Search(struct Node* head, int key)
{
    if (head == NULL) {
        return 0;
    }
    struct Node* temp = head;
    do {
        if (temp->data == key) {
            return 1; // Key found
        }
        temp = temp->next;
    } while (temp != head);
    return 0; // Key not found
}

// Tim kiem cac node theo tieu chi
void SearchNodesCondition(struct Node** head, const function<bool(int)>& condition) {
    if (head == NULL) {
        cout << "Danh sach rong." << endl;
        return;
    }
    struct Node* temp = *head;
    bool found = false;
    do {
        if (condition(temp->data)) { 
            cout << temp->data << " ";
            found = true;
        }
        temp = temp->next;
    } while (temp != *head);
    if (!found) {
        cout << "Khong co phan tu nao thoa man dieu kien.";
    }
    cout << endl;
}

// In danh sách
void PrintList(struct Node* head)
{
    if (IsEmpty(head)) {
        cout << "list rong, vui long them gia tri" << endl;
        return;
    }
    struct Node* temp = head;
    do {
        printf("%d -> ", temp->data);
        temp = temp->next;
    } while (temp != head);
    printf("HEAD\n");
}
// Hàm hoán ðoi giua 2 node
void SwapNodes(Node* a, Node* b) {
    if (a != NULL && b != NULL) {
        // Swap the elements
        Node temp = *a;
        *a = *b;
        *b = temp;

        // Restore next pointers
        Node* temnext = a->next;
        a->next = b->next;
        b->next = temnext;
    }
}


// Selection Sort
void SelectionSort(Node** head) {
    if (*head == NULL || (*head)->next == *head) return; // Danh sách r?ng ho?c có 1 node
    Node* temp1 = *head;
    do {
        Node* min = temp1;
        Node* temp2 = temp1->next;
        while (temp2 != *head) {
            if (temp2->data < min->data) {
                min = temp2;
            }
            temp2 = temp2->next;
        }
        SwapNodes(temp1, min);
        temp1 = temp1->next;
    } while (temp1 != *head);
}


Node* Partition(Node* low, Node* high) {
    int pivot = high->data;
    Node* i = low;
    Node* j = low;

    while (j != high) {
        if (j->data < pivot) {
            SwapNodes(i, j);
            i = i->next;
        }
        j = j->next;
    }
    SwapNodes(i, high);
    return i;
}

void QuickSortHelper(Node* low, Node* high) {
    if (low != high && low != NULL && high != NULL) {
        Node* p = Partition(low, high);

        Node* temp = low;
        while (temp->next != p) {
            temp = temp->next;
        }

        // Sort the left partition
        if (temp != low) {
            QuickSortHelper(low, temp);
        }

        // Sort the right partition
        if (p != high) {
            QuickSortHelper(p->next, high);
        }
    }
}

// Quick Sort
void QuickSort(Node** head) {
    if (*head == NULL) return;

    Node* tail = *head;
    while (tail->next != *head) {
        tail = tail->next;
    }

    QuickSortHelper(*head, tail);
}

void MergeLists(struct Node** list1, struct Node** list2) {
    if (*list1 == NULL) {
        *list1 = *list2;
        return;
    }
    if (*list2 == NULL) {
        return;
    }

    struct Node* tail1 = *list1;
    while (tail1->next != *list1) {
        tail1 = tail1->next;
    }

    struct Node* tail2 = *list2;
    while (tail2->next != *list2) {
        tail2 = tail2->next;
    }

    tail1->next = *list2;
    tail2->next = *list1;
}
// Remove all nodes satisfy condition
void RemoveAllSatisfying(struct Node** head, const function<bool(int)>& criteria) {
    if (*head == NULL) {
        cout << "Danh sach rong." << endl;
        return;
    }

    struct Node* current = *head;
    struct Node* prev = NULL;
    bool found = false;
    do {
        // N?u ph?n t? th?a m?n ði?u ki?n
        if (criteria(current->data)) {
            found = true;

            // Trý?ng h?p có m?t ph?n tu
            if (current->next == current) {
                free(current);
                *head = NULL;
                return;
            }

            // Trý?ng h?p xóa ph?n t? ð?u tiên (head)
            if (current == *head) {
                struct Node* temp = *head;
                // T?m ph?n t? cu?i danh sách
                while (temp->next != *head) {
                    temp = temp->next;
                }
                *head = current->next;
                temp->next = *head;
                free(current);
                current = *head;
            }
            // Trý?ng h?p xóa ph?n t? gi?a ho?c cu?i
            else {
                prev->next = current->next;
                free(current);
                current = prev->next;
            }
        }
        else {
            prev = current;
            current = current->next;
        }
    } while (current != *head);

    if (!found) {
        cout << "Khong co phan tu nao thoa man dieu kien." << endl;
    }
}

// Reverse the circular linked list
void ReverseList(struct Node** head) {
    if (*head == NULL || (*head)->next == *head) {
        return;
    }

    struct Node* prev = NULL;
    struct Node* current = *head;
    struct Node* next = NULL;

    do {
        next = current->next;
        current->next = prev;
        prev = current;
        current = next;
    } while (current != *head);

    (*head)->next = prev;
    *head = prev;
}

// Hàm chính
int main() {

    struct Node* myList1 = NULL;
    struct Node* myList2 = NULL;
    struct Node* mergedList = NULL;

    // Thêm các phan tu myList1
    AddFirst(&myList1, 11);
    AddFirst(&myList1, 9);
    AddFirst(&myList1, 1);
    AddFirst(&myList1, 12);
    AddFirst(&myList1, 3);
    AddFirst(&myList1, 20);

    // Thêm các phan tu myList2
    AddLast(&myList2, 5);
    AddLast(&myList2, 4);
    AddLast(&myList2, 11);
    AddLast(&myList2, 2);

    cout << "- Danh sach myList1: "<<endl;
    PrintList(myList1);
    cout << "- Danh sach myList2: " << endl;
    PrintList(myList2);
    cout << "--------------------------------" << endl;

    // Thêm phan tu o dau, cuoi, va sau node 
    AddFirst(&myList1, 15);
    AddLast(&myList1, 16);

    AddFirst(&myList2, 15);
    AddLast(&myList2, 16);

    // Them node 25 after node 20
    struct Node* node20 = myList1->next; 
    struct Node* node25 = createNode(25);
    AddAfter(&myList1, node20, node25);  // Cách g?i ðúng
    cout << "- Sau khi them addFirst,addAfter node 20,addLast vao myList1:" << endl;
    PrintList(myList1);
    cout << "--------------------------------" << endl;

    // Xóa các phan tu
    RemoveFirst(&myList1);
    RemoveLast(&myList1);
    struct Node* node3 = myList1->next;
    RemoveAfter(&myList1, node3); // Xóa node sau node có giá tr? 3
    cout << "- Sau khi xoa phan tu removeFirst,removeLast,removeAfter node 3 trong myList1:" << endl;
    PrintList(myList1);
    cout << "--------------------------------" << endl;

    // Tim kiem theo key
    int key = 12;
    if (Search(myList1, key)) {
        printf("Phan tu gia tri %d duoc tim thay\n",
            key);
    }
    else {
        printf(
            "Khon tim thay phan tu %d .\n",
            key);
    }
    cout << "--------------------------------" << endl;

    // Tim kiem phan tu theo dieu kien
    cout << "\n- Tim phan tu co gia tri la so chan trong myList1:" << endl;
    SearchNodesCondition(&myList1, [](int value) { return value % 2 == 0; }); // Tim so chan
    cout << "--------------------------------" << endl;

    // Sort the list
    cout << "- Tien hanh sap xep theo thuat toan SelectionSort, QuickSort:" << endl;
    cout << "+myList1 ban dau:";
    PrintList(myList1);
    cout << "Voi myList1 SelectionSort:";
    SelectionSort(&myList1);
    PrintList(myList1);
    cout << "+myList2 ban dau:";
    PrintList(myList2);
    cout << "Voi myList2 QuickSort:";
    QuickSort(&myList2);
    PrintList(myList2);
    cout << "--------------------------------" << endl;
    // 3 operations on the list
    // Merge two lists
    MergeLists(&myList1, &myList2);
    cout << "- Sau khi merge myList1 va myList2:" << endl;
    PrintList(myList1);
    cout << "--------------------------------" << endl;

    // Remove nodes satisfy the condition
    cout << "- Xoa tat ca gia tri chan trong chuoi gop" << endl;
    RemoveAllSatisfying(&myList1, [](int value) { return value % 2 == 0; });
    PrintList(myList1);
    cout << "--------------------------------" << endl;

    // Reverse
    cout << "- Dao nguoc chuoi:" << endl;
    ReverseList(&myList1);
    PrintList(myList1);
    cout << "--------------------------------" << endl;

    return 0;
}



// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
