/* 
Final Project DSA
23110015 To Phat Dat
23______ Tong Gia Khanh
Develop a Circular linked list in which each node contains a proposed data type 
Sun, 22/12/2024, HCM city
*/

#include <iostream>
#include <string>
using namespace std;

// Structs: Clothes, NODE and Circular List -----------------------------
struct Clothes {
    string ID;
    string name;
    string type; //pant, short, shirt, jacket
    string size; // M S L X XL
    int price; // VND
};

struct NODE {
    Clothes data;
    NODE* nextNode;
    NODE* preNode;
};

struct CircularList {
    NODE* head;
    NODE* tail;
};

// Initialize structs functions ------------------------------------------
Clothes CreateNewClothes(string ID, string type, string name, string size, int price) {
    Clothes clothes;
    clothes.ID = ID;
    clothes.name = name;
    clothes.size = size;
    clothes.price = price;
    clothes.type = type;
    return clothes;
}

NODE* CreateNewNode(Clothes data) {
    NODE* newNode = new NODE();
    newNode->data = data;
    newNode->nextNode = nullptr;
    newNode->preNode = nullptr;
    // 2D node: null <- node -> null
    return newNode;
}

CircularList InitializeList(NODE* Head) {
    CircularList newList;
    newList.head = Head;
    newList.tail = nullptr;
    newList.head->nextNode = newList.head;
    newList.head->preNode = newList.head;
    return newList;
}

//Check functions --------------------------------------------------------
bool IsEmptyList(CircularList List) {
    return List.head == nullptr;
}

bool CheckID(Clothes clothes, string ID) {
    return clothes.ID == ID;
}

//Print functions --------------------------------------------------------
void PrintClothesInformation(Clothes data) {
    cout << "ID " << data.ID << ": " << data.type << "," << data.name << ", " << data.size << ", " << data.price << endl;
}

void PrintList(CircularList List) {
    NODE* temp = List.head;
    if(IsEmptyList(List)) {
        cout << "The list is empty! Please fill it." << endl;
    }
    else if(temp->nextNode == List.head) {
        PrintClothesInformation(temp->data);
    }
    else {
        do {
            PrintClothesInformation(temp->data);
            temp = temp->nextNode;
        } while ( temp != List.tail->nextNode);
    }
}

//Insert functions -------------------------------------------------------
void InsertAtBegin(NODE* newNode, CircularList& List) {
    if(IsEmptyList(List)) {
        List = InitializeList(newNode);
    }
    else if(List.head->nextNode == List.head)  {
            List.head->preNode = newNode;
            List.head->nextNode = newNode;
            List.tail = List.head;
            newNode->nextNode = List.tail;
            newNode->preNode = List.tail;
            List.head = newNode;
    }
    else {
        List.tail->nextNode = newNode;
        List.head->preNode = newNode;
        newNode->preNode = List.tail;
        newNode->nextNode = List.head;
        List.head = newNode;
    }
}

void InsertAtEnd(NODE* newNode, CircularList& List) {
    if(IsEmptyList(List)) {
        List = InitializeList(newNode);
    }
    else if(List.head->nextNode == List.head)  {
        List.tail = newNode;
        List.tail->nextNode = List.head;
        List.tail->preNode = List.head;
        List.head->nextNode = List.tail;
        List.head->preNode = List.tail;
    }
    else {
        List.tail->nextNode = newNode;
        List.head->preNode = newNode;
        newNode->nextNode = List.head;
        newNode->preNode = List.tail;
        List.tail = newNode;
    }
}

