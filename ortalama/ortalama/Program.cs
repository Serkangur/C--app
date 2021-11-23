using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir adet sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int a = 1;

            do
            {
                toplam = toplam + a;
                a++;

            } while (a <= sayi);
            Console.WriteLine("girdiğiniz sayıya kadar olan tüm sayıların toplamı: " + toplam);
            Console.WriteLine("ortalaması: " + (toplam / sayi));
            Console.ReadLine();
        }
    }
}
