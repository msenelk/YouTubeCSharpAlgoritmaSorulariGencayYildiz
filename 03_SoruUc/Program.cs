using System;

namespace _03_SoruUc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1'den 10'a kadar olan sayıların küplerinin toplamını bulan uygulamayı yazınız.

            #region Çözümler

            #region 1. Çözüm
            double toplamSonuc = 0;
            for (int i = 0; i < 11; i++)
            {
                // toplamSonucu += i * i * i; ilker yöntem :)
                toplamSonuc += Math.Pow(i, 3);
            }
            Console.WriteLine(toplamSonuc);
            #endregion // 1. Çözüm

            #region 2. Çözüm
            double _toplamSonuc =0;
            int sayac = 1;
            while (true)
            {
                _toplamSonuc += Math.Pow(sayac, 3);
                if (sayac == 10) // Sayac değeri 10 olduktan sonra döngüden çıkacak.
                    break;
                sayac++; 
            }
            Console.WriteLine(_toplamSonuc);
            #endregion // 2. Çözüm

            #region 3. Çözüm
            int _sayac = 1;
            double toplamSonuc2 = 0;
            do
            {
                toplamSonuc2 += Math.Pow(_sayac, 3);
                _sayac++;
            } while(_sayac <= 10);
            Console.WriteLine(toplamSonuc2);
            #endregion // 3. Çözüm

            #region 4. Çözüm
            int sayac4 = 1;
            double toplamSonuc4 = 0;
            string sonuc4 = "";
            while (sayac4 <= 10)
            {
                toplamSonuc4 += Math.Pow(sayac4, 3);

                if (sayac4 !=10)
                {
                    sonuc4 += $"{sayac4}³ +  ";
                }
                else
                {
                    sonuc4 += $"{sayac4}³ = {toplamSonuc4}";
                }
               sayac4++;
            }
            Console.WriteLine(sonuc4);


            #endregion // 4. Çözüm

            #endregion
            Console.Read();
        }
    }
}
