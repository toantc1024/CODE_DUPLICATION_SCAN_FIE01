using Ex3;
using System.Collections.Generic;
using System;

namespace Ex3
{
    public class Menu
    {
        private WordNode root = null;
        private DictionaryTree vocabulary = new DictionaryTree();

        public void DictionaryMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Add a new word");
                Console.WriteLine("2. Search a word by word");
                Console.WriteLine("3. Search a word by meaning");
                Console.WriteLine("4. Search words by prefix");
                Console.WriteLine("5. Delete a word");
                Console.WriteLine("6. My own dictionary");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertNewWord();
                        break;
                    case 2:
                        SearchWordByWord();
                        break;
                    case 3:
                        SearchWordByMeaning();
                        break;
                    case 4:
                        SearchWordsByPrefix();
                        break;
                    case 5:
                        DeleteWord();
                        break;
                    case 6:
                        MyDictionary();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("We do not have this choice. Try again.");
                        break;
                }
            } while (choice != 0);
        }

        private void InsertNewWord()
        {
            Console.Write("Enter the word: ");
            string word = Console.ReadLine();
            Console.Write("Enter the meaning: ");
            string meaning = Console.ReadLine();
            root = vocabulary.InsertWord(root, word, meaning);
            Console.WriteLine("Word added successfully.");
        }

        private void SearchWordByWord()
        {
            Console.Write("Enter the word to search: ");
            string word = Console.ReadLine();
            WordNode found = vocabulary.SearchWord(root, word);
            if (found != null)
                Console.WriteLine($"Your result: {found.word} : {found.meaning}");
            else
                Console.WriteLine("Word not found.");
        }

        private void SearchWordByMeaning()
        {
            Console.Write("Enter the meaning to search: ");
            string meaning = Console.ReadLine();
            WordNode found = vocabulary.SearchMeaning(root, meaning);
            if (found != null)
                Console.WriteLine($"Found: {found.word} - {found.meaning}");
            else
                Console.WriteLine("No word found with the given meaning.");
        }

        private void SearchWordsByPrefix()
        {
            Console.Write("Enter the prefix to search: ");
            string prefix = Console.ReadLine();
            List<WordNode> results = vocabulary.SearchPrefix(root, prefix);
            if (results.Count > 0)
            {
                Console.WriteLine("The list of words:");
                foreach (var node in results)
                {
                    Console.WriteLine($"{node.word} - {node.meaning}");
                }
            }
            else
            {
                Console.WriteLine("No words found with the given prefix.");
            }
        }

        private void DeleteWord()
        {
            Console.Write("Enter the word to delete: ");
            string word = Console.ReadLine();
            root = vocabulary.DeleteWord(root, word);
            Console.WriteLine("Word deleted successfully.");
        }

        private void MyDictionary()
        {
            Console.WriteLine("My own dictionary:");
            vocabulary.MyDictionany(root);
        }
    }
}