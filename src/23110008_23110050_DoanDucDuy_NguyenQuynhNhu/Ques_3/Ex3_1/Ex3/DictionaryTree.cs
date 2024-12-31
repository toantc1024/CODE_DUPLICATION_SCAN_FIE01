using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class DictionaryTree
    {
        public WordNode InsertWord(WordNode root, string word, string meaning)
        {
            if (root == null)
                return new WordNode { word = word, meaning = meaning, left = null, right = null };

            if (root.word == word)
                return root; 

            if (string.Compare(root.word, word) > 0)
                root.left = InsertWord(root.left, word, meaning); 
            else
                root.right = InsertWord(root.right, word, meaning); 

            return root; 
        }

        public WordNode SearchWord(WordNode root, string word)
        {
            if (root == null || root.word == word)
                return root;

            if (string.Compare(root.word, word) > 0)
                return SearchWord(root.left, word); 
            else
                return SearchWord(root.right, word); 
        }

        public WordNode SearchMeaning(WordNode root, string meaning)
        {
            if (root == null)
                return null;

            WordNode found = SearchMeaning(root.left, meaning);
            if (found != null)
                return found;

            if (root.meaning == meaning)
                return root;

            return SearchMeaning(root.right, meaning);
        }

        public List<WordNode> SearchPrefix(WordNode root, string prefix)
        {
            List<WordNode> words = new List<WordNode>();
            ListWords(root, prefix, words);
            return words;
        }

        private void ListWords(WordNode root, string prefix, List<WordNode> results)
        {
            if (root == null)
                return;

            ListWords(root.left, prefix, results);

            if (root.word.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                results.Add(root);

            ListWords(root.right, prefix, results);
        }

        public WordNode DeleteWord(WordNode root, string word)
        {
            if (root == null)
                return null;

            if (string.Compare(word, root.word) < 0)
            {
                root.left = DeleteWord(root.left, word); 
            }
            else if (string.Compare(word, root.word) > 0)
            {
                root.right = DeleteWord(root.right, word); 
            }
            else
            {
                if (root.left == null)
                    return root.right;
                if (root.right == null)
                    return root.left;

                WordNode temp = MoveLeftMostNode(root.right);
                root.word = temp.word;
                root.meaning = temp.meaning;
                root.right = DeleteWord(root.right, temp.word);
            }
            return root;
        }

        private WordNode MoveLeftMostNode(WordNode root)
        {
            WordNode parent = null, current = root;
            while (current.left != null)
            {
                parent = current;
                current = current.left;
            }

            if (parent != null)
                parent.left = current.right;
            else
                root = current.right;

            return current;
        }

        public void MyDictionany(WordNode root)
        {
            if (root != null)
            {
                MyDictionany(root.left);
                Console.WriteLine($"{root.word}: {root.meaning}");
                MyDictionany(root.right);
            }
        }
    }
}
