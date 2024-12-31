#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

// Define the Node structure
typedef struct Node {
    int data;
    struct Node* next;
} Node;

Node* initializeList() {
    return NULL;
}

Node* createNode(int value) {
    Node* newNode = (Node*)malloc(sizeof(Node));
    newNode->data = value;
    newNode->next = newNode; // Circular reference
    return newNode;
}

bool isEmpty(Node* head) {
    return head == NULL;
}

void insertAtBeginning(Node** head, int value) {
    Node* newNode = createNode(value);
    if (*head == NULL) {
        *head = newNode;
    }
    else {
        Node* temp = *head;
        while (temp->next != *head) {
            temp = temp->next;
        }
        newNode->next = *head;
        temp->next = newNode;
        *head = newNode;
    }
}

void insertAtEnd(Node** head, int value) {
    Node* newNode = createNode(value);
    if (*head == NULL) {
        *head = newNode;
    }
    else {
        Node* temp = *head;
        while (temp->next != *head) {
            temp = temp->next;
        }
        temp->next = newNode;
        newNode->next = *head;
    }
}

void insertAfterNode(Node* head, int target, int value) {
    if (head == NULL) return;
    Node* temp = head;
    do {
        if (temp->data == target) {
            Node* newNode = createNode(value);
            newNode->next = temp->next;
            temp->next = newNode;
            return;
        }
        temp = temp->next;
    } while (temp != head);
}

void removeFirstNode(Node** head) {
    if (*head == NULL) return;
    Node* temp = *head;
    if ((*head)->next == *head) {
        free(*head);
        *head = NULL;
    }
    else {
        Node* tail = *head;
        while (tail->next != *head) {
            tail = tail->next;
        }
        *head = (*head)->next;
        tail->next = *head;
        free(temp);
    }
}

void removeLastNode(Node** head) {
    if (*head == NULL) return;
    Node* temp = *head;
    if ((*head)->next == *head) {
        free(*head);
        *head = NULL;
    }
    else {
        Node* prev = NULL;
        while (temp->next != *head) {
            prev = temp;
            temp = temp->next;
        }
        prev->next = *head;
        free(temp);
    }
}

void removeAfterNode(Node* head, int target) {
    if (head == NULL) return;
    Node* temp = head;
    do {
        if (temp->data == target && temp->next != head) {
            Node* toDelete = temp->next;
            temp->next = toDelete->next;
            free(toDelete);
            return;
        }
        temp = temp->next;
    } while (temp != head);
}

Node* searchNode(Node* head, int value) {
    if (head == NULL) return NULL;
    Node* temp = head;
    do {
        if (temp->data == value) return temp;
        temp = temp->next;
    } while (temp != head);
    return NULL;
}

void searchByCriteria(Node* head, int (*criteria)(int)) {
    if (head == NULL) return;
    Node* temp = head;
    do {
        if (criteria(temp->data)) {
            printf("%d ", temp->data);
        }
        temp = temp->next;
    } while (temp != head);
    printf("\n");
}

void printList(Node* head) {
    if (head == NULL) {
        printf("List is empty.\n");
        return;
    }
    Node* temp = head;
    do {
        printf("%d ", temp->data);
        temp = temp->next;
    } while (temp != head);
    printf("\n");
}

void selectionSort(Node** head) {
    if (*head == NULL) return;
    Node* start = *head;
    do {
        Node* min = start;
        Node* temp = start->next;
        while (temp != *head) {
            if (temp->data < min->data) {
                min = temp;
            }
            temp = temp->next;
        }
        int tempData = start->data;
        start->data = min->data;
        min->data = tempData;
        start = start->next;
    } while (start != *head);
}

Node* partition(Node* low, Node* high) {
    int pivot = high->data;
    Node* i = low;
    Node* j = low;

    while (j != high) {
        if (j->data < pivot) {
            i = (i == NULL) ? low : i->next;
            int temp = i->data;
            i->data = j->data;
            j->data = temp;
        }
        j = j->next;
    }
    i = (i == NULL) ? low : i->next;
    int temp = i->data;
    i->data = high->data;
    high->data = temp;
    return i;
}

void _quickSort(Node* head, Node* low, Node* high) {
    if (high != NULL && low != high && low != high->next) {
        Node* p = partition(low, high);
        _quickSort(head, low, p->next != low ? p : low);
        _quickSort(head, p->next, high);
    }
}

void quickSort(Node* head) {
    if (head == NULL || head->next == head) return;

    Node* last = head;
    while (last->next != head) {
        last = last->next;
    }

    _quickSort(head, head, last);
}

