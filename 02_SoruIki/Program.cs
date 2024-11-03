using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoruIki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği iki sayının karelerinin toplamını veren uygulamayı yazınız?

            // İki tane sayı lazım, kullanıcı girecek
            // sayıların karelerini al, topla ekrana yazdır.

            #region Çözümler
            #region Kendi Çözümüm
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sayi1Kare = sayi1 * sayi1;
            int sayi2Kare = sayi2 * sayi2;

            Console.WriteLine(sayi1Kare + sayi2Kare);
            #endregion // Kendi Çözümüm

            #region Çözüm 1
            Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            int sayi3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            int sayi4 = int.Parse(Console.ReadLine());

            int sonuc = sayi3 * sayi3 + sayi4 * sayi4;
            Console.WriteLine(sonuc);
            #endregion // Çözüm 1

            #region Çözüm 2
            Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            int sayi5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            int sayi6 = Convert.ToInt32(Console.ReadLine());

            // Math sınıfını kullanıyoruz.
            // Math.Pow(2, 3); 2 nin 3. kuvveti

            double sonuc2 = Math.Pow(sayi5, 2) + Math.Pow(sayi6, 2);
            // aşağıda double olan dönüş türünü int e cast ettik
            int sonuc3 = (int)Math.Pow(sayi5, 2) + (int)Math.Pow(sayi6, 2);
            Console.WriteLine(sonuc3);
            #endregion // Çözüm 2

            #region Çözüm 3
            Console.WriteLine("Lütfen birinci ve ikinci sayıları giriniz.");
            // double sonuc4 = Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2);
            Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2));
            #endregion // Çözüm 3
            #endregion // Çözümler
            Console.Read();
        }
    }
}
