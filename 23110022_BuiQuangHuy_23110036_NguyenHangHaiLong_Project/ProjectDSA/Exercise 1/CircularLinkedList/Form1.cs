using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularLinkedList
{
    public partial class Form1 : Form
    {
        private CircularLinkedList list;
        private int? searchResultIndex;

        public Form1()
        {
            InitializeComponent();
            list = new CircularLinkedList();
            searchResultIndex = null; 
            lstDisplay.DrawMode = DrawMode.OwnerDrawFixed; // Thiết lập Owner Draw
            lstDisplay.DrawItem += lstDisplay_DrawItem;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAtBeginning_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int data))
            {
                list.InsertAtBeginning(data);
                searchResultIndex = null;
                UpdateListDisplay();
            }
        }

        private void btnAddAtEnd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int data))
            {
                list.InsertAtEnd(data);
                searchResultIndex = null;
                UpdateListDisplay();
            }
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            list.RemoveFirstNode();
            searchResultIndex = null;
            UpdateListDisplay();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            list.RemoveLastNode();
            searchResultIndex = null;
            UpdateListDisplay();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int key))
            {
                Node result = list.Search(key);
                if (result != null)
                {
                    MessageBox.Show("Node found: " + result.Data);
                    searchResultIndex = GetNodeIndex(result);
                }
                else
                {
                    MessageBox.Show("Node not found");
                    searchResultIndex = null;
                }
            }
            UpdateListDisplay();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            list.QuickSort(); 
            searchResultIndex = null;
            UpdateListDisplay();
        }
        private void UpdateListDisplay()
        {
            lstDisplay.Items.Clear();
            Node temp = list.head;
            int index = 0;
            if (temp != null)
            {
                do
                {
                    lstDisplay.Items.Add(new ListItemData { Data = temp.Data, Index = index });
                    temp = temp.Next;
                    index++;
                } while (temp != list.head);
            }
        }

        private void btnMergeLists_Click(object sender, EventArgs e)
        {
            CircularLinkedList otherList = new CircularLinkedList();
            otherList.InsertAtEnd(99);
            otherList.InsertAtEnd(88);
            list.MergeLists(otherList);
            UpdateListDisplay();
        }

        private void btnRemoveAllNodes_Click(object sender, EventArgs e)
        {
            list.RemoveAllNodes(); // Gọi phương thức mới để xóa toàn bộ danh sách
            searchResultIndex = null; // Reset kết quả tìm kiếm
            UpdateListDisplay(); // Cập nhật và hiển thị danh sách
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            UpdateListDisplay();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            list.Reverse();
            searchResultIndex = null;
            UpdateListDisplay();
        }

        private void btnInsertAfterNode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAfterNode.Text, out int afterNodeData) && int.TryParse(txtData.Text, out int data))
            {
                Node prevNode = list.Search(afterNodeData);
                if (prevNode != null)
                {
                    list.InsertAfter(prevNode, data);
                    UpdateListDisplay();
                }
                else
                {
                    MessageBox.Show("Previous node not found");
                }
            }
        }
        private void lstDisplay_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            ListItemData item = (ListItemData)lstDisplay.Items[e.Index];
            bool isSearchResult = searchResultIndex.HasValue && item.Index == searchResultIndex.Value;

            // Chọn màu dựa trên kết quả tìm kiếm
            e.Graphics.FillRectangle(new SolidBrush(isSearchResult ? Color.Yellow : e.BackColor), e.Bounds);
            e.Graphics.DrawString(item.Data.ToString(), e.Font, new SolidBrush(isSearchResult ? Color.Red : e.ForeColor), e.Bounds);

            // Vẽ focus rectangle nếu cần thiết
            e.DrawFocusRectangle();
        }

        private int GetNodeIndex(Node node)
        {
            Node temp = list.head;
            int index = 0;
            if (temp != null)
            {
                do
                {
                    if (temp == node) return index;
                    temp = temp.Next;
                    index++;
                } while (temp != list.head);
            }
            return -1; // Nếu không tìm thấy, trả về -1
        }
        private class ListItemData
        {
            public int Data { get; set; }
            public int Index { get; set; }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveAfterNode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAfter.Text, out int afterNodeData))
            {
                Node prevNode = list.Search(afterNodeData);
                if (prevNode != null)
                {
                    list.RemoveAfter(prevNode);
                    searchResultIndex = null;
                    UpdateListDisplay();
                }
                else
                {
                    MessageBox.Show("Previous node not found");
                }
            }
        }
    }
}
