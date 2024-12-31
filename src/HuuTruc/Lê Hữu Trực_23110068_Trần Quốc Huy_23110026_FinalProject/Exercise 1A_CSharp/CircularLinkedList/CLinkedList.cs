using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using TYPE = System.Int32;

namespace CircularLinkedList
{
    public class CLinkedList
    {
        Node head;
        Node tail;

        public Node Tail { get => tail; set => tail = value; }
        public Node Head { get => head; set => head = value; }

        public CLinkedList()
        {
            head = null;
            tail = null;
        }

        public bool empty()
        {
            if (head == null) return true;
            return false;
        }
        public void add_back(Node newNode)
        {
            if (newNode == null) throw new Exception("New node cannot be null");
            //empty list
            if (empty())
            {
                head = newNode;
                tail = newNode;
                tail.Next = newNode;
                return;
            }
            //normal case
            newNode.Next = head;
            tail.Next = newNode;
            tail = newNode;
        }
        public void add_back(TYPE newValue)
        {
            add_back(new Node(newValue));
        }
        public void add_first(Node newNode)
        {
            if (newNode == null) throw new Exception("New node cannot be null");
            //empty list
            if (empty())
            {
                head = newNode;
                tail = newNode;
                tail.Next = newNode;
                return;
            }
            //normal case
            newNode.Next = head;
            tail.Next = newNode;
            head = newNode;
        }
        public void add_first(TYPE newValue)
        {
            add_first(new Node(newValue));
        }
        public void add_after_value(Node newNode, TYPE position)
        {
            if (newNode == null)
                throw new Exception("New node cannot be null");

            //empty
            if (empty())
            {
                throw new Exception("Cannot add after in an empty list");
            }

            Node tmp = head;
            do
            {
                if (tmp.Info == position)
                {
                    //last node
                    if (tmp == tail)
                    {
                        add_back(newNode);
                        return;
                    }

                    //normal case
                    newNode.Next = tmp.Next;
                    tmp.Next = newNode;
                    return;
                }
                tmp = tmp.Next;
            } while (tmp != head); //if tmp = head --> end

            //if exit the loop --> pos not found
            throw new Exception("Position not found in the list!");
        }
        public void add_after(Node addAfterNode, Node newNode)
        {
            if (newNode == null)
            {
                throw new ArgumentException("New node cannot be null");
            }

            // Empty list | 1 node | Last node
            if (empty() || Head == Tail || addAfterNode == Tail)
            {
                add_back(newNode);
                return;
            }

            // Normal case
            newNode.Next = addAfterNode.Next;
            addAfterNode.Next = newNode;
        }

        public void remove_back()
        {
            //empty
            if (empty()) throw new Exception("The list is empty!");
            //1 node
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
            //normal case
            Node tmp = head;
            do
            {
                if (tmp.Next == tail)
                {
                    tmp.Next = head;
                    tail = tmp;
                    return;
                }
                tmp = tmp.Next;
            } while (tmp != head);
        }
        public void remove_first()
        {
            //empty
            if (empty()) throw new Exception("The list is empty!");
            //1 node
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
            //normal case
            head = head.Next;
            tail.Next = head;
        }
        public void remove_after(Node removeAfterNode)
        {
            //empty
            if (empty())
            {
                throw new Exception("Empty list!");
            }

            if (removeAfterNode == null)
            {
                throw new Exception("Invalid node!");
            }

            //one node
            if (Head == Tail && removeAfterNode == Head)
            {
                Head = null;
                Tail = null;
                return;
            }

            Node nodeToRemove = removeAfterNode.Next;
            if (nodeToRemove == Head)
            {
                Head = nodeToRemove.Next;
            }
            if (nodeToRemove == Tail)
            {
                Tail = removeAfterNode;
            }

            //remove the node
            removeAfterNode.Next = nodeToRemove.Next;
            nodeToRemove = null; 
        }