// Merge two circular linked lists
void mergeLists(Node** head1, Node* head2) {
    if (head2 == NULL) return;

    if (*head1 == NULL) {
        *head1 = head2;
    } else {
        Node* temp = *head1;
        while (temp->next != *head1) {
            temp = temp->next;
        }
        temp->next = head2;

        Node* tail = head2;
        while (tail->next != head2) {
            tail = tail->next;
        }
        tail->next = *head1;
    }
}

int conditionLessThan(int x, int conditionValue) {
    return x < conditionValue;
}

int conditionGreaterThan(int x, int conditionValue) {
    return x > conditionValue;
}

// Remove nodes based on a condition
void removeNodesByDynamicCondition(Node** head, int conditionChoice, int conditionValue) {
    int (*condition)(int, int) = NULL;
    if (conditionChoice == 1) {
        condition = conditionLessThan;
    } else if (conditionChoice == 2) {
        condition = conditionGreaterThan;
    } else {
        printf("Invalid choice.\n");
        return;
    }

    Node* temp = *head;
    Node* prev = NULL;
    do {
        if (condition(temp->data, conditionValue)) {
            if (prev == NULL) {
                removeFirstNode(head);
                temp = *head;
            } else {
                prev->next = temp->next;
                free(temp);
                temp = prev->next;
            }
        } else {
            prev = temp;
            temp = temp->next;
        }
    } while (temp != *head && *head != NULL);
}

// Reverse the list
void reverseList(Node** head) {
    if (*head == NULL || (*head)->next == *head) return;
    Node* prev = NULL;
    Node* current = *head;
    Node* next = NULL;
    Node* tail = *head;
    while (current->next != *head) {
        next = current->next;
        current->next = prev;
        prev = current;
        current = next;
    }
    current->next = prev;
    *head = current;
    tail->next = *head;
}

int main() {
    Node* head = initializeList();
    Node* head2 = initializeList();
    
    // Insert nodes into list 1
    insertAtBeginning(&head, 10);
    insertAtBeginning(&head, 20);
    insertAtBeginning(&head, 30);

    // Insert nodes into list 2
    insertAtBeginning(&head2, 40);
    insertAtBeginning(&head2, 50);

    int choice, value, target, conditionValue;
    bool running = true;
    
    while (running) {
        printf("\nCircular Linked List Menu:\n");
        printf("1. Print List\n");
        printf("2. Insert at Beginning\n");
        printf("3. Insert at End\n");
        printf("4. Insert After Node\n");
        printf("5. Remove First Node\n");
        printf("6. Remove Last Node\n");
        printf("7. Remove Node After Target\n");
        printf("8. Search Node\n");
        printf("9. Selection Sort\n");
        printf("10. Quick Sort\n");
        printf("11. Merge Lists\n");
        printf("12. Remove Nodes by Condition\n");
        printf("13. Reverse List\n");
        printf("0. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                printList(head);
                break;
            case 2:
                printf("Enter value to insert at beginning: ");
                scanf("%d", &value);
                insertAtBeginning(&head, value);
                break;
            case 3:
                printf("Enter value to insert at end: ");
                scanf("%d", &value);
                insertAtEnd(&head, value);
                break;
            case 4:
                printf("Enter target value: ");
                scanf("%d", &target);
                printf("Enter value to insert after target: ");
                scanf("%d", &value);
                insertAfterNode(head, target, value);
                break;
            case 5:
                removeFirstNode(&head);
                break;
            case 6:
                removeLastNode(&head);
                break;
            case 7:
                printf("Enter target value: ");
                scanf("%d", &target);
                removeAfterNode(head, target);
                break;
            case 8:
                printf("Enter value to search for: ");
                scanf("%d", &value);
                if (searchNode(head, value)) {
                    printf("Node found.\n");
                } else {
                    printf("Node not found.\n");
                }
                break;
            case 9:
                selectionSort(&head);
                break;
            case 10:
                quickSort(head);
                break;
            case 11:
                mergeLists(&head, head2);
                break;
            case 12:
                printf("\nSelect a condition for removal:\n");
                printf("1. Remove nodes with value less than a specific value\n");
                printf("2. Remove nodes with value greater than a specific value\n");
                printf("Choose condition: ");
                int conditionChoice;
                scanf("%d", &conditionChoice);

                printf("Enter value to compare: ");
                int conditionValue;
                scanf("%d", &conditionValue);

                removeNodesByDynamicCondition(&head, conditionChoice, conditionValue);
                break;
            case 13:
                reverseList(&head);
                break;
            case 0:
                running = false;
                break;
            default:
                printf("Invalid choice.\n");
        }
    }
    return 0;
}
