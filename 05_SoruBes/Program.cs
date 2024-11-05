using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SoruBes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayının faktöriyelini hesaplayan uygulamayı yazınız.

            // 3! => 3 * 2 * 1;

            #region 1. Çözüm
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int girilenSayi = int.Parse(Console.ReadLine());
            int sonuc = 1;
            for (int i = girilenSayi; i > 0; i--)
            {
                sonuc *= i; // Her bir i değeri -1 olduğu için faktöriyel hesaplanıyoe
            }
            Console.WriteLine(sonuc);
            #endregion // 1. Çözüm

            #region 2. Çözüm
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc2 = 1;

            while (sayi > 0)
            {
                sonuc2 *= sayi;
                sayi--;

            }
            Console.WriteLine(sonuc2);
            #endregion // 2. Çözüm

            #region 3. Çözüm
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi3 = int.Parse(Console.ReadLine());
            int sonuc3 = 1;
            do
            {
                sonuc3 *= sayi3;
                sayi3--;
                if (sayi3 == 0) break;
            }
            while (true);
            Console.WriteLine(sonuc3);
            #endregion // 3. Çözüm

            #region 4. Çözüm
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            int sonuc4 = 1;
            string _sonuc = "";

            while (sayi4 > 0)
            {
                sonuc4 *= sayi4;
                if (sayi4 != 1)
                    _sonuc += $"{sayi4} X ";
                else
                    _sonuc += $"{sayi4} = {sonuc4}";
                sayi4--;
            }
            Console.WriteLine(_sonuc);

            #endregion // 4. Çözüm

            #region 5. Çözüm
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi5 = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktoriyel(sayi5));
            #endregion
            Console.Read();
        }



        #region 5. Çözüm
        static int Faktoriyel(int sayi)
        {
            if(sayi >1)
            {
                return sayi * Faktoriyel(--sayi);
            }
            return sayi;
        }
        #endregion // 5. Çözüm

    }

}