        public void remove_after(TYPE position)
        {
            //empty
            if (empty()) throw new Exception("Cannot remove after in an empty list");
            //1 node
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
            //normal case
            Node tmp = head;
            do
            {
                if (tmp.Info == position) {
                    if (tmp.Next == tail)
                    {
                        remove_back();
                        return;
                    }
                    if (tmp == tail)
                    {
                        remove_first();
                        return;
                    }
                    tmp.Next = tmp.Next.Next;
                    return;
                }
                tmp = tmp.Next;
            } while (tmp != head);
            throw new Exception("Position not found in the list!");
        }
        public void remove(Node removeNode)
        {
            if (removeNode == null) throw new Exception("Invalid node!");
            if (!find(removeNode)) throw new Exception("Node not found in the list!");

            // Case 1: Only one node in the list
            if (head == tail && head == removeNode)
            {
                head = null;
                tail = null;
                return;
            }

            // Case 2: Removing the head		info	5	int

            if (removeNode == head)
            {
                remove_first();
                return;
            }

            // Case 3: Removing the tail
            if (removeNode == tail)
            {
                remove_back();
                return;
            }

            // Case 4: Removing a middle node
            Node current = head;
            do
            {
                if (current.Next == removeNode)
                {
                    current.Next = current.Next.Next; // Bypass the node
                    return;
                }
                current = current.Next;
            } while (current != head); // Traverse the list

            throw new Exception("Node not found!");
        }
        public void remove_all()
        {
            while (head != null)
            {
                remove_back();
            }
        }
        //public void remove_larger(TYPE value)
        //{
        //    if (empty()) throw new Exception("The list is empty!");

        //    bool foundLarger; // Flag to check if a larger value was found in the current iteration

        //    do
        //    {
        //        foundLarger = false;
        //        Node current = head;
        //        Node previous = null;

        //        if (head == null) break; // If the list becomes empty during execution

        //        do
        //        {
        //            Node nextNode = current.Next; // Store the next node before possible removal

        //            if (current.Info.CompareTo(value) > 0) // If current node's value is larger
        //            {
        //                foundLarger = true; // Set the flag since we found a larger value

        //                if (current == head)
        //                {
        //                    // Special case: removing the head
        //                    remove(current);
        //                    current = nextNode;
        //                    if (!empty())
        //                        head = current; // Update head after removal
        //                    else return;
        //                }
        //                else
        //                {
        //                    remove(current);
        //                    current = nextNode;
        //                }
        //            }
        //            else
        //            {
        //                previous = current;
        //                current = nextNode;
        //            }
        //        } while (current != head && current != null); // Stop when completing the circle or list becomes empty

        //    } while (found_larger(value)); // Repeat the process if a larger value was found
        //}
        public void remove_larger(TYPE value)
        {
            if (empty())
            {
                throw new InvalidOperationException("The list is empty!");
            }

            Node current = Head;
            bool foundLarger = false;

            do
            {
                Node nextNode = current.Next;

                if (current.Info > value)
                {
                    foundLarger = true;
                    remove(current);  // Remove the current node from the list
                    current = nextNode;  // Move to the next node after removal
                }
                else
                {
                    current = nextNode;
                }

            } while (current != Head && Head != null);  // Iterate until we come back to the head

            if (foundLarger && head != null)
            {
                remove_larger(value);  // Repeat if larger values were found
            }
        }

