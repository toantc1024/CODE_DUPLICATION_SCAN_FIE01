using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise3_BST
{
    internal class BinarySearchTree
    {
        private TNode? root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public bool IsEmptyTree()
        {
            return this.root == null;
        }


        // Hàm thêm node vào cây
        public void InsertNode(TNode value, string task)
        {
            // Nếu cây rỗng, tạo node gốc
            if (IsEmptyTree())
            {
                this.root = value;
            }
            else
            {
                // Nếu cây không rỗng, gọi hàm đệ quy để thêm node
                root = InsertRec(root, value, task);
            }
        }

        private TNode InsertRec(TNode? root, TNode value, string task)
        {
            // Nếu cây con rỗng, tạo node mới
            if (root == null)
            {
                return value; // Tạo node mới
            }

            if (task == "encode")
            {
                // Nếu giá trị nhỏ hơn node gốc, thêm vào cây con bên trái
                if (value.Info.Name.CompareTo(root.Info.Name) < 0)
                {
                    root.PLeft = InsertRec(root.PLeft, value, task);
                }
                // Nếu giá trị lớn hơn node gốc, thêm vào cây con bên phải
                else if (value.Info.Name.CompareTo(root.Info.Name) > 0)
                {
                    root.PRight = InsertRec(root.PRight, value, task);
                }
            }
            else
            {
                // Nếu giá trị nhỏ hơn node gốc, thêm vào cây con bên trái
                if (value.Info.Morse.CompareTo(root.Info.Morse) < 0)
                {
                    root.PLeft = InsertRec(root.PLeft, value, task);
                }
                // Nếu giá trị lớn hơn node gốc, thêm vào cây con bên phải
                else if (value.Info.Morse.CompareTo(root.Info.Morse) > 0)
                {
                    root.PRight = InsertRec(root.PRight, value, task);
                }
            }

            // Trả về node gốc (không thay đổi)
            return root;
        }

        //Hàm xoá node trên cây
        public void DeleteNode(string key, string task)
        {
            root = DeleteRec(root, key, task);
        }

        private TNode? DeleteRec(TNode? root, string key, string task)
        {
            if (this.root == null)
            {
                return root;
            }
               

            // So sánh `key` với giá trị hiện tại để tìm vị trí cần xóa
            int comparison;
            if (task == "encode")
                comparison = key.CompareTo(root!.Info.Name); // So sánh theo `Name`
            else
                comparison = key.CompareTo(root!.Info.Morse); // So sánh theo `Morse`

            if (comparison < 0)
            {
                // Key nhỏ hơn giá trị hiện tại, đi sang trái
                root.PLeft = DeleteRec(root.PLeft, key, task);
            }
            else if (comparison > 0)
            {
                // Key lớn hơn giá trị hiện tại, đi sang phải
                root.PRight = DeleteRec(root.PRight, key, task);
            }
            else
            {
                // Key khớp, đây là node cần xóa
                // Trường hợp 1: Node không có con hoặc chỉ có 1 con
                if (root.PLeft == null)
                {
                    return root.PRight;
                }                 
                else if (root.PRight == null)
                {
                    return root.PLeft;
                }                  

                // Trường hợp 2: Node có 2 con
                // Tìm node nhỏ nhất trong cây con bên phải
                TNode minNode = FindMin(root.PRight);
                root.Info = minNode.Info; 
                root.PRight = DeleteRec(root.PRight, minNode.Info.Name, "encode"); // Xóa node nhỏ nhất
            }

            return root;
        }

        // Tìm node nhỏ nhất trên cây
        private TNode FindMin(TNode root)
        {
            while (root.PLeft != null)
                root = root.PLeft;
            return root;
        }

        //Hàm tìm kiếm node trên cây
        public TNode? SearchNode(string key, string task)
        {
            return SearchRec(root, key, task);
        }

        private TNode? SearchRec(TNode? root, string key, string task)
        {
           
            if (root == null)
            {
                return null;
            }

            // So sánh `key` với giá trị tại node hiện tại
            int comparison;
            if (task == "encode")
            {             
                comparison = key.CompareTo(root.Info.Name); // So sánh theo `Name`
            }
            else
            {              
                comparison = key.CompareTo(root.Info.Morse); // So sánh theo `Morse`
            }

            if (comparison == 0)
            {
                // Tìm thấy node, trả về node
                return root;
            }
            else if (comparison < 0)
            {
                // Tìm ở cây con bên trái
                return SearchRec(root.PLeft, key, task);
            }
            else
            {
                // Tìm ở cây con bên phải
                return SearchRec(root.PRight, key, task);
            }
        }


        //In-Order traversal
        public List<string> InOrderTraversal()
        {
            List<string> result = new List<string>();
            InOrderRec(root, result);
            return result;
        }

        private void InOrderRec(TNode? root, List<string> result)
        {
            if (root == null)
                return;

            // Duyệt cây con bên trái
            InOrderRec(root.PLeft, result);

            // Thêm thông tin node vào danh sách
            result.Add($"Name: {root.Info.Name}, Morse: {root.Info.Morse}");

            // Duyệt cây con bên phải
            InOrderRec(root.PRight, result);
        }

        public void InitializeMorseTree(string task)
        {
            var morseData = new List<MorseCode>
            {
                // A-Z
                new MorseCode(".-", "A"), new MorseCode("-...", "B"), new MorseCode("-.-.", "C"),
                new MorseCode("-..", "D"), new MorseCode(".", "E"), new MorseCode("..-.", "F"),
                new MorseCode("--.", "G"), new MorseCode("....", "H"), new MorseCode("..", "I"),
                new MorseCode(".---", "J"), new MorseCode("-.-", "K"), new MorseCode(".-..", "L"),
                new MorseCode("--", "M"), new MorseCode("-.", "N"), new MorseCode("---", "O"),
                new MorseCode(".--.", "P"), new MorseCode("--.-", "Q"), new MorseCode(".-.", "R"),
                new MorseCode("...", "S"), new MorseCode("-", "T"), new MorseCode("..-", "U"),
                new MorseCode("...-", "V"), new MorseCode(".--", "W"), new MorseCode("-..-", "X"),
                new MorseCode("-.--", "Y"), new MorseCode("--..", "Z"),

                 // 0-9
                new MorseCode("-----", "0"), new MorseCode(".----", "1"), new MorseCode("..---", "2"),
                new MorseCode("...--", "3"), new MorseCode("....-", "4"), new MorseCode(".....", "5"),
                new MorseCode("-....", "6"), new MorseCode("--...", "7"), new MorseCode("---..", "8"),
                new MorseCode("----.", "9"),

                // Ký tự đặt biệt
                new MorseCode(".-.-.-", "."), new MorseCode("--..--", ","), new MorseCode("..--..", "?"),
                new MorseCode(".----.", "'"), new MorseCode("-.-.--", "!"), new MorseCode("-..-.", "/"),
                new MorseCode("-.--.", "("), new MorseCode("-.--.-", ")"), new MorseCode(".-...", "&"),
                new MorseCode("-.-.-.", ";"), new MorseCode("-...-", "="), new MorseCode(".-.-.", "+"),
                new MorseCode("-....-", "-"), new MorseCode("..--.-", "_"), new MorseCode(".-..-.", "\""),
                new MorseCode("...-..-", "$"), new MorseCode(".--.-.", "@"),
            };

            // Thêm từng node MorseCode vào cây
            foreach (var morse in morseData)
            {
                this.InsertNode(new TNode(morse), task);
            }
        }


    }

    public class TNode
    {
        private MorseCode info;
        private TNode? pLeft;
        private TNode? pRight;

        public TNode(MorseCode info)
        {
            this.info = info;
            this.pLeft = null;
            this.pRight = null;
        }

        public MorseCode Info
        {
            get { return info; }
            set { info = value; }
        }

        public TNode? PLeft
        {
            get { return pLeft; }
            set { pLeft = value; }
        }

        public TNode? PRight
        {
            get { return pRight; }
            set { pRight = value; }
        }
    }

    public class MorseCode
    {
        private string morse;
        private string name;

        public MorseCode(string morse, string name)
        {
            this.morse = morse;
            this.name = name;
        }

        public string Morse
        {
            get { return morse; }
            set { morse = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    

}
