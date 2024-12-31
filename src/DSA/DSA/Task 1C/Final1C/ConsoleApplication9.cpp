#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Book data type
typedef struct {
    int id;
    char title[100];
    char author[100];
    float price;
} Book;

// Node structure
typedef struct Node {
    Book data;
    struct Node* next;
} Node;

// Function prototypes
Node* initializeList();
Node* createNode(Book book);
int isEmpty(Node* head);
Node* insertAtBeginning(Node* head, Book book);
Node* insertAtEnd(Node* head, Book book);
Node* insertAfterNode(Node* head, Node* prevNode, Book book);
Node* removeFirst(Node* head);
Node* removeLast(Node* head);
Node* removeAfterNode(Node* head, Node* prevNode);
Node* searchById(Node* head, int id);
void searchByPriceRange(Node* head, float minPrice, float maxPrice);
void printList(Node* head);
Node* selectionSort(Node* head);
Node* quickSort(Node* head);
Node* mergeLists(Node* list1, Node* list2);
Node* removeByPriceRange(Node* head, float minPrice, float maxPrice);
int countNodes(Node* head);
float calculateAveragePrice(Node* head);

// Initialize list
Node* initializeList() {
    return NULL;
}

// Create new node
Node* createNode(Book book) {
    Node* newNode = (Node*)malloc(sizeof(Node));
    if (newNode != NULL) {
        newNode->data = book;
        newNode->next = newNode;  // Point to itself initially
    }
    return newNode;
}

// Check if empty
int isEmpty(Node* head) {
    return head == NULL;
}

// Insert at beginning
Node* insertAtBeginning(Node* head, Book book) {
    Node* newNode = createNode(book);
    if (newNode == NULL) return head;

    if (isEmpty(head)) {
        return newNode;
    }

    Node* temp = head;
    while (temp->next != head) {
        temp = temp->next;
    }

    newNode->next = head;
    temp->next = newNode;
    return newNode;
}

// Insert at end
Node* insertAtEnd(Node* head, Book book) {
    if (isEmpty(head)) {
        return insertAtBeginning(head, book);
    }

    Node* newNode = createNode(book);
    if (newNode == NULL) return head;

    Node* temp = head;
    while (temp->next != head) {
        temp = temp->next;
    }

    temp->next = newNode;
    newNode->next = head;
    return head;
}

// Insert after node
Node* insertAfterNode(Node* head, Node* prevNode, Book book) {
    if (prevNode == NULL) return head;

    Node* newNode = createNode(book);
    if (newNode == NULL) return head;

    newNode->next = prevNode->next;
    prevNode->next = newNode;

    return head;
}

// Remove first node
Node* removeFirst(Node* head) {
    if (isEmpty(head)) return NULL;

    if (head->next == head) {
        free(head);
        return NULL;
    }

    Node* temp = head;
    while (temp->next != head) {
        temp = temp->next;
    }

    Node* newHead = head->next;
    temp->next = newHead;
    free(head);
    return newHead;
}

// Remove last node
Node* removeLast(Node* head) {
    if (isEmpty(head)) return NULL;

    if (head->next == head) {
        free(head);
        return NULL;
    }
    Node* temp = head;
    Node* prev = NULL;

    while (temp->next != head) {
        prev = temp;
        temp = temp->next;
    }

    prev->next = head;
    free(temp);
    return head;
}

// Remove after node
Node* removeAfterNode(Node* head, Node* prevNode) {
    if (prevNode == NULL || prevNode->next == head) return head;

    Node* nodeToDelete = prevNode->next;
    prevNode->next = nodeToDelete->next;
    free(nodeToDelete);
    return head;
}

// Search by ID
Node* searchById(Node* head, int id) {
    if (isEmpty(head)) return NULL;

    Node* temp = head;
    do {
        if (temp->data.id == id) return temp;
        temp = temp->next;
    } while (temp != head);

    return NULL;
}

// Search by price range
void searchByPriceRange(Node* head, float minPrice, float maxPrice) {
    if (isEmpty(head)) return;

    Node* temp = head;
    do {
        if (temp->data.price >= minPrice && temp->data.price <= maxPrice) {
            printf("Book ID: %d, Title: %s, Price: %.2f\n",
                temp->data.id, temp->data.title, temp->data.price);
        }
        temp = temp->next;
    } while (temp != head);
}

// Print list
void printList(Node* head) {
    if (isEmpty(head)) {
        printf("List is empty\n");
        return;
    }

    Node* temp = head;
    do {
        printf("ID: %d, Title: %s, Author: %s, Price: %.2f\n",
            temp->data.id, temp->data.title, temp->data.author, temp->data.price);
        temp = temp->next;
    } while (temp != head);
}