        public Node find(TYPE value)
        {
            if (head == null) throw new Exception("The list is empty!");
            Node tmp = head;
            do
            {
                if (tmp.Info == value) return tmp;
                tmp = tmp.Next;
            } while (tmp != head);
            throw new Exception("Not exist");
        }
        public bool find(Node node)
        {
            Node tmp = head;
            do
            {
                if (node == tmp) return true;
                tmp = tmp.Next;
            } while (tmp != head);
            return false;
        }
        public bool found_larger(TYPE value)
        {
            Node tmp = head;
            do
            {
                if (value < tmp.Info) return true;
                tmp = tmp.Next;
            } while (tmp != head);
            return false;
        }
        public int count(TYPE value)
        {
            int c = 0;
            Node tmp = head;
            do
            {
                if (tmp.Info == value) c++;
                tmp = tmp.Next;
            } while(tmp != head);
            return c;
        }
        public int count()
        {
            int c = 0;
            Node tmp = head;
            do
            {
                c++;
                tmp = tmp.Next;
            } while (tmp != head);
            return c;
        }
        public void reverse()
        {
            if (head == null) throw new Exception("Empty list");
            if (head == tail) return;

            Node prev = null;
            Node current = head;
            Node next = null;
            Node lastNode = tail; //save the original tail

            do
            {
                next = current.Next; //store the next node
                current.Next = prev; //reverse the current link
                prev = current;      //move prev to the current node
                current = next;      //move current to the next node
            } while (current != head); 

            //change head and tail
            tail = head; 
            tail.Next = prev; 
            head = prev; 
        }
        public void merge(CLinkedList addList)
        {
            if (head == null)
            {
                Node tmp = addList.Head;
                do
                {
                    add_back(new Node(tmp.Info));
                    tmp = tmp.Next;
                } while (tmp != addList.head);
                return;
            }
            if (addList.empty()) throw new Exception("The input list is empty");
            addList.Tail.Next = head;
            tail.Next = addList.Head;
            tail = addList.Tail;
        }
        public CLinkedList find_greater(TYPE value)
        {
            CLinkedList list = new CLinkedList();
            Node tmp = head;
            do
            {
                if (tmp.Info > value) list.add_back(new Node(tmp.Info));
                tmp = tmp.Next;
            } while (tmp != head);
            if (!list.empty()) return list;
            throw new Exception("Not exist");
        }
        public IEnumerable<Node> find_greater_e(TYPE value)
        {
            if (head == null) yield break;

            Node temp = head;
            do
            {
                if (temp.Info > value)
                    yield return temp;
                temp = temp.Next;
            } while (temp != head);
        }
        public void cpyList(CLinkedList a)
        {
            var tmp = a.Head;
            if (tmp == null) return;
            do
            {
                add_back(new Node(tmp));
                tmp = tmp.Next;
            } while (tmp != a.Head);
        }
        public Node min()
        {
            if (empty()) throw new Exception("Empty List!");
            Node tmp = head;
            Node min = head;
            do
            {
                if (tmp.Info < min.Info) min = tmp;
                tmp = tmp.Next;
            } while (tmp != head);
            return min;
        }
        public CLinkedList selection_sort_asc()
        {
            if (empty()) throw new Exception("Empty list!");

            CLinkedList cpy = new CLinkedList();
            cpy.cpyList(this);

            CLinkedList sortedList = new CLinkedList();

            Node tmp = cpy.Head;
            while (cpy.Head != null) 
            {
                Node minNode = cpy.min();
                sortedList.add_back(new Node(minNode.Info));
                cpy.remove(minNode); 
            }

            return sortedList;
        }
        public CLinkedList quick_sort_des()
        {
            CLinkedList sortedList = new CLinkedList();
            sortedList.cpyList(this);
            sortedList.quick_sort_des_run();

            return sortedList;
        }
        public void quick_sort_des_run()
        {
            if (head == null || head.Next == head) return;

            TYPE pivot = Head.Info;

            CLinkedList T1 = new CLinkedList();
            CLinkedList T2 = new CLinkedList();
            CLinkedList T3 = new CLinkedList();

            Node tmp = Head;
            do
            {
                if (tmp.Info > pivot) T1.add_back(new Node(tmp.Info));
                else if (tmp.Info == pivot) T2.add_back(new Node(tmp.Info));
                else T3.add_back(new Node(tmp.Info));
                tmp = tmp.Next;
            } while (tmp != Head); 

            //sort each sub array
            T1.quick_sort_des_run();
            T3.quick_sort_des_run();

            head = null;

            //merge
            if (!T1.empty()) merge(T1);
            if (!T2.empty()) merge(T2);
            if (!T3.empty()) merge(T3);
        }
        public string print()
        {
            if (empty()) throw new Exception("Empty list");
            Node tmp = head;
            string output = "";
            do
            {
                output += tmp.Info + " ";
                tmp = tmp.Next;
            } while (tmp != head);
            return output;
        }
        public IEnumerable<Node> GetNodes()
        {
            if (head == null) yield break;

            Node temp = head;
            do
            {
                yield return temp;
                temp = temp.Next;
            } while (temp != head);
        }
        public override string ToString()
        {
            string output = "";
            Node temp = head;
            do
            {
                output += temp.Info + " -> ";
                temp = temp.Next;
            } while (temp != head);
            return output;
        }

    }
}