void InsertAfterNode(string ID, NODE* newNode, CircularList& List) {
    if (IsEmptyList(List)) {
        cout << "The list is empty! Do you want to insert the item to the list? Y/n" << endl;
        string choose;
        cin >> choose;
        if (choose == "Y") {
            InsertAtBegin(newNode, List);
        }
        return;
    }
    if (List.head->nextNode == List.head) {
        if (CheckID(List.head->data, ID)) {
            InsertAtEnd(newNode, List);
        } else {
            cout << "ID does not exist, please check again." << endl;
        }
        return;
    }
    NODE* temp = List.head;
    do {
        if (CheckID(temp->data, ID)) {
            break;
        }
        temp = temp->nextNode;
    } while (temp != List.head);

    if (!CheckID(temp->data, ID)) {
        cout << "ID does not exist, please check again." << endl;
        return;
    }
    newNode->nextNode = temp->nextNode;
    newNode->preNode = temp;
    temp->nextNode->preNode = newNode;
    temp->nextNode = newNode;
    if (temp == List.tail) {
        List.tail = newNode;
    }
}

//Remove functions -------------------------------------------------------
void RemoveAtFirst(CircularList& List){
    if(IsEmptyList(List)) {
        cout << "The list is empty! Please check again";
    }
    else if(List.head->nextNode == List.head) List.head = nullptr;
    else {
        List.head = List.head->nextNode;
        delete List.head->preNode;
        List.head->preNode = List.tail;
        List.tail->nextNode = List.head;
    }
};

void RemoveAtLast(CircularList& List){
    if(IsEmptyList(List)) {
        cout << "The list is empty! Please check again";
    }
    else if(List.head->nextNode == List.head) List.head = nullptr;
    else {
        List.tail = List.tail->preNode;
        delete List.tail->nextNode;
        List.tail->nextNode = List.head;
        List.head->preNode = List.tail;
    }
}

void RemoveAfterNode(string ID, CircularList& List) {
    if (IsEmptyList(List)) {
        cout << "The list is empty! Please check again." << endl;
        return;
    }
    NODE* temp = List.head;
    do {
        if (CheckID(temp->data, ID)) {
            break;
        }
        temp = temp->nextNode;
    } while (temp != List.head);
    
    if (!CheckID(temp->data, ID)) {
        cout << "ID does not exist, please check again." << endl;
        return;
    }
    if (temp->nextNode == temp) {
        cout << "The list has only one node. Nothing to remove after this node." << endl;
        return;
    }
    NODE* nodeToRemove = temp->nextNode;
    if (nodeToRemove == List.head) {
        List.head = nodeToRemove->nextNode;
    }
    if (nodeToRemove == List.tail) {
        List.tail = temp;
    }
    temp->nextNode = nodeToRemove->nextNode;
    nodeToRemove->nextNode->preNode = temp;
    delete nodeToRemove;
}


// Comparison funtions ------------------------------------------------------
bool ClothesSmallerComparison(Clothes a, Clothes b, string criteria) {
        return (criteria == "ID" && a.ID < b.ID) || (criteria == "type" && a.type < b.type)
            || (criteria == "size" && a.size < b.size) || (criteria == "price" && a.price < b.price)
            || (criteria == "name" && a.name < b.name);
}

bool ClothesEqualComparison(Clothes a, Clothes b, string criteria) {
    return (criteria == "ID" && a.ID == b.ID) || (criteria == "type" && a.type == b.type)
            || (criteria == "size" && a.size == b.size) || (criteria == "price" && a.price == b.price)
            || (criteria == "name" && a.name == b.name);
}

bool ClothesCheckCriteria(Clothes data, string criteria, string value) {
    if (criteria == "ID") {
        return data.ID == value;
    } else if (criteria == "type") {
        return data.type == value;
    } else if (criteria == "size") {
        return data.size == value;
    } else if (criteria == "name") {
        return data.name == value;
    } else if (criteria == "price") {
        try {
            int intValue = stoi(value);
            return data.price == intValue;
        } catch (...) {
            cout << "Invalid price value provided!" << endl;
            return false;
        }
    } else {
        cout << "Invalid criteria provided!" << endl;
        return false;
    }
}

