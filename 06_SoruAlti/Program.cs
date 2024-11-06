using System;
using System.Runtime.CompilerServices;

namespace _06_SoruAlti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pozitif sayılarda çarpma işlemini toplama kullanarak bulan uygulamayı yazınız.

            #region Çözümler
            #region 1. Çözüm
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int carpmaSonucu = 0;
            for (int i = 0; i < sayi1; i++)
            {
                carpmaSonucu += sayi2;
            }
            Console.WriteLine($"{sayi1} X {sayi2} = {carpmaSonucu}");
            #endregion // 1. Çözüm

            #region 2. Çözüm
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            int sayac = sayi4;
            int sonuc = 0;
            while (sayac > 0)
            {
                sonuc += sayi3;
                sayac--;
            }
            Console.WriteLine($"{sayi3} X {sayi4} = {sonuc}");

            #endregion // 2. Çözüm

            #region 3. Çözüm
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi6 = Convert.ToInt32(Console.ReadLine());

            int sonuc3 = 0;
            int sayac3 = sayi6;

            do
            {
                sonuc3 += sayi5; ;
                sayac3--;
            } while (sayac3 > 0);

            Console.WriteLine($"{sayi5} X {sayi6} = {sonuc3}");
            #endregion // 3. Çözüm

            #region 4. Çözüm
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            int sayi8 = int.Parse(Console.ReadLine());


            Console.WriteLine(Topla(sayi7,sayi8));
            #endregion // 4. Çözüm

            #endregion // Çözümler
            Console.Read();
        }
        // Eğer ki bir fonksiyon kendi içerisinde kendini çağırıyorsa ona recursive fonksiyon denir.
        // Recursive fonksiyonlar döngüsel işlemler yapmamızı sağlayan manevralar oluştururlar.
        static int Topla(int sayi1, int sayi2)
        {
            if(sayi2 > 1)
            {
                return sayi1 + Topla(sayi1, --sayi2);
            }
            return sayi1;
        }
    }
}
