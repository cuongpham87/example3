//in ra màn hình yêu cầu nhập một ký tự từ bàn phím
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("xin chào các bạn!");
        Console.Write("giới thiệu bản thân!");
        Console.Write("Tôi khá đẹp trai");
        //in ra màn hình yêu cầu nhập một ký tự từ bàn phím, chọn 1 số rồi in ra màn hình
        Console.WriteLine("nhập một số trên bàn phím");
        int so = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("" + so);
        //tính tổng số nguyên thứ nhất và số nguyên thứ hai 
        Console.WriteLine("số nguyên thứ nhất");
        int so1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("số nguyên thứ hai");
        int so2 = Convert.ToInt32(Console.ReadLine());
        int tong = so1 + so2;
        Console.WriteLine($"Tổng là {tong}");
        //tính tổng điểm của hai môn Toán và Lý trong kỳ thi 
        Console.WriteLine("điểm thi đại học hai môn toán lý");
        Console.WriteLine("Điểm thi đại học môn toán");
        int Toan = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Điểm thi đại học môn Lý");
        int Ly = Convert.ToInt32(Console.ReadLine());
        int Tong = Toan + Ly;
        Console.WriteLine($"Tổng{Tong}");
        // hãy tính tổng điểm ba môn Toán, Lý, Hóa kỳ thi học trung học cơ sở
 


    }
}
