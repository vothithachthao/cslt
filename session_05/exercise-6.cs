using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cslt.session_05
{
    //Tinh tong hai so nguyen
    internal class Bai1_TinhTong
    {
        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        static void Main6(string[] args)
        {
            int ketQua = TinhTong(5, 7);

            Console.WriteLine("Tong = " + ketQua);
        }
    }
    //Kiem tra so chan le
    internal class Bai2_KiemTraChanLe
    {
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        static void Main6(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (KiemTraChan(n))
                Console.WriteLine(n + " la so chan");
            else
                Console.WriteLine(n + " la so le");
        }
    }
    //Tim so lon nhat trong 3 so
    internal class Bai3_TimMax
    {
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        static void Main6()
        {
            int max = TimMax(10, 25, 15);

            Console.WriteLine("So lon nhat: " + max);
        }
    }
    //Tinh giai thua cua mot so
    internal class Bai4_GiaiThua
    {
        static long TinhGiaiThua(int n)
        {
            long ketQua = 1;

            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }

            return ketQua;
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + "! = " + TinhGiaiThua(n));
        }
    }
    //Dao nguoc chuoi ky tu
    internal class Bai5_DaoNguocChuoi
    {
        static string DaoNguocChuoi(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine("Chuoi dao nguoc: " + DaoNguocChuoi(s));
        }
    }
    //Kiem tra so nguyen to
    internal class Bai6_SoNguyenTo
    {
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(KiemTraNguyenTo(n));
        }
    }
    //In day Fibonacci
    internal class Bai7_Fibonacci
    {
        static void InFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int temp = a + b;
                a = b;
                b = temp;
            }
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            InFibonacci(n);
        }
    }
    //Dem so luong nguyen am trong chuoi
    internal class Bai8_DemNguyenAm
    {
        static int DemNguyenAm(string s)
        {
            int dem = 0;
            foreach (char c in s.ToLower())
            {
                if ("aeiou".Contains(c))
                    dem++;
            }
            return dem;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine("So nguyen am: " + DemNguyenAm(s));
        }
    }
    //Tinh luy thua
    internal class Bai9_LuyThua
    {
        static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;

            for (int i = 1; i <= y; i++)
            {
                ketQua *= x;
            }
            return ketQua;
        }
        static void Main6(string[] args)
        {
            Console.WriteLine(TinhLuyThua(2, 3));
        }
    }
    //Tinh diem trung binh cua mang
    internal class Bai10_TrungBinhMang
    {
        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;
            foreach (int x in arr)
            {
                tong += x;
            }
            return (double)tong / arr.Length;
        }
        static void Main6(string[] args)
        {
            int[] arr = { 4, 5, 6, 7 };
            Console.WriteLine(TinhTrungBinh(arr));
        }
    }
    //Kiem tra chuoi doi xung
    internal class Bai11_DoiXung
    {
        static bool KiemTraDoiXung(string s)
        {
            string dao = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                dao += s[i];
            }
            return s == dao;
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine(KiemTraDoiXung(s));
        }
    }
    //Chuyen doi nhiet do
        internal class Bai12_ChuyenDoiNhietDo
        {
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap do C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Do F: " + CelsiusToFahrenheit(c));
        }
    }
    //Tim gia tri nho nhat trong mang
    internal class Bai13_TimMin
    {
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            foreach (int x in arr)
            {
                if (x < min)
                    min = x;
            }
            return min;
        }
        static void Main6(string[] args)
        {
            int[] arr = { 10, 5, 8, 2, 9 };
            Console.WriteLine("Min = " + TimMin(arr));
        }
    }
    //Tinh tong cac chu so của mot so nguyen
    internal class Bai14_TongChuSo
    {
        static int TongCacChuSo(int n)
        {
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            return tong;
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong chu so = " + TongCacChuSo(n));
        }
    }
    //Sap xep mang tang dan
    internal class Bai15_SapXepMang
    {
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }
        static void Main6(string[] args)
        {
            int[] arr = { 3, 1, 4, 2 };
            SapXepMang(arr);
        }
    }
    //Xoa ky tu trung lap
    internal class Bai16_XoaTrungLap
    {
        static string XoaTrungLap(string s)
        {
            string ketQua = "";
            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }
            return ketQua;
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine(XoaTrungLap(s));
        }
    }
    //Tim uoc chung lơn nhat
    internal class Bai17_UCLN
    {
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main6(string[] args)
        {
            Console.WriteLine(UCLN(12, 18));
        }
    }
    //Chuyen doi he thap phan sang nhi phan
    internal class Bai18_NhiPhan
    {
        static string DecimalToBinary(int n)
        {
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            return binary;
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap so thap phan: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(n));
        }
    }
    //Kiem tra nam nhuan
    internal class Bai19_NamNhuan
    {
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) ||
                   (year % 4 == 0 && year % 100 != 0);
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap nam: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(KiemTraNamNhuan(year));
        }
    }
    //Dem so tu trong cau
    internal class Bai20_DemSoTu
    {
        static int DemSoTu(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        static void Main6(string[] args)
        {
            Console.Write("Nhap cau: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("So tu: " + DemSoTu(sentence));
        }
    }
}