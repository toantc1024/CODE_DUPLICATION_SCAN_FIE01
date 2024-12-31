using System;
using System.Collections.Generic;

namespace Quan_Li_Chi_Tieu_App
{
    public class TransactionTree
    {
        private TransactionNode root; // Root node of the binary tree

        public TransactionTree()
        {
            root = null; // Initialize with an empty tree
        }

        // Add a transaction to the binary tree
        public void AddTransaction(decimal amount, string description, string category)
        {
            TransactionNode newNode = new TransactionNode(amount, description, category);

            if (root == null)
            {
                // If the tree is empty, set the new node as the root
                root = newNode;
            }
            else
            {
                // Otherwise, insert the new node into the tree
                InsertNode(root, newNode);
            }
        }

        // Recursive method to insert a node into the binary tree
        private void InsertNode(TransactionNode current, TransactionNode newNode)
        {
            if (newNode.Amount < current.Amount)
            {
                // Insert into the left subtree if the amount is smaller
                if (current.Left == null)
                    current.Left = newNode;
                else
                    InsertNode(current.Left, newNode);
            }
            else
            {
                // Insert into the right subtree if the amount is greater or equal
                if (current.Right == null)
                    current.Right = newNode;
                else
                    InsertNode(current.Right, newNode);
            }
        }

        // Get all transactions in ascending order (In-order traversal)
        public List<TransactionNode> GetTransactions()
        {
            List<TransactionNode> transactions = new List<TransactionNode>();
            InOrderTraversal(root, transactions);
            return transactions;
        }

        // Helper method for in-order traversal
        private void InOrderTraversal(TransactionNode node, List<TransactionNode> transactions)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, transactions); // Visit left subtree
                transactions.Add(node);                   // Add current node
                InOrderTraversal(node.Right, transactions); // Visit right subtree
            }
        }

        // Get transactions as a formatted string
        public string GetTransactionsText()
        {
            List<TransactionNode> transactions = GetTransactions();
            string result = "";

            foreach (var transaction in transactions)
            {
                result += $"{transaction.Date:yyyy-MM-dd} | {transaction.Category} | {transaction.Description} | {transaction.Amount:C}\n";
            }

            return result;
        }

        // Calculate the total amount of all transactions
        public decimal CalculateTotalAmount()
        {
            List<TransactionNode> transactions = GetTransactions();
            decimal total = 0;

            foreach (var transaction in transactions)
            {
                total += transaction.Amount;
            }

            return total;
        }
    }

    // Node class representing each transaction
    public class TransactionNode
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public TransactionNode Left { get; set; } // Left child (e.g., smaller amount)
        public TransactionNode Right { get; set; } // Right child (e.g., larger amount)

        public TransactionNode(decimal amount, string description, string category)
        {
            Amount = amount;
            Description = description;
            Category = category;
            Date = DateTime.Now;
            Left = null; // Initialize child nodes as null
            Right = null; // Initialize child nodes as null
        }
    }
}