using System;
using System.Text;
namespace timuocso
{
    class Program
    {
        static int uocso(int a, int b)
        {
            int j = (a < b) ? a : b;
            for (int i = 1; i <= j; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    int ketqua = i;
                    return ketqua;
                }
            } return a;
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n1, n2, uscln;
            Console.Write("Nhập a: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập b: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            uscln = Program.uocso(n1, n2);
            Console.Write("Ước số chung lớn nhất của {0} và {1} là: {2}", n1, n2, uscln);
            Console.ReadKey();
        }

    }
}
