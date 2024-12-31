public class Ke
{
	public string LoaiHang { get; private set; }
	public Node head;

	public Ke(string loaiHang)
	{
		LoaiHang = loaiHang;
		head = null;
	}
	public Node GetHead()
	{
		return head;
	}
	public void ThemHang(Hang hang)
	{
		var nodeMoi = new Node(hang);
		if (head == null)
		{
			head = nodeMoi;
			head.Next = head;
		}
		else
		{
			Node temp = head;
			while (temp.Next != head)
			{
				temp = temp.Next;
			}
			temp.Next = nodeMoi;
			nodeMoi.Next = head;
		}
	}

	public void XemHang()
	{
		if (head == null)
		{
			Console.WriteLine("Ke " + LoaiHang + " rong.");
			return;
		}

		Node temp = head;
		do
		{
			Console.WriteLine(temp.HangHoa);
			temp = temp.Next;
		} while (temp != head);
	}
}