// Selection Sort
Node* selectionSort(Node* head) {
    if (isEmpty(head) || head->next == head) return head;

    Node* current = head;
    do {
        Node* min = current;
        Node* temp = current->next;

        while (temp != head) {
            if (temp->data.id < min->data.id) {
                min = temp;
            }
            temp = temp->next;
        }

        if (min != current) {
            Book tempBook = current->data;
            current->data = min->data;
            min->data = tempBook;
        }

        current = current->next;
    } while (current != head);

    return head;
}

// Quick Sort (Helper functions)
Node* getTail(Node* head) {
    Node* temp = head;
    while (temp->next != head) {
        temp = temp->next;
    }
    return temp;
}

Node* partition(Node* head, Node* tail, Node** newHead, Node** newTail) {
    Node* pivot = tail;
    Node* prev = NULL;
    Node* current = head;
    Node* end = pivot;

    while (current != pivot) {
        if (current->data.id <= pivot->data.id) {
            if (*newHead == NULL) {
                *newHead = current;
            }
            prev = current;
            current = current->next;
        }
        else {
            if (prev) {
                prev->next = current->next;
            }
            Node* temp = current->next;
            current->next = NULL;
            end->next = current;
            end = current;
            current = temp;
        }
    }

    if (*newHead == NULL) {
        *newHead = pivot;
    }

    *newTail = end;
    return pivot;
}

// Quick Sort implementation
Node* quickSortRecursive(Node* head, Node* tail) {
    if (!head || head == tail) return head;

    Node* newHead = NULL;
    Node* newTail = NULL;

    Node* pivot = partition(head, tail, &newHead, &newTail);

    if (newHead != pivot) {
        Node* temp = newHead;
        while (temp->next != pivot) {
            temp = temp->next;
        }
        temp->next = NULL;

        newHead = quickSortRecursive(newHead, temp);

        temp = getTail(newHead);
        temp->next = pivot;
    }

    pivot->next = quickSortRecursive(pivot->next, newTail);

    return newHead;
}

Node* quickSort(Node* head) {
    if (isEmpty(head) || head->next == head) return head;

    Node* tail = getTail(head);
    head = quickSortRecursive(head, tail);
    tail = getTail(head);
    tail->next = head;

    return head;
}

// Additional Operations

// 1. Merge two lists
Node* mergeLists(Node* list1, Node* list2) {
    if (isEmpty(list1)) return list2;
    if (isEmpty(list2)) return list1;

    Node* tail1 = list1;
    while (tail1->next != list1) {
        tail1 = tail1->next;
    }

    Node* tail2 = list2;
    while (tail2->next != list2) {
        tail2 = tail2->next;
    }

    tail1->next = list2;
    tail2->next = list1;

    return list1;
}

// 2. Remove books in price range
Node* removeByPriceRange(Node* head, float minPrice, float maxPrice) {
    if (isEmpty(head)) return NULL;

    Node* current = head;
    Node* prev = NULL;

    do {
        if (current->data.price >= minPrice && current->data.price <= maxPrice) {
            if (current == head) {
                head = removeFirst(head);
                current = head;
            }
            else {
                current = current->next;
                removeAfterNode(head, prev);
            }
        }
        else {
            prev = current;
            current = current->next;
        }
    } while (current != head && !isEmpty(head));

    return head;
}

// 3. Count total nodes
int countNodes(Node* head) {
    if (isEmpty(head)) return 0;

    int count = 0;
    Node* temp = head;
    do {
        count++;
        temp = temp->next;
    } while (temp != head);

    return count;
}

// 4. Calculate average price
float calculateAveragePrice(Node* head) {
    if (isEmpty(head)) return 0.0f;

    float total = 0.0f;
    int count = 0;
    Node* temp = head;

    do {
        total += temp->data.price;
        count++;
        temp = temp->next;
    } while (temp != head);

    return total / count;
}

// Main function with example usage
int main() {
    Node* head = initializeList();

    // Example books
    Book book1 = { 1, "The Great Gatsby", "F. Scott Fitzgerald", 15.99 };
    Book book2 = { 2, "1984", "George Orwell", 12.99 };
    Book book3 = { 3, "Pride and Prejudice", "Jane Austen", 9.99 };

    // Insert books
    head = insertAtBeginning(head, book1);
    head = insertAtEnd(head, book2);
    head = insertAtEnd(head, book3);

    printf("Original List:\n");
    printList(head);

    printf("\nSorted List (Selection Sort):\n");
    head = selectionSort(head);
    printList(head);

    printf("\nBooks between $10 and $20:\n");
    searchByPriceRange(head, 10.0, 20.0);

    printf("\nTotal number of books: %d\n", countNodes(head));
    printf("Average book price: $%.2f\n", calculateAveragePrice(head));

    // Clean up
    while (!isEmpty(head)) {
        head = removeFirst(head);
    }

    return 0;
}