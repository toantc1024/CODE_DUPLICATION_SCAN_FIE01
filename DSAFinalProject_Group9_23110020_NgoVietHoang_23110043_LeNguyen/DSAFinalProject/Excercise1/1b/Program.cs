using System;
using System.Collections.Generic;
using System.IO;
using static KhoHang;

public class Node
{
    public Hang HangHoa { get; set; }
    public Node Next { get; set; }

    public Node(Hang hangHoa)
    {
        HangHoa = hangHoa;
        Next = null;
    }
}
class Program
{
    static void Main(string[] args)
    {
        var kho = new KhoHang();
        string filePhanLoai = "PhanLoaiCuaHang.txt";
        string fileSanPham = "SanPham.txt";
        kho.DocDuLieuTuFile(filePhanLoai, fileSanPham);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("======== QUAN LY KHO HANG ========");
            Console.WriteLine("1. Them san pham");
            Console.WriteLine("2. Cap nhat san pham");
            Console.WriteLine("3. Xoa san pham");
            Console.WriteLine("4. In toan bo cua hang");
            Console.WriteLine("5. Loc san pham");
            Console.WriteLine("6. Thoat");
            Console.Write("Lua chon cua ban: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Thêm sản phẩm
                    Console.Write("Nhap ten hang: ");
                    string ten = Console.ReadLine();
                    Console.Write("Nhap loai hang: ");
                    string loai = Console.ReadLine();
                    Console.Write("Nhap khoi luong: ");
                    double khoiLuong = double.Parse(Console.ReadLine());
                    Console.Write("Nhap gia: ");
                    double gia = double.Parse(Console.ReadLine());
                    Console.Write("Nhap ma hang: ");
                    string ma = Console.ReadLine();

                    var hangMoi = new Hang(ten, loai, khoiLuong, gia, ma);
                    bool daThem = false;
                    var temp = kho.GetHead();
                    do
                    {
                        if (temp.Ke.LoaiHang == loai)
                        {
                            temp.Ke.ThemHang(hangMoi);
                            daThem = true;
                            break;
                        }
                        temp = temp.Next;
                    } while (temp != kho.GetHead());

                    if (!daThem)
                        Console.WriteLine("Khong co ke phu hop voi loai hang nay.");
                    else
                        Console.WriteLine("Them san pham thanh cong.");
                    break;

                case "2":
                    // Cập nhật sản phẩm
                    Console.Write("Nhap ma hang can cap nhat: ");
                    string maCapNhat = Console.ReadLine();
                    KhoHang.NodeKe keCapNhat = kho.TimKeChuaHang(maCapNhat);
                    if (keCapNhat != null)
                    {
                        Console.Write("Nhap ten hang moi: ");
                        string tenMoi = Console.ReadLine();
                        Console.Write("Nhap khoi luong moi: ");
                        double khoiLuongMoi = double.Parse(Console.ReadLine());
                        Console.Write("Nhap gia moi: ");
                        double giaMoi = double.Parse(Console.ReadLine());

                        keCapNhat.Ke.ThemHang(new Hang(tenMoi, keCapNhat.Ke.LoaiHang, khoiLuongMoi, giaMoi, maCapNhat));
                        Console.WriteLine("Cap nhat thanh cong.");
                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay hang hoa voi ma da nhap.");
                    }
                    break;

                case "3":
                    // Xóa sản phẩm
                    Console.Write("Nhap ma hang can xoa: ");
                    string maXoa = Console.ReadLine();
                    KhoHang.NodeKe keXoa = kho.TimKeChuaHang(maXoa);
                    if (keXoa != null)
                    {
                        // Cần thêm phương thức XoaHang vào class Ke
                        Console.WriteLine("Xoa san pham thanh cong.");
                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay hang hoa voi ma da nhap.");
                    }
                    break;

                case "4":
                    // In tất cả sản phẩm
                    kho.XemTatCaKe();
                    break;

                case "5":
                    // Lọc sản phẩm
                    Console.WriteLine("Chon loai loc: ");
                    Console.WriteLine("1. Loc theo gia");
                    Console.WriteLine("2. Loc theo khoi luong");
                    Console.WriteLine("3. Loc theo loai san pham");
                    string locChoice = Console.ReadLine();

                    if (locChoice == "1")
                    {
                        Console.Write("Nhap gia can loc: ");
                        double giaLoc = double.Parse(Console.ReadLine());
                        Console.Write("Loc san pham co gia lon hon hay be hon? (Nhap 1 cho lon hon, 2 cho be hon): ");
                        string giaCondition = Console.ReadLine();
                        bool lonHon = giaCondition == "1";
                        kho.LocHangTheoGia(giaLoc, lonHon);
                    }
                    else if (locChoice == "2")
                    {
                        Console.Write("Nhap khoi luong can loc: ");
                        double khoiLuongLoc = double.Parse(Console.ReadLine());
                        Console.Write("Loc san pham co khoi luong lon hon hay be hon? (Nhap 1 cho lon hon, 2 cho be hon): ");
                        string khoiLuongCondition = Console.ReadLine();
                        bool lonHon = khoiLuongCondition == "1";
                        kho.LocHangTheoKhoiLuong(khoiLuongLoc, lonHon);
                    }
                    else if (locChoice == "3")
                    {
                        Console.Write("Nhap loai san pham can loc: ");
                        string loaiLoc = Console.ReadLine();
                        kho.LocHangTheoLoai(loaiLoc);
                    }
                    break;
                case "6":
                    Console.WriteLine("Thoat chuong trinh.");
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le, vui long thu lai.");
                    break;
            }

            Console.WriteLine("Nhan phim bat ky de tiep tuc...");
            Console.ReadKey();
        }
    }
}
