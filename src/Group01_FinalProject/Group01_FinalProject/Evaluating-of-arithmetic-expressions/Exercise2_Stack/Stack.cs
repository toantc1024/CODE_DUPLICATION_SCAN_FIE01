using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise2_Stack
{
    public class Stack
    {
        private Node? pTop; // Cho phép null để biểu diễn trạng thái rỗng của ngăn xếp.

        public Stack()
        {
            pTop = null;
        }

        // Kiểm tra ngăn xếp rỗng
        public bool IsEmptyStack()
        {
            return pTop == null;
        }

        // Thêm phần tử vào ngăn xếp
        public void Push(Node p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p), "Node cannot be null.");

            p.PNext = pTop;
            pTop = p;
        }

        // Lấy và xóa phần tử trên cùng
        public Node Pop()
        {
            if (IsEmptyStack())
            {
                throw new InvalidOperationException("The stack is empty.(Pop)");
            }

            Node tmp = pTop!;
            pTop = pTop!.PNext;
            tmp.PNext = null; // Ngắt liên kết để tránh tham chiếu không mong muốn.
            return tmp;
        }

        // Lấy giá trị của phần tử trên cùng mà không xóa
        public string Top()
        {
            if (IsEmptyStack())
            {
                throw new InvalidOperationException("The stack is empty.(Top)");
            }

            return pTop!.Info;
        }
        
    }

    public class Node
    {
        private string info;
        private Node? pNext;

        public Node(string info)
        {
            this.info = info;
            this.pNext = null;
        }

        public string Info
        {
            get { return this.info; }
            set { this.info = value; }
        }

        public Node? PNext
        {
            get { return this.pNext; }
            set { this.pNext = value; }
        }
    }


    //Ứng dụng
    public class PostfixEvaluator
    {
        private Stack stack;

        public PostfixEvaluator()
        {
            stack = new Stack();
        }

        // Chuyển đổi biểu thức Infix thành Postfix
        public string InfixToPostfix(string infix)
        {
            Stack operatorStack = new Stack();
            StringBuilder postfix = new StringBuilder();
            string token = "";

            for (int i = 0; i < infix.Length; i++)
            {
                char ch = infix[i];

                if (Char.IsDigit(ch))  // Nếu là chữ số, ta tiếp tục tạo thành toán hạng
                {
                    token += ch;  // Xây dựng token với nhiều chữ số
                }
                else if (isOperator(ch))
                {
                    if (token != "")  // Nếu có token, thêm vào postfix
                    {
                        postfix.Append(token + " ");
                        token = "";  // Reset token sau khi thêm vào
                    }

                    if (ch == '(')  // Dấu ngoặc trái
                    {
                        operatorStack.Push(new Node(ch.ToString()));
                    }
                    else if (ch == ')')  // Dấu ngoặc phải
                    {
                        while (!operatorStack.IsEmptyStack() && operatorStack.Top() != "(")
                        {
                            postfix.Append(operatorStack.Pop().Info + " ");
                        }
                        operatorStack.Pop(); // Pop dấu ngoặc trái
                    }
                    else
                    {
                        while (!operatorStack.IsEmptyStack() && GetPrecedence(ch.ToString()) <= GetPrecedence(operatorStack.Top()))
                        {
                            postfix.Append(operatorStack.Pop().Info + " ");
                        }
                        operatorStack.Push(new Node(ch.ToString()));
                    }
                }
            }

            // Thêm token cuối cùng vào postfix nếu có
            if (token != "")
            {
                postfix.Append(token + " ");
            }

            // Đẩy các toán tử còn lại trong ngăn xếp vào postfix
            while (!operatorStack.IsEmptyStack())
            {
                postfix.Append(operatorStack.Pop().Info + " ");
            }

            return postfix.ToString().Trim();  // Loại bỏ khoảng trắng dư thừa cuối cùng
        }

        public bool isOperator(char symbol)
        {
            switch (symbol)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '^':
                case '(':
                case ')':
                    return true;
                default:
                    return false;
            }
        }

        private int GetPrecedence(string op)
        {
            if (op == "+" || op == "-")
            {
                return 1;
            }
            else if (op == "*" || op == "/")
            {
                return 2;
            }
            else if (op == "^")
            {
                return 3;
            }
            return 0;
        }


        // Tính toán biểu thức Postfix
        public int Evaluate(string postfixExpression)
        {
            string[] tokens = postfixExpression.Split(' ');

            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int number))  // Nếu là toán hạng
                {
                    stack.Push(new Node(number.ToString()));
                }
                else  // Nếu là toán tử
                {
                    int operand2 = int.Parse(stack.Pop().Info);
                    int operand1 = int.Parse(stack.Pop().Info);

                    int result = PerformOperation(token, operand1, operand2);
                    stack.Push(new Node(result.ToString())); // Đẩy kết quả vào ngăn xếp
                }
            }

            return int.Parse(stack.Pop().Info); // Kết quả cuối cùng nằm ở đỉnh ngăn xếp
        }

        private int PerformOperation(string op, int operand1, int operand2)
        {
            return op switch
            {
                "+" => operand1 + operand2,
                "-" => operand1 - operand2,
                "*" => operand1 * operand2,
                "/" => operand2 == 0 ? throw new DivideByZeroException("Cannot divide by zero.") : operand1 / operand2,
                "^" => (int)Math.Pow(operand1, operand2),
                _ => throw new InvalidOperationException($"Invalid operator: {op}")
            };
        }
    }


}
