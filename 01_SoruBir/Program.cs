using System;

namespace _01_SoruBir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İki sayının toplamını veren uygulamayı yazınız.

            #region Çözüm 1
            int sayi1 = 10;
            int sayi2 = 20;

            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);

            // Daha kısa tanımlaması ve sonuc değişkenini kullanmadan ekrana yazdırma işlemi.
            int sayi3 = 10, sayi4 = 20;
            Console.WriteLine(sayi3 + sayi4);
            #endregion // Çözüm 1

            #region Çözüm 2
            Console.Write("Lütfen sayı1 değerini giriniz: ");
            // Kullanıcıdan alınan tüm değerler string yani metinsel değer olarak gelecektir.
            // Değeri hangi işlem tipine dair kullanılacaksa o tipe çevirme işlemi yapılmalıdır.
            #region String Tipi Int Tipine Çevirme

            #region Convert İle Çevirme
            int sayi5 = Convert.ToInt32(Console.ReadLine());
            #endregion // Convert İle Çevirme

            #region Parse Methodu İle Çevirme
            // yanında verilen tipe çevirilir.
            Console.Write("Lütfen sayı2 değerini giriniz: ");
            int sayi6 = int.Parse(Console.ReadLine());
            #endregion // Parse Methodu İle Çevirme

            #endregion // String Tipi Int Tipine Çevirme

            Console.WriteLine(sayi5 + sayi6);

            // Console.ReadLine programı bekletir, bir klavyeden değer beklenmektedir.
            #endregion // Çözüm 2

            #region Çözüm 3
            // Klavyeden sayısal veri yerine metinsel veri girildiği zaman uygulama hata verecektir. Bunun önüne geçebilmek için try - catch ile kontrol altına alınarak kullanıcıya bilgi verilecektir.

            // try =>  Hata oluşması muhtemel kod buraya yazılır.
            // catch => // Hata yakalandığında çalışacak kod buraya yazılır.

            int sayi7, sayi8;

            try
            {
                Console.Write("Lütfen sayı1 değerini giriniz: ");
                sayi7 = Convert.ToInt32(Console.ReadLine());


            }
            catch
            {
                Console.Write("Lütfen sayı1 değerini giriniz: ");
                sayi7 = Convert.ToInt32(Console.ReadLine());
            }

            // Her iki değer almayı da kontrol ediyoruz.

            try
            {
                Console.Write("Lütfen sayı2 değerini giriniz: ");
                sayi8 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Lütfen sayı2 değerini giriniz: ");
                sayi8 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sayi7 + sayi8);
            #endregion // Çözüm 3
            Console.ReadKey(); // Ekranın kapanmaması için yazıldı.
        }
    }
}
