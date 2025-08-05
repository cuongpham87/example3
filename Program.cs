//in ra màn hình yêu cầu nhập một ký tự từ bàn phím
using System.ComponentModel;
using System.Diagnostics;

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

    }
}
