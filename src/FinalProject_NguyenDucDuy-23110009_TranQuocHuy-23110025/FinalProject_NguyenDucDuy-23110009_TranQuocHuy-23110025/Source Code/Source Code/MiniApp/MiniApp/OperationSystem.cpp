#include <stdio.h>
#include <stdlib.h>

// Create a node
struct Node {
    int data;
    struct Node* next;
};

// Check whether a node is empty or not
int isEmpty(struct Node* node) {
    return node == NULL;
}

// Insert a new node at the beggining of the list
void addFirst(struct Node** tail, int value) {
    struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
    newNode->data = value;
    if (*tail == NULL) {
        *tail = newNode;
        newNode->next = newNode;
    }
    else {
        newNode->next = (*tail)->next;
        (*tail)->next = newNode;
    }
}

// Insert a new node at the end of the list
void addLast(struct Node** tail, int value) {
    struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
    newNode->data = value;
    if (*tail == NULL) {
        *tail = newNode;
        newNode->next = newNode;
    }
    else {
        newNode->next = (*tail)->next;
        (*tail)->next = newNode;
        *tail = newNode;
    }
}

// Insert a new node after a node of the list
void addAfter(struct Node** tail, int value, int x) {
    if (*tail == NULL) {
        printf("List is null, cannnot add node\n");
        return;
    }
    struct Node* current = (*tail)->next;
    do {
        if (current->data == x) {
            struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
            newNode->data = value;
            newNode->next = current->next;
            current->next = newNode;
            if (current == *tail) {
                *tail = newNode;
            }
            return;
        }
        current = current->next;
    } while (current != (*tail)->next);
    printf("Cannot find the node has value %d!\n", x);
}

// Remove the first node of the list

void removeFirst(struct Node** tail) {
    if (*tail == NULL) {
        printf("List is null, cannnot delete\n");
        return;
    }
    struct Node* head = (*tail)->next;
    if (head == *tail) {
        free(head);
        *tail = NULL;
    }
    else {
        (*tail)->next = head->next;
        free(head);
    }
}

// Remove the last node of the list
void removeLast(struct Node** tail) {
    if (*tail == NULL) {
        printf("List is null, cannnot delete\n");
        return;
    }
    struct Node* head = (*tail)->next;
    if (head == *tail) {
        free(head);
        *tail = NULL;
    }
    else {
        struct Node* current = head;
        while (current->next != *tail) {
            current = current->next;
        }
        current->next = head;
        free(*tail);
        *tail = current;
    }
}
// Remove a node after a node of the list
void removeAfter(struct Node** tail, int x) {
    if (*tail == NULL) {
        printf("List is null, cannnot delete\n");
        return;
    }

    struct Node* current = (*tail)->next;
    do {
        if (current->data == x) {
            if (current->next == current) {
                printf("There is no node after the node that has a value %d to delete!\n", x);
                return;
            }

            struct Node* temp = current->next;
            current->next = temp->next;

            if (temp == *tail) {
                *tail = current;
            }

            free(temp);
            printf("Deleted the node after the %d.\n", x);
            return;
        }
        current = current->next;
    } while (current != (*tail)->next);

    printf("Cannot find node with value %d!\n", x);
}
// Search a node in the list
struct Node* search(struct Node* tail, int x) {
    if (tail == NULL) {
        printf("List is null\n");
        return NULL;
    }
    struct Node* current = tail->next;
    do {
        if (current->data == x) {
            return current;
        }
        current = current->next;
    } while (current != tail->next);
    printf("Cannot find node with value %d!\n", x);
    return NULL;
}

// search nodes is even number
void searchEven(struct Node* tail) {
    if (tail == NULL) {
        printf("List is null\n");
        return;
    }
    struct Node* current = tail->next;
    printf("Nodes have even number: ");
    do {
        if (current->data % 2 == 0) {
            printf("%d ", current->data);
        }
        current = current->next;
    } while (current != tail->next);
    printf("\n");
}

// search nodes is odd number
void searchOdd(struct Node* tail) {
    if (tail == NULL) {
        printf("List is null\n");
        return;
    }
    struct Node* current = tail->next;
    printf("Nodes have odd number: ");
    do {
        if (current->data % 2 != 0) {
            printf("%d ", current->data);
        }
        current = current->next;
    } while (current != tail->next);
    printf("\n");
}

