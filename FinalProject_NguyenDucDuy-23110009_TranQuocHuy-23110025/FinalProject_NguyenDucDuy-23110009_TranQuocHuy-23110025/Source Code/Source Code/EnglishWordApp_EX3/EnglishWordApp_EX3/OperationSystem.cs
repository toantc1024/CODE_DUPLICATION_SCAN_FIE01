using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordApp_EX3
{
    public class OperationSystem
    {
        public Node Root;
        public OperationSystem() 
        {
            Root = null; 
        }
        //--------------------------------------Add Word------------------------------------------------
        public void addWord(Word word)
        {
            Root = addWordSystem(Root, word);
        }
        private Node addWordSystem(Node root, Word word)
        {
            if (root == null) return new Node(word);
            if (String.Compare(word.NameWord, root.Data.NameWord, StringComparison.OrdinalIgnoreCase) < 0)
            {
                root.Left = addWordSystem(root.Left, word);
            }
            else root.Right = addWordSystem(root.Right, word);
            return root;
        }
        //------------------------------------Delete Word-----------------------------------------------------
        public void deleteWord(string nameWord)
        {

        }

        private Node deleteWordSystem(Node root, string nameWord)
        {
            if (root == null) return null;

            if (nameWord == root.Data.NameWord)
            {
                // Trường hợp 1: Không có con
                if (root.Left == null && root.Right == null) return null;

                // Trường hợp 2: Có một con
                if (root.Left == null) return root.Right;
                if (root.Right == null) return root.Left;

                // Trường hợp 3: Có hai con
                Node smallestValue = FindSmallestNode(root.Right);
                root.Data = smallestValue.Data;
                root.Right = deleteWordSystem(root.Right, root.Data.NameWord);
                return root;
            }

            if (string.Compare(nameWord, root.Data.NameWord) < 0)
                root.Left = deleteWordSystem(root.Left, nameWord);
            else
                root.Right = deleteWordSystem(root.Right, nameWord);

            return root;
        }

        private Node FindSmallestNode(Node current)
        {
            return current.Left == null ? current : FindSmallestNode(current.Left);
        }
        //--------------------------------------Find Word-------------------------------------------------
        public bool FindWord(string nameWord)
        {
            return findWord(Root, nameWord);
        }

        private bool findWord(Node root, string word)
        {
            if (root == null || word == null)
            {
                return false;
            }

            if (root.Data.NameWord == word)
            {
                //MessageBox.Show($"{root.Data.NameWord} found!");
                return true;
            }

            // Tìm trong cây con bên trái
            if (findWord(root.Left, word))
                return true;

            // Tìm trong cây con bên phải
            return findWord(root.Right, word);
        }

        public string FindTypeForWord(string nameWord)
        {
            return findTypeForWord(Root, nameWord);
        }
        private string findTypeForWord(Node root, string word)
        {
            if (root == null || word == null)
            {
                return null; 
            }

            if (root.Data.NameWord == word)
            {
                return root.Data.TypeOfWord;
            }
            string leftResult = findTypeForWord(root.Left, word);
            if (leftResult != null)
            {
                return leftResult; // Nếu tìm thấy trong cây con bên trái, trả về ngay
            }
            return findTypeForWord(root.Right, word);
        }
        //---------------------------------Hint---------------------------------------------------------
        public void findHint(ref string hintForUser)
        {
            char[] charArray = hintForUser.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    charArray[i] = '*';
                }
            }

            hintForUser = new string(charArray);
            
        }
    }
}
