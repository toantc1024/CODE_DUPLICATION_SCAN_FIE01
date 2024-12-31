using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private CustomQueue<Order> orderQueue;
    private int orderCounter;
    private ListBox queueDisplay;
    private Label ordersInQueueLabel;
    private Label totalValueLabel;

    public MainForm()
    {
        InitializeComponent();
        orderQueue = new CustomQueue<Order>();
        orderCounter = 1;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        queueDisplay.Items.Clear();
        var allOrders = orderQueue.GetAllItems();
        foreach (var order in allOrders)
        {
            queueDisplay.Items.Add(order);
        }

        ordersInQueueLabel.Text = $"Orders in Queue: {orderQueue.Count}";
        totalValueLabel.Text = $"Total Value: ${allOrders.Sum(o => o.Price):F2}";
    }

    private void InitializeComponent()
    {
        this.Text = "Coffee Shop Order Queue";
        this.Size = new Size(800, 600);

      
        GroupBox customerGroup = new GroupBox();
        customerGroup.Text = "New Order";
        customerGroup.Location = new Point(20, 20);
        customerGroup.Size = new Size(350, 200);

        Label nameLabel = new Label();
        nameLabel.Text = "Customer Name:";
        nameLabel.Location = new Point(20, 30);
        nameLabel.AutoSize = true;

        TextBox nameTextBox = new TextBox();
        nameTextBox.Location = new Point(120, 27);
        nameTextBox.Size = new Size(200, 25);

        Label drinkLabel = new Label();
        drinkLabel.Text = "Drink:";
        drinkLabel.Location = new Point(20, 70);
        drinkLabel.AutoSize = true;

        ComboBox drinkComboBox = new ComboBox();
        drinkComboBox.Location = new Point(120, 67);
        drinkComboBox.Size = new Size(200, 25);
        drinkComboBox.Items.AddRange(new string[] {
            "Espresso", "Latte", "Cappuccino", "Americano", "Mocha","Chocolate"
        });

        Label priceLabel = new Label();
        priceLabel.Text = "Price:";
        priceLabel.Location = new Point(20, 110);
        priceLabel.AutoSize = true;

        NumericUpDown priceInput = new NumericUpDown();
        priceInput.Location = new Point(120, 107);
        priceInput.Size = new Size(100, 25);
        priceInput.Minimum = 1;
        priceInput.Maximum = 100;
        priceInput.DecimalPlaces = 2;
        priceInput.Value = 4.99M;

        Button addButton = new Button();
        addButton.Text = "Add Order";
        addButton.Location = new Point(120, 150);
        addButton.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                drinkComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            Order order = new Order
            {
                OrderId = orderCounter++,
                CustomerName = nameTextBox.Text,
                DrinkName = drinkComboBox.SelectedItem.ToString(),
                Price = priceInput.Value,
                OrderTime = DateTime.Now
            };

            orderQueue.Enqueue(order);
            UpdateDisplay();
            nameTextBox.Clear();
            drinkComboBox.SelectedIndex = -1;
        };

       
        queueDisplay = new ListBox();
        queueDisplay.Location = new Point(20, 240);
        queueDisplay.Size = new Size(350, 250);

        Button completeButton = new Button();
        completeButton.Text = "Complete Order";
        completeButton.Location = new Point(20, 500);
        completeButton.Size = new Size(120, 30);
        completeButton.Click += (s, e) =>
        {
            if (!orderQueue.IsEmpty())
            {
                Order completed = orderQueue.Dequeue();
                MessageBox.Show($"Completed: {completed}");
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("No orders in queue!");
            }
        };

        GroupBox statsGroup = new GroupBox();
        statsGroup.Text = "Queue Statistics";
        statsGroup.Location = new Point(400, 20);
        statsGroup.Size = new Size(350, 200);

        ordersInQueueLabel = new Label();
        ordersInQueueLabel.Location = new Point(20, 30);
        ordersInQueueLabel.Size = new Size(300, 20);
        ordersInQueueLabel.Text = "Orders in Queue: 0";

        totalValueLabel = new Label();
        totalValueLabel.Location = new Point(20, 60);
        totalValueLabel.Size = new Size(300, 20);
        totalValueLabel.Text = "Total Value: $0.00";

        customerGroup.Controls.AddRange(new Control[] {
            nameLabel, nameTextBox, drinkLabel, drinkComboBox,
            priceLabel, priceInput, addButton
        });

        statsGroup.Controls.AddRange(new Control[] {
            ordersInQueueLabel, totalValueLabel
        });

        this.Controls.AddRange(new Control[] {
            customerGroup, queueDisplay, completeButton, statsGroup
        });
    }
}

public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public string DrinkName { get; set; }
    public DateTime OrderTime { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"Order #{OrderId} - {CustomerName} - {DrinkName} - ${Price}";
    }
}

public class CustomQueue<T>
{
    private List<T> items;

    public CustomQueue()
    {
        items = new List<T>();
    }

    public int Count => items.Count;

    public void Enqueue(T item)
    {
        items.Add(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        T item = items[0];
        items.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        return items[0];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public void Clear()
    {
        items.Clear();
    }

    public List<T> GetAllItems()
    {
        return new List<T>(items);
    }
}

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}
