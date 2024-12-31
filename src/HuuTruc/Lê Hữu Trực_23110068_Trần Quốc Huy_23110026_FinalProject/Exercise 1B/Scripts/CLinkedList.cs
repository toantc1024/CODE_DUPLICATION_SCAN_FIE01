using UnityEngine;

public class CLinkedList 
{
    public ONode head;
    public ONode tail;

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

    public void add_back(ONode newNode)
    {
        if (newNode == null) return; 

        if (empty())
        {
            head = newNode;
            tail = newNode;
            tail.next = newNode;
            return;
        }
        //normal case
        newNode.next = head;
        tail.next = newNode;
        tail = newNode;
    }

    public GameObject get_next_obstacle()
    {
        if (head == null)
        {
            return null;
        }

        GameObject currentObstacle = head.obstacle;
        head = head.next; 
        return currentObstacle;
    }

    public void remove_back()
    {
        //empty
        if (empty()) return;
        //1 node
        if (head == tail)
        {
            head = null;
            tail = null;
            return;
        }
        //normal case
        ONode tmp = head;
        do
        {
            if (tmp.next == tail)
            {
                tmp.next = head;
                tail = tmp;
                return;
            }
            tmp = tmp.next;
        } while (tmp != head);
    }

    public void remove_first()
    {
        //empty
        if (empty()) return;
        //1 node
        if (head == tail)
        {
            head = null;
            tail = null;
            return;
        }
        //normal case
        head = head.next;
        tail.next = head;
    }
    
    public void remove(ONode removeNode)
    {
        if (removeNode == null) return;

        // Case 1: Only one node in the list
        if (head == tail && head == removeNode)
        {
            head = null;
            tail = null;
            return;
        }

        // Case 2: Removing the head
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
        ONode current = head;
        do
        {
            if (current.next == removeNode)
            {
                current.next = current.next.next; // Bypass the node
                return;
            }
            current = current.next;
        } while (current != head); // Traverse the list

    }
    public void reverse()
    {
        // Kiểm tra nếu danh sách rỗng hoặc chỉ có 1 nút thì không cần đảo
        if (head == null || head == tail) return;

        ONode prev = null;
        ONode current = head;
        ONode next = null;
        ONode originalHead = head; // Lưu lại nút đầu ban đầu

        // Duyệt qua danh sách vòng tròn và đảo ngược các liên kết
        do
        {
            next = current.next; // Lưu nút tiếp theo
            current.next = prev; // Đảo ngược liên kết
            prev = current;      // Tiến prev lên nút hiện tại
            current = next;      // Tiến current lên nút tiếp theo
        } while (current != originalHead); // Lặp cho đến khi quay lại đầu

        // Cập nhật head và tail
        tail = head;
        tail.next = prev; // Đảm bảo tail trỏ về head mới
        head = prev;
    }

    public bool exist(GameObject checkObject)
    {
        if (empty()) return false;
        ONode current = head;
        do
        {
            if (current.obstacle == checkObject) return true;
            current = current.next;
        } while (current != head);
        return false;
    }
}