// Sorting funtions ------------------------------------------------------
void SelectionSort(string criteria, CircularList& List) {
    string opt;
    cout << "Increasing or Decreasing? i/d: ";
    cin >> opt;
    if(IsEmptyList(List)) {
        cout << "List is empty! Check again!";
        return;
    }
    NODE* begin = List.head;
    if(opt == "i") {
        if(begin->nextNode == List.head) {
            delete begin;
            PrintList(List);
        }
        else {
            while (begin->nextNode != List.head) {
                NODE* minNode = begin;
                NODE* temp = begin->nextNode;
                do {
                    if(ClothesSmallerComparison(temp->data, minNode->data, criteria)) {
                        minNode = temp;
                    }
                    temp = temp ->nextNode;
                }
                while(temp != List.head);

                if(minNode != begin) {
                    Clothes beginData = begin->data;
                    begin->data = minNode->data;
                    minNode->data = beginData;
                }
                begin = begin->nextNode;
            }
        }
    }
    else {
        if(begin->nextNode == List.head) {
            delete begin;
            PrintList(List);
        }
        else {
            while (begin->nextNode != List.head) {
                NODE* maxNode = begin;
                NODE* temp = begin->nextNode;
                do {
                    if(!ClothesSmallerComparison(temp->data, maxNode->data, criteria)) {
                        maxNode = temp;
                    }
                    temp = temp ->nextNode;
                }
                while(temp != List.head);

                if(maxNode != begin) {
                    Clothes beginData = begin->data;
                    begin->data = maxNode->data;
                    maxNode->data = beginData;
                }
                begin = begin->nextNode;
            }
        }
    }
}


NODE* Partition(string criteria, NODE*& head, NODE*& tail) {
    Clothes pivotData = tail->data;
    NODE* i = head->preNode;  

    NODE* j = head;
    do {
        if (ClothesSmallerComparison(j->data, pivotData, criteria)) {
            i = (i == nullptr) ? head : i->nextNode; 
            swap(i->data, j->data);                
        }
        j = j->nextNode;
    } while (j != tail->nextNode); 

    i = (i == nullptr) ? head : i->nextNode;
    swap(i->data, tail->data); 
    if (i == head) head = i;
    if (i == tail) tail = i;

    return i;
}


void QuickSort(string criteria, NODE*& head, NODE*& tail) {
    if (head != tail && head->preNode != tail) { 
        NODE* pivot = Partition(criteria, head, tail);

        NODE* oldHead = head;
        NODE* oldTail = pivot->preNode;
        if (oldHead != pivot) {
            QuickSort(criteria, oldHead, oldTail);
        }

        NODE* newHead = pivot->nextNode;
        NODE* newTail = tail;
        if (newTail != pivot) {
            QuickSort(criteria, newHead, newTail);
        }
    }
}


void UseQuickSort(CircularList& List, string criteria) {
    if (IsEmptyList(List) || List.head == List.head->nextNode) {
        cout << "The list is empty or has only one element. Nothing to sort!" << endl;
        return;
    }
    else {
        QuickSort(criteria, List.head, List.tail);
    }
}

// SearchingFunctions-----------------------------------------------------
CircularList LinearSearchNode(CircularList& List, string criteria, Clothes clothes) {
    CircularList newList;
    NODE* begin = List.head;
    do {
        if(ClothesEqualComparison(begin->data, clothes, criteria)) {
            NODE* temp = begin;
            InsertAtEnd(temp, newList);
        }
        begin = begin->nextNode;
    }
    while(begin -> nextNode != begin);
    if(IsEmptyList(newList)) {
        cout << "Nothing exits";
    }
    return newList;
}

//Operations