// Print the list
void display(struct Node* tail) {
    if (tail == NULL) {
        printf("List is null\n");
        return;
    }
    struct Node* current = tail->next;
    do {
        printf("%d ", current->data);
        current = current->next;
    } while (current != tail->next);
    printf("\n");
}

//Merge Two Circular Linked Lists
struct Node* mergeCircularLists(struct Node* tail1, struct Node* tail2) {
    if (!tail1) return tail2;
    if (!tail2) return tail1;

    struct Node* head1 = tail1->next;
    struct Node* head2 = tail2->next;

    tail1->next = head2;
    tail2->next = head1;

    return tail2;
}

// Reverse a Circular Linked List
void reverseCircularList(struct Node** tail) {
    if (*tail == NULL || (*tail)->next == *tail) return;

    struct Node* prev = NULL;
    struct Node* current = (*tail)->next;
    struct Node* next = NULL;
    struct Node* head = (*tail)->next;

    do {
        next = current->next;
        current->next = prev;
        prev = current;
        current = next;
    } while (current != head);

    head->next = prev;
    *tail = head;
}

// Check If Two Circular Linked Lists Are Identical
int areIdentical(struct Node* tail1, struct Node* tail2) {
    if (!tail1 && !tail2) return 1;
    if (!tail1 || !tail2) return 0;

    struct Node* current1 = tail1->next;
    struct Node* current2 = tail2->next;

    do {
        if (current1->data != current2->data) return 0;
        current1 = current1->next;
        current2 = current2->next;
    } while (current1 != tail1->next && current2 != tail2->next);

    return (current1 == tail1->next && current2 == tail2->next);
}

//Selection Sort
void selectionSort(struct Node* tail) {
    if (tail == NULL) return;

    struct Node* current = tail->next;
    do {
        struct Node* minNode = current;
        struct Node* temp = current->next;
        do {
            if (temp->data < minNode->data) {
                minNode = temp;
            }
            temp = temp->next;
        } while (temp != tail->next);

        if (minNode != current) {
            int tempData = current->data;
            current->data = minNode->data;
            minNode->data = tempData;
        }
        current = current->next;
    } while (current != tail->next);
}

// Quick Sort
struct Node* partition(struct Node* start, struct Node* end) {
    int pivot = end->data;
    struct Node* i = start;
    struct Node* j = start;
    while (j != end) {
        if (j->data <= pivot) {
            int temp = i->data;
            i->data = j->data;
            j->data = temp;
            i = i->next;
        }
        j = j->next;
    }
    int temp = i->data;
    i->data = end->data;
    end->data = temp;
    return i;
}




void quickSort(struct Node* start, struct Node* end) {
    if (start != end && start != NULL && end != NULL) {
        struct Node* pivot = partition(start, end);
        struct Node* temp = start;
        while (temp->next != pivot) {
            temp = temp->next;
        }
        quickSort(start, temp);
        quickSort(pivot->next, end);
    }
}


void moveForward(struct Node** tail) {
    if (*tail == NULL || (*tail)->next == *tail) return; 
}

int main() {
    struct Node* tail = NULL;

    addLast(&tail, 10);
    addFirst(&tail, 20);
    addLast(&tail, 30);
    addLast(&tail, 21);
    addLast(&tail, 24);
    addFirst(&tail, 13);

    printf("Circular linked list: ");
    display(tail);

    struct Node* result = search(tail, 20);
    if (result != NULL) {
        printf("The value of the node: %d\n", result->data);
    }
    else {
        printf("Cannot find the node that you found!\n");
    }

    searchEven(tail);

    searchOdd(tail);

    printf("The list after using Selection Sort: ");
    selectionSort(tail);
    display(tail);

    printf("The list after using Quick Sort: ");
    quickSort(tail->next, tail);
    display(tail);

    reverseCircularList(&tail);
    printf("The list after reserve: ");
    display(tail);

    struct Node* tail2 = NULL;
    addLast(&tail2, 100);
    addLast(&tail2, 200);
    tail = mergeCircularLists(tail, tail2);
    printf("The list after merge: ");
    display(tail);

    return 0;
}
