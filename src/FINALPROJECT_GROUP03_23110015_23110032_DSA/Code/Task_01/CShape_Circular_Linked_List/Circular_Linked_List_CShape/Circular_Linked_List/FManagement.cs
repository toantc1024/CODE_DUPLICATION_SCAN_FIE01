using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circular_Linked_List
{
    public partial class FManagement : Form
    {
        CircularList list = new CircularList();
        public FManagement()
        {
            InitializeComponent();

            Clothes shirt = new Clothes("001", "Shirt", "Cool Shirt", "M", 200000);
            Node shirtNode = new Node(shirt);
            list.InsertAtBegin(shirtNode);

            Clothes pants = new Clothes("002", "Pants", "Casual Pants", "L", 300000);
            Node pantsNode = new Node(pants);
            list.InsertAtEnd(pantsNode);

            Clothes jacket = new Clothes("003", "Jacket", "Warm Jacket", "L", 500000);
            Node jacketNode = new Node(jacket);
            list.InsertAfterNode("001", jacketNode);
            list.SelectionSort("id", "i"); 
            DisplayData(list);
        }

        void DisplayData(CircularList DisplayList)
        {
            liboxData.Items.Clear();
            if(DisplayList != null)
            {
                string input = DisplayList.PrintList();
                string[] words = input.Split(';');
                foreach (string word in words)
                {
                    liboxData.Items.Add(word);
                }
            }
        }
        private void FManagement_Load(object sender, EventArgs e)
        {

        }

        private void btADD_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            string name = tbName.Text;
            string type = cboxType.Text;
            string size = cboxSize.Text;
            int price = int.Parse(tbPrice.Text);
            Clothes newClo = new Clothes(id, type, name, size, price);
            Node newNode = new Node(newClo);
            list.InsertAtEnd(newNode);
            DisplayData(list);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            list.RemoveAt(id);
            DisplayData(list);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string criteria = cboxCriteria.Text;
            string value = tbValue.Text;
            Clothes searchClothes = new Clothes(criteria, value);
            CircularList searchList = list.LinearSearch(criteria, searchClothes);
            DisplayData(searchList);
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            DisplayData(list);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            CircularList sortList = list;
            string opt = cboxSort.Text == "increasing" ? "i" : "d";
            sortList.SelectionSort(cboxCriteria.Text, opt);
            DisplayData (list);
        }

        private void btRemoveAll_Click(object sender, EventArgs e)
        {
            list.RemoveAll(cboxCriteria.Text, tbValue.Text);
            DisplayData(list);
        }
    }
}