void RemoveAll(CircularList& List, string criteria, string value) {
    if (IsEmptyList(List)) {
        cout << "The list is empty! Nothing to remove." << endl;
        return;
    }

    NODE* current = List.head;
    NODE* start = List.head; 

    do {
        NODE* nextNode = current->nextNode; 
        if (ClothesCheckCriteria(current->data, criteria, value)) {
            if (current == List.head) {
                if (current->nextNode == List.head) {
                    delete current;
                    List.head = nullptr;
                    List.tail = nullptr;
                    break;
                } else {
                    List.head = current->nextNode;
                    List.head->preNode = List.tail;
                    List.tail->nextNode = List.head;
                    delete current;
                    current = List.head;
                    start = List.head; 
                    continue; 
                }
            }
            else if (current == List.tail) {
                List.tail = current->preNode;
                List.tail->nextNode = List.head;
                List.head->preNode = List.tail;
                delete current;
            } else {
                current->preNode->nextNode = current->nextNode;
                current->nextNode->preNode = current->preNode;
                delete current;
            }
        }
        current = nextNode; 
    } while (current != start); 

    if (List.head != nullptr && List.head->nextNode == List.head &&
        ClothesCheckCriteria(List.head->data, criteria, value)) {
        delete List.head;
        List.head = nullptr;
        List.tail = nullptr;
    }
}

CircularList ConnectTwoList(CircularList a, CircularList b) {
    CircularList connectedList;

    if (IsEmptyList(a) && IsEmptyList(b)) {
        connectedList.head = nullptr;
        connectedList.tail = nullptr;
        cout << "All the lists are empty!" << endl;
        return connectedList;
    }

    if (IsEmptyList(a)) return b;
    if (IsEmptyList(b)) return a;

    a.tail->nextNode = b.head;
    b.head->preNode = a.tail;
    b.tail->nextNode = a.head;
    a.head->preNode = b.tail;

    connectedList.head = a.head;
    connectedList.tail = b.tail;

    return connectedList;
}

CircularList MergeTwoList(CircularList a, CircularList b, string criteria) {
    SelectionSort(criteria, a); 
    SelectionSort(criteria, b);
    PrintList(a);
    cout << endl;
    PrintList(b);
    cout << endl;

    CircularList mergedList = InitializeList(CreateNewNode(ClothesSmallerComparison
    (a.head->data, b.head->data, criteria) ? a.head->data : b.head->data));
    if (IsEmptyList(a) && IsEmptyList(b)) {
        mergedList.head = nullptr;
        mergedList.tail = nullptr;
        return mergedList;
    }

    if (IsEmptyList(a)) return b;
    if (IsEmptyList(b)) return a;

    NODE* currentA;
    NODE* currentB;
    if(ClothesEqualComparison(mergedList.head->data, a.head->data, criteria)) {
        currentA = a.head->nextNode;
        currentB = b.head;
    }
    else {
        currentA = a.head;
        currentB = b.head->nextNode;
    }

    do {
        if (ClothesSmallerComparison(currentA->data, currentB->data, criteria)) {
            InsertAtEnd(CreateNewNode(currentA->data), mergedList);
            currentA = currentA->nextNode;
        } else {
            InsertAtEnd(CreateNewNode(currentB->data), mergedList);
            currentB = currentB->nextNode;
        }
    } while (currentA != a.head && currentB != b.head);

    while (currentA != a.head) {
        InsertAtEnd(CreateNewNode(currentA->data), mergedList);
        currentA = currentA->nextNode;
    }

    while (currentB != b.head) {
        InsertAtEnd(CreateNewNode(currentB->data), mergedList);
        currentB = currentB->nextNode;
    }

    return mergedList;
}

Clothes EnterClothesValue() {
    cout << endl << "Create new item:" << endl;
    string ID;
    string name;
    string type;
    string size;
    int price;
    cout << "ID: ";
    cin >> ID;
    cout << endl << "Name: ";
    cin >> name;
    cout << endl << "Size(S, M, X, XL, XXL): ";
    cin >> size;
    cout << endl << "Type: ";
    cin >> type;
    cout << endl << "Price: ";
    cin >> price;
    cout << endl;
    return CreateNewClothes(ID, type, name, size, price);
}

