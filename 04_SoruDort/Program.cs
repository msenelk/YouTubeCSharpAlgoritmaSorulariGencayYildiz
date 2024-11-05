using System;

namespace _04_SoruDort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Doğum tarihi girilen kişinin yaşını hesaplayan uygulamayı yazınız?

            // DoğumTarihi
            // BugününTarihi

            #region 1. Çözüm
            Console.WriteLine("Lütfen doğum tarihini yazınız.");
            DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine()); // Kullanıcıdan aldığımız veriyi DateTime ile tarihe convert ettik.
            TimeSpan sonuc = DateTime.Now - dogumTarihi; // İki tarih arası işlem yaptığımızda bize TimeSpan olarak döndü.
            Console.WriteLine(sonuc.Days / 365); // TimeSpan ın gün parametresini kullanarak 365 e bölüp yılı bulduk.
            #endregion // 1. Çözüm

            #region 2. Çözüm
            Console.WriteLine("Lütfen doğum tarihini giriniz.");
            DateTime dogumTarihi2 = DateTime.Parse(Console.ReadLine());
            DateTime bugun = DateTime.Now;

            int yas = bugun.Year - dogumTarihi2.Year;

            if (dogumTarihi2 > bugun.AddDays(-yas))
            {
                yas--;
            }
            Console.WriteLine(yas);
            #endregion // 2. Çözüm

            #region 3. Çözüm
            Console.WriteLine("Lütfen doğum tarihi giriniz.");
            DateTime dogumTarihi3 = DateTime.Parse(Console.ReadLine());

            int gun = (DateTime.Now - dogumTarihi).Days;

            int yas3 = gun / 365;
            int kalan = gun % 365;

            Console.WriteLine($"Yaş: {yas3} | {yas3 + 1} yaşınıza kalan gün sayısı : {365 + (yas3 * 1 / 4) - kalan}");
            #endregion

            Console.Read();
        }
    }
}
