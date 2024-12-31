using Microsoft.VisualBasic.Devices;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;

namespace Exercise3_BST
{
    public partial class Form1 : Form
    {

        private BinarySearchTree encodeTree = new BinarySearchTree();
        private BinarySearchTree decodeTree = new BinarySearchTree();


        public Form1()
        {
            InitializeComponent();

            // Khởi tạo cây và thêm dữ liệu           
            encodeTree.InitializeMorseTree("encode");
            decodeTree.InitializeMorseTree("decode");

            // Cập nhật ListBox với dữ liệu từ cây
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            // Lấy danh sách theo thứ tự In-order từ cây
            List<string> inOrderList = encodeTree.InOrderTraversal();

            // Xóa nội dung cũ trong ListBox
            lstMorse.Items.Clear();

            // Thêm các chuỗi từ danh sách vào ListBox
            foreach (var item in inOrderList)
            {
                lstMorse.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        //encode
        private void btnEncode_Click(object sender, EventArgs e)
        {
            // Lấy văn bản đầu vào
            string inputText = txtInput.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please enter text to encode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mã hóa văn bản
            string encodedText = Encode(inputText);

            // Hiển thị kết quả
            txtOutput.Text = encodedText;
        }

        private string Encode(string input)
        {
            // Thay thế nhiều dấu cách liên tiếp thành một dấu cách duy nhất và loại bỏ khoảng trắng ở đầu/cuối
            string cleanedInput = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ").Trim();

            // Chuyển thành chữ in hoa và tách thành các từ
            string[] words = cleanedInput.ToUpper().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder encodedResult = new StringBuilder();          
            

            foreach (var word in words)
            {
                foreach (char c in word)
                {
                    // Tìm mã Morse cho ký tự c
                    TNode? morseCode = encodeTree.SearchNode(c.ToString(), "encode");
                    if (morseCode != null)
                    {
                        encodedResult.Append(morseCode.Info.Morse + " "); 
                    }
                    else
                    {
                        // Nếu không tìm thấy mã Morse cho ký tự, thêm dấu ?
                        encodedResult.Append("? ");
                    }
                }
             
                if (word != words.Last())
                {
                    encodedResult.Append("/ "); // Dùng / để phân cách các từ
                }
            }

            return encodedResult.ToString().Trim(); // Loại bỏ khoảng trắng thừa ở cuối
        }


        //decode
        private void btnDecode_Click(object sender, EventArgs e)
        {
            // Lấy văn bản đầu vào
            string inputText = txtInput.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please only enter . - / to decode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mã hóa văn bản
            string encodedText = Decode(inputText);

            // Hiển thị kết quả
            txtOutput.Text = encodedText;
        }

        private string Decode(string input)
        {
            StringBuilder decodedResult = new StringBuilder();
           
            string[] words = input.Split(new string[] { " / " }, StringSplitOptions.None);

            foreach (string word in words)
            {
                
                string[] morseChars = word.Split(' ');

                foreach (string morse in morseChars)
                {
                    // Kiểm tra nếu là khoảng trắng thì chỉ cần skip
                    if (morse == "")
                    {                      
                        continue;
                    }
                    else
                    {
                        // Tìm ký tự tương ứng với mã Morse
                        TNode? morseCode = decodeTree.SearchNode(morse.ToString(), "decode");
                        if (morseCode != null)
                        {
                            decodedResult.Append(morseCode.Info.Name); // Thêm ký tự tương ứng vào kết quả
                        }
                        else
                        {
                            decodedResult.Append("?"); // Nếu không tìm thấy mã Morse, thay bằng dấu "?"
                        }
                    }
                }

                // Thêm dấu cách giữa các từ
                decodedResult.Append(" ");
            }

            // Trả về kết quả giải mã, loại bỏ khoảng trắng dư thừa cuối cùng
            return decodedResult.ToString().Trim();
        }


    }
}