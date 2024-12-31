
public class KhoHang
{
    public class NodeKe
    {
        public Ke Ke { get; set; }
        public Hang HangHoa;
        public NodeKe Next { get; set; }

        public NodeKe(Ke ke)
        {
            Ke = ke;
            Next = null;
        }
    }
    public NodeKe head;
    public KhoHang()
    {
        head = null;
    }

    public void ThemKe(Ke ke)
    {
        var nodeMoi = new NodeKe(ke);
        if (head == null)
        {
            head = nodeMoi;
            head.Next = head;
        }
        else
        {
            NodeKe temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = nodeMoi;
            nodeMoi.Next = head;
        }
    }

    public NodeKe GetHead()
    {
        return head;
    }

    public NodeKe TimKeChuaHang(string maHang)
    {
        NodeKe temp = head;
        do
        {
            Node nodeTemp = temp.Ke.GetHead();
            do
            {
                if (nodeTemp.HangHoa.Ma == maHang)
                {
                    return temp;
                }
                nodeTemp = nodeTemp.Next;
            } while (nodeTemp != temp.Ke.GetHead());

            temp = temp.Next;
        } while (temp != head);

        return null;
    }

    public void XemTatCaKe()
    {
        if (head == null)
        {
            Console.WriteLine("Kho hang rong.");
            return;
        }

        NodeKe temp = head;
        do
        {
            Console.WriteLine("Loai hang: " + temp.Ke.LoaiHang);
            temp.Ke.XemHang();
            temp = temp.Next;
        } while (temp != head);
    }
    public void LocHangTheoGia(double gia, bool lonHon)
    {
        List<Hang> ketQua = new List<Hang>();
        if (head == null)
        {
            Console.WriteLine("None");
            return;
        }

        NodeKe keTam = head;
        do
        {
            Node nodeTam = keTam.Ke.GetHead();
            if (nodeTam != null)
            {
                do
                {
                    if ((lonHon && nodeTam.HangHoa.Gia > gia) || (!lonHon && nodeTam.HangHoa.Gia <= gia))
                    {
                        ketQua.Add(nodeTam.HangHoa);
                    }
                    nodeTam = nodeTam.Next;
                } while (nodeTam != keTam.Ke.GetHead());
            }
            keTam = keTam.Next;
        } while (keTam != head);

        if (ketQua.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (Hang h in ketQua)
            {
                Console.WriteLine(h);
            }
        }
    }

    public void LocHangTheoKhoiLuong(double khoiLuong, bool lonHon)
    {
        List<Hang> ketQua = new List<Hang>();
        if (head == null)
        {
            Console.WriteLine("None");
            return;
        }

        NodeKe keTam = head;
        do
        {
            Node nodeTam = keTam.Ke.GetHead();
            if (nodeTam != null)
            {
                do
                {
                    if ((lonHon && nodeTam.HangHoa.KhoiLuong > khoiLuong) || (!lonHon && nodeTam.HangHoa.KhoiLuong <= khoiLuong))
                    {
                        ketQua.Add(nodeTam.HangHoa);
                    }
                    nodeTam = nodeTam.Next;
                } while (nodeTam != keTam.Ke.GetHead());
            }
            keTam = keTam.Next;
        } while (keTam != head);

        if (ketQua.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (Hang h in ketQua)
            {
                Console.WriteLine(h);
            }
        }
    }


    public void LocHangTheoLoai(string loai)
    {
        List<Hang> ketQua = new List<Hang>();
        if (head == null)
        {
            Console.WriteLine("None");
            return;
        }

        NodeKe keTam = head;
        do
        {
            Node nodeTam = keTam.Ke.GetHead();
            if (nodeTam != null)
            {
                do
                {
                    if (nodeTam.HangHoa.Loai == loai)
                    {
                        ketQua.Add(nodeTam.HangHoa);
                    }
                    nodeTam = nodeTam.Next;
                } while (nodeTam != keTam.Ke.GetHead());
            }
            keTam = keTam.Next;
        } while (keTam != head);

        if (ketQua.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (Hang h in ketQua)
            {
                Console.WriteLine(h);
            }
        }
    }

    public void DocDuLieuTuFile(string filePhanLoai, string fileSanPham)
    {
        string[] phanLoaiData = File.ReadAllLines(filePhanLoai);
        string tenKho = phanLoaiData[0];
        Console.WriteLine("Ten kho: " + tenKho);

        for (int i = 1; i < phanLoaiData.Length; i++)
        {
            ThemKe(new Ke(phanLoaiData[i]));
        }

        string[] sanPhamData = File.ReadAllLines(fileSanPham);
        foreach (var line in sanPhamData)
        {
            string[] parts = line.Split(',');
            var hang = new Hang(parts[0], parts[1], double.Parse(parts[2]), double.Parse(parts[3]), parts[4]);
            NodeKe temp = head;
            do
            {
                if (temp.Ke.LoaiHang == hang.Loai)
                {
                    temp.Ke.ThemHang(hang);
                    break;
                }
                temp = temp.Next;
            } while (temp != head);
        }
    }
}
