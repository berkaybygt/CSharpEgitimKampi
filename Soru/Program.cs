using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru1
            // Faktöriyel Hesaplama

            //Console.Write("Sayi Gir: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);
            #endregion

            #region Soru2
            // Dizi İçerisindeki En Büyük Sayı

            //int[] nums = { 4, 7, 1, 9, 4 };
            //int sonuc = nums[0];

            //for (int i = 1; i < nums.Length; i++) 
            //{
            //    if (nums[i] > sonuc)
            //    {
            //        sonuc = nums[i];
            //    }
            //}
            //Console.WriteLine(sonuc);
            #endregion

            #region Soru3
            // Dizide Tek ve Çift Sayıları Ayırma

            //int[] nums = { 12, 17, 5, 6, 3, 8 };

            //Console.Write("Tek sayılar: ");
            //foreach (int sayi in nums)
            //{
            //    if (sayi % 2 != 0)
            //        Console.Write($"{sayi} ");
            //}

            //Console.WriteLine();

            //Console.Write("Çift sayılar: ");
            //foreach (int sayi in nums)
            //{
            //    if (sayi % 2 == 0)
            //        Console.Write($"{sayi} ");
            //}
            #endregion

            #region Soru4
            // Sayı Tahmin

            //Random rnd = new Random();
            //int sayi = rnd.Next(1, 51);
            //int hak = 5;
            //int tahmin;

            //do
            //{
            //    Console.Write("Tahmin: ");
            //    tahmin = int.Parse(Console.ReadLine());

            //    if (tahmin > sayi)
            //        Console.WriteLine("Asagi");
            //    else if (tahmin < sayi)
            //        Console.WriteLine("Yukari");

            //    hak--;

            //    if (hak == 0)
            //    {
            //        Console.WriteLine($"Bitti. Sayi {sayi}");
            //        break;
            //    }
            //}
            //while (tahmin != sayi);

            //if (tahmin == sayi)
            //{
            //    Console.WriteLine("Doğru");
            //}
            #endregion

            #region Soru5

            #endregion

            Console.ReadKey();
        }
    }
}
