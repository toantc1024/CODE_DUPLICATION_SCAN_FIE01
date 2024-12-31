public class Hang
{
    public string Ten { get; set; }
    public string Loai { get; set; }
    public double KhoiLuong { get; set; }
    public double Gia { get; set; }
    public string Ma { get; set; }
    public Hang(string ten, string loai, double khoiLuong, double gia, string ma)
    {
        Ten = ten;
        Loai = loai;
        KhoiLuong = khoiLuong;
        Gia = gia;
        Ma = ma;
    }
    public override string ToString()
    {
        return "Ten: " + Ten + ", Loai: " + Loai + ", KhoiLuong: " + KhoiLuong + ", Gia: " + Gia + ", Ma: " + Ma;
    }
}