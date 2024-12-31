using System;
using System.Collections.Generic;

public class QueueExample
{
    private Queue<int> queue;

    public QueueExample()
    {
        queue = new Queue<int>();
    }

    // Thêm phần tử vào hàng đợi
    public void Enqueue(int value)
    {
        queue.Enqueue(value);
    }

    // Xóa phần tử khỏi hàng đợi
    public int Dequeue()
    {
        if (queue.Count > 0)
            return queue.Dequeue();
        else
            throw new InvalidOperationException("Hàng đợi rỗng!");
    }

    // Xem phần tử đầu tiên
    public int Peek()
    {
        if (queue.Count > 0)
            return queue.Peek();
        else
            throw new InvalidOperationException("Hàng đợi rỗng!");
    }

    // Kiểm tra hàng đợi có rỗng không
    public bool IsEmpty()
    {
        return queue.Count == 0;
    }

    // Lấy tất cả phần tử trong hàng đợi
    public List<int> GetItems()
    {
        return new List<int>(queue);
    }
}