CircularList EnterAnotherList() {
    int n;
    cout << "The number of item in new list: ";
    cin >> n;
    CircularList newList;
    while(n) {
        InsertAtEnd(CreateNewNode(EnterClothesValue()), newList);
        n--;
    }
    return newList;
}

void Application(CircularList& myList, CircularList& newList) {
    cout << "\n ---------------------------------------------------------------------------------" << endl;
    cout << "-----------------------  WELCOME TO THE SHOP  ------------------------" << endl;
    cout << "1. Check if the clothes list is empty or not. \n";
    cout << "2. Add an item x to the first position \n";
    cout << "3. Add an item x to the last position \n";
    cout << "4. Add an item x to the position k \n";
    cout << "5. Remove the first element \n";
    cout << "6. Remove the last element \n";
    cout << "7. Remove the element at position k \n";
    cout << "8. Search item x in the list \n";
    cout << "9. Search items larger than x in the list \n";
    cout << "s. Sort the list \n"; 
    cout << "p. Print the list \n";
    cout << "m. Merge two lists \n";
    cout << "e. Exit \n";
    cout << endl << "Choose your option here: ";
    char op;
    cin >> op;
    string ID;
    string criteria, value;
    switch (op)
    {
    case '1': 
        if(IsEmptyList(myList)) {
            cout << "The list is empty!" << endl;
        }
        else {
            cout << "The list is not empty!" << endl;
        }
        Application(myList, newList);
        break;
    case '2':
        InsertAtBegin(CreateNewNode(EnterClothesValue()), myList);
        cout << "Item is added";
        Application(myList, newList);
        break;
    case '3':
        InsertAtEnd(CreateNewNode(EnterClothesValue()), myList);
        cout << "Item is added";
        Application(myList, newList);
        break;
    case '4':
        cout << "The ID of item that you want to insert new item after: ";
        cin >> ID;
        InsertAfterNode(ID, CreateNewNode(EnterClothesValue()), myList);
        cout << "Item is added";
        Application(myList, newList);
        break;
    case '5':
        RemoveAtFirst(myList);
        cout << "Item is removed";
        Application(myList, newList);
        break;
    case '6':
        RemoveAtLast(myList);
        cout << "Item is removed";
        Application(myList, newList);
        break;
    case '7':
        cout << "The ID of item that you want to delete item after: ";
        cin >> ID;
        RemoveAfterNode(ID, myList);
        cout << "Item is removed";
        Application(myList, newList);
        break;
    case '8':
        cout << "The criteria: ";
        cin >> criteria;
        cout << "The value to search: ";
        PrintList(LinearSearchNode(myList, criteria, EnterClothesValue()));
        Application(myList, newList);
        break;
    case 's':
        cout << "Criteria: ";
        cin >> criteria;
        cout << "You want to sort by Selection sort or QuickSort? s/q: ";
        cin >> op;
        if(op == 's') SelectionSort(criteria, myList);
        else UseQuickSort(myList,criteria);
        cout << "The list after sorting: " << endl;
        PrintList(myList);
        Application(myList, newList);
        break;
    case 'p':
        PrintList(myList);
        Application(myList, newList);
        break;
    case 'm':
        cout << "Criteria: ";
        cin >> criteria;
        PrintList(MergeTwoList(myList, EnterAnotherList(), criteria));
        Application(myList, newList);
        break;
    case 'r':
        cout <<"Criteria: ";
        cin >> criteria;
        cout << "Value you want to remove: ";
        cin >> value;
        RemoveAll(myList, criteria, value);
        cout << "The list after removing: " << endl;
        PrintList(myList);
        Application(myList, newList);
        break;
    case 'e':
        break;
    default:
        Application(myList, newList);
        break;
    }
};

int main() {
    CircularList myList;
    CircularList anotherList;
    Application(myList, anotherList);
}



