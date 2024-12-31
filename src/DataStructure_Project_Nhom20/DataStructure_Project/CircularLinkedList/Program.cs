namespace MyWinFormsApp;
using System;
using System.Windows.Forms;
using CircularLinkedListApp;
public static class Program
{
    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());  // Đảm bảo rằng 'Form1' là tên chính xác của lớp
    }
}