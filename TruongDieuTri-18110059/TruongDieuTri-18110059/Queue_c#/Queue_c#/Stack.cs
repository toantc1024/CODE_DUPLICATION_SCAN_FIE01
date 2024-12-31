using System;
using System.Collections.Generic;

public class StackExample
{
    private Stack<int> stack;

    public StackExample()
    {
        stack = new Stack<int>();
    }

    // Thêm phần tử vào ngăn xếp
    public void Push(int value)
    {
        stack.Push(value);
    }

    // Xóa phần tử khỏi ngăn xếp
    public int Pop()
    {
        if (stack.Count > 0)
            return stack.Pop();
        else
            throw new InvalidOperationException("Ngăn xếp rỗng!");
    }

    // Xem phần tử trên cùng
    public int Peek()
    {
        if (stack.Count > 0)
            return stack.Peek();
        else
            throw new InvalidOperationException("Ngăn xếp rỗng!");
    }

    // Kiểm tra ngăn xếp có rỗng không
    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    // Lấy tất cả phần tử trong ngăn xếp
    public List<int> GetItems()
    {
        return new List<int>(stack);
    }
}
