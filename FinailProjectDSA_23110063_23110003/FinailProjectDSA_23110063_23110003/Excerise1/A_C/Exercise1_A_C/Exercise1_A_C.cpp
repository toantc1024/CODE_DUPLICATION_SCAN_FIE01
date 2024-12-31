#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Coffee {
    char name[50];
    float cost;
} Coffee;

typedef struct Node {
    Coffee data;
    struct Node* next;
} Node;

// Initialize the list 
Node* InitializeList() {
    return NULL;
}

// Create a new Coffee node
Node* CreateCoffee(Coffee coffee) {
    Node* newNode = (Node*)malloc(sizeof(Node));
    if (newNode != NULL) {
        newNode->data = coffee;
        newNode->next = newNode;
    }
    return newNode;
}

// Check whether a Coffee node is empty or not 
int IsEmpty(Node* head) {
    return head == NULL;
}

// Insert a new Coffee at the beginning of the list
void InsertAtTheBeginning(Node** head, Coffee coffee) {
    Node* newNode = CreateCoffee(coffee);
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

// Insert a new Coffee at the end of the list
void InsertAtTheEnd(Node** head, Coffee coffee) {
    Node* newNode = CreateCoffee(coffee);
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

// Insert a new Coffee after a Coffee we choose of the list 
void InsertAfter(Node* head, Coffee coffee, char* afterName) {
    if (head == NULL) return;
    Node* temp = head;
    do {
        if (strcmp(temp->data.name, afterName) == 0) {
            Node* newNode = CreateCoffee(coffee);
            newNode->next = temp->next;
            temp->next = newNode;
            return;
        }
        temp = temp->next;
    } while (temp != head);
}

// Remove the first Coffee of the list
void RemoveFirst(Node** head) {
    if (*head == NULL) return;
    Node* temp = *head;
    if (temp->next == *head) {
        free(temp);
        *head = NULL;
    }
    else {
        Node* last = *head;
        while (last->next != *head) {
            last = last->next;
        }
        *head = (*head)->next;
        last->next = *head;
        free(temp);
    }
}

// Remove the last Coffee of the list
void RemoveLast(Node** head) {
    if (*head == NULL) return;
    Node* temp = *head;
    if (temp->next == *head) {
        free(temp);
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

// Remove a Coffee after a Coffee we choose of the list
void RemoveAfter(Node* head, char* afterName) {
    if (head == NULL) return;
    Node* temp = head;
    do {
        if (strcmp(temp->data.name, afterName) == 0) {
            Node* toRemove = temp->next;
            if (toRemove != head) {
                temp->next = toRemove->next;
                free(toRemove);
            }
            return;
        }
        temp = temp->next;
    } while (temp != head);
}

//Search a Coffee in the list by name
Node* SearchName(Node* head, char* name) {
    if (head == NULL) return NULL;
    Node* temp = head;
    do {
        if (strcmp(temp->data.name, name) == 0) {
            return temp;
        }
        temp = temp->next;
    } while (temp != head);
    return NULL;
}

//Search a Coffee in the list by cost
void SearchCost(Node* head, float costThreshold) {
    if (head == NULL) return;
    Node* temp = head;
    do {
        if (temp->data.cost > costThreshold) {
            printf("%s: %.2f\n", temp->data.name, temp->data.cost);
        }
        temp = temp->next;
    } while (temp != head);
}

// Print the list
void PrintList(Node* head) {
    if (head == NULL) {
        printf("List is empty\n");
        return;
    }
    Node* temp = head;
    do {
        printf("%s: %.2f\n", temp->data.name, temp->data.cost);
        temp = temp->next;
    } while (temp != head);
}

// Selection Sort
void SelectionSort(Node** head) {
    if (*head == NULL) return;
    Node* i = *head;
    do {
        Node* min = i;
        Node* j = i->next;
        while (j != *head) {
            if (j->data.cost < min->data.cost) {
                min = j;
            }
            j = j->next;
        }
        if (min != i) {
            Coffee temp = i->data;
            i->data = min->data;
            min->data = temp;
        }
        i = i->next;
    } while (i->next != *head);
}

// QuickSort
void QuickSort(Node** head) {
    if (*head == NULL || (*head)->next == *head) return;

    Node* pivot = *head;
    Node* lowHead = NULL, * highHead = NULL;
    Node* current = pivot->next;

    do {
        Node* next = current->next;
        if (current->data.cost < pivot->data.cost) {
            current->next = NULL;
            InsertAtTheEnd(&lowHead, current->data);
        }
        else {
            current->next = NULL;
            InsertAtTheEnd(&highHead, current->data);
        }
        current = next;
    } while (current != *head);

    QuickSort(&lowHead);
    QuickSort(&highHead);

    *head = lowHead;
    if (lowHead != NULL) {
        Node* temp = lowHead;
        while (temp->next != lowHead) {
            temp = temp->next;
        }
        temp->next = pivot;
    }
    else {
        *head = pivot;
    }

    pivot->next = highHead;
    if (highHead != NULL) {
        Node* temp = highHead;
        while (temp->next != highHead) {
            temp = temp->next;
        }
        temp->next = *head;
    }
    else {
        pivot->next = *head;
    }
}

// Reverse the list
void ReverseList(Node** head) {
    if (*head == NULL) return;
    Node* prev = NULL;
    Node* current = *head;
    Node* next = NULL;
    do {
        next = current->next;
        current->next = prev;
        prev = current;
        current = next;
    } while (current != *head);
    current->next = prev;
    *head = prev;
}
// Delete the entire list
void DeleteList(Node** head) {
    if (*head == NULL) return;
    Node* temp = *head;
    Node* next = NULL;
    do {
        next = temp->next;
        free(temp);
        temp = next;
    } while (temp != *head);
    *head = NULL;
}

int main() {
    Node* coffeeList = InitializeList();

    Coffee c1 = { "Espresso", 50000 };
    Coffee c2 = { "Latte", 40000 };
    Coffee c3 = { "Cappuccino", 30000 };
    Coffee c4 = { "Matcha", 90000 };
    Coffee c5 = { "Cacao", 60000 };
    Coffee c6 = { "Lavie", 6000 };
    Coffee c7 = { "Soda", 20000 };

    InsertAtTheEnd(&coffeeList, c1);
    InsertAtTheBeginning(&coffeeList, c2);
    InsertAtTheEnd(&coffeeList, c3);
    InsertAtTheBeginning(&coffeeList, c4);
    InsertAtTheEnd(&coffeeList, c5);
    InsertAtTheBeginning(&coffeeList, c6);
    InsertAtTheEnd(&coffeeList, c7);
    PrintList(coffeeList);

    /*   printf("After Remove First:\n");
       RemoveFirst(&coffeeList);
       PrintList(coffeeList);*/

       //printf("After Remove Last:\n");
       //RemoveLast(&coffeeList);
       //PrintList(coffeeList);

       //printf("After Remove After:\n");
       //RemoveAfter(coffeeList, (char*)"Cappuccino");
       //PrintList(coffeeList);

       //SearchName(coffeeList, (char*)"Matcha");

       //SearchCost(coffeeList, 50000);

       //printf("After Selection Sort:\n");
       //SelectionSort(&coffeeList);
       //PrintList(coffeeList);

       //printf("After Quick Sort:\n");
       //QuickSort(&coffeeList);
       //PrintList(coffeeList);

       //printf("After Reverse List:\n");
       //ReverseList(&coffeeList);
       //PrintList(coffeeList);

       //printf("After Delete List:\n");
       //DeleteList(&coffeeList);
       //PrintList(coffeeList);

    return 0;
}