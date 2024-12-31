using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CircularLinkedListApp
{
    public partial class Form1 : Form
    {
        private CircularLinkedList<string> circularList;  // Circular linked list hiện tại được chọn
        private List<CircularLinkedList<string>> allLists;  // Danh sách tất cả các CircularLinkedList
        private CircularLinkedList<string> previousList = null;

        public Form1()
        {
            InitializeComponent();
            allLists = new List<CircularLinkedList<string>>(); // Khởi tạo danh sách các CircularLinkedList
            circularList = new CircularLinkedList<string>();  // Khởi tạo một CircularLinkedList mặc định
            allLists.Add(circularList);  // Thêm CircularLinkedList vào danh sách
            cmbLists.Items.Add("List 1");  // Thêm vào ComboBox
            cmbLists.SelectedIndex = 0;  // Mặc định chọn List 1
        }

        // Sự kiện khi nhấn Insert at Beginning
        private void BtnInsertAtBeginning_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (!string.IsNullOrEmpty(input))
            {
                circularList.InsertAtBeginning(input);
                UpdateList();
            }
        }

        // Sự kiện khi nhấn Insert at End
        private void BtnInsertAtEnd_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (!string.IsNullOrEmpty(input))
            {
                circularList.InsertAtEnd(input);
                UpdateList();
            }
        }

        // Sự kiện khi nhấn Remove First
        private void BtnRemoveFirst_Click(object sender, EventArgs e)
        {
            circularList.RemoveFirst();
            UpdateList();
        }

        // Sự kiện khi nhấn Remove Last
        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            circularList.RemoveLast();
            UpdateList();
        }
        private void BtnSearchByCriteria_Click(object sender, EventArgs e)
{
    string keyword = txtInput.Text;
    if (!string.IsNullOrEmpty(keyword))
    {
        var results = circularList.Search_From_Criteria(data => data.Contains(keyword)); // Tìm kiếm theo keyword
        lstItems.Items.Clear();
        foreach (var item in results)
        {
            lstItems.Items.Add(item); // Hiển thị kết quả tìm kiếm
        }
        lblInfo.Text = $"Found {results.Count} item(s)";
    }
    }
    private void BtnRemoveByCriteria_Click(object sender, EventArgs e)
{
    string keyword = txtInput.Text.Trim();
    if (!string.IsNullOrEmpty(keyword))
    {
        circularList.RemoveAll_Criteria(data => data.Contains(keyword)); // Xóa theo keyword
        UpdateList(); // Cập nhật giao diện
        lblInfo.Text = "Removed all matching items.";
    }
}

        // Sự kiện khi nhấn Search
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            var node = circularList.Search(input);
            lstItems.Items.Clear();
            if (node != null)
            {
                lblInfo.Text = $"Found: {node.Data}";
            }
            else
            {
                lblInfo.Text = "Not found!";
            }
        }

        // Cập nhật danh sách trong ListBox
        private void UpdateList()
{
    lstItems.Items.Clear(); // ListBox hiển thị danh sách
    if (circularList != null)
    {
        var allItems = circularList.GetAllNodes(); // Lấy tất cả các node
        foreach (var item in allItems)
        {
            lstItems.Items.Add(item); // Hiển thị các node
        }
    }
}

        // Sự kiện khi người dùng chọn CircularLinkedList trong ComboBox
        private void CmbLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbLists.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < allLists.Count)
            {
                circularList = allLists[selectedIndex];
                UpdateList();  // Cập nhật danh sách hiển thị cho list mới chọn
            }
        }

        // Sự kiện khi nhấn Create New List
        private void BtnCreateNewList_Click(object sender, EventArgs e)
        {
            // Tạo mới một CircularLinkedList và thêm vào danh sách
            CircularLinkedList<string> newList = new CircularLinkedList<string>();
            allLists.Add(newList);
            
            // Thêm vào ComboBox danh sách mới
            cmbLists.Items.Add("List " + (allLists.Count));
            cmbLists.SelectedIndex = allLists.Count - 1;  // Chọn ngay list mới tạo
        }
        private void BtnInsertAfter_Click(object sender, EventArgs e)
{
    string targetData = txtTarget.Text;
    string newData = txtInput.Text;

    if (!string.IsNullOrEmpty(targetData) && !string.IsNullOrEmpty(newData))
    {
        circularList.InsertAfter(targetData, newData);
        UpdateList();
    }
}
        private void BtnRemoveAfter_Click(object sender, EventArgs e)
{
    string targetData = txtTarget.Text;

    if (!string.IsNullOrEmpty(targetData))
    {
        circularList.RemoveAfter(targetData);
        UpdateList();
    }
}
        private void BtnInsert(object sender, EventArgs e)
        {
            string input = txtInput.Text;
        }
    
    private void BtnSelectionSort_Click(object sender, EventArgs e)
{
    if (circularList != null)
    {
        circularList.SelectionSort(); // Gọi hàm SelectionSort
        UpdateList(); // Cập nhật danh sách sau khi sắp xếp
    }
}

// Sự kiện khi nhấn QuickSort
private void BtnQuickSort_Click(object sender, EventArgs e)
{
    if (circularList != null)
    {
        circularList.QuickSort(); // Gọi hàm QuickSort
        UpdateList(); // Cập nhật danh sách sau khi sắp xếp
    }
}

// Sự kiện khi nhấn Merge Lists
private void BtnMergeLists_Click(object sender, EventArgs e)
{
    string input = txtInput.Text; // Lấy dữ liệu từ TextBox
    if (!string.IsNullOrEmpty(input))
    {
        // Tạo một danh sách mới và chèn giá trị vào danh sách đó
        CircularLinkedList<string> newList = new CircularLinkedList<string>();
        newList.InsertAtBeginning(input); // Chèn phần tử mới vào danh sách

        // Kiểm tra xem có danh sách trước đó hay không
        if (previousList != null)
        {
            // Hợp nhất danh sách hiện tại (circularList) với danh sách trước đó
            previousList.MergeLists(circularList);  // Hợp nhất circularList vào previousList
            previousList.MergeLists(newList);  // Hợp nhất newList vào previousList

            // Cập nhật lại danh sách hiện tại thành danh sách đã hợp nhất
            circularList = previousList;
        }
        else
        {
            // Nếu không có danh sách trước đó, chỉ cần cập nhật danh sách hiện tại
            circularList = newList;
        }

        // Lưu lại danh sách hiện tại vào previousList để sử dụng sau này
        previousList = circularList;

        // Cập nhật giao diện sau khi hợp nhất
        UpdateList(); // Cập nhật lại ListBox với các phần tử mới
    }
}
}}
