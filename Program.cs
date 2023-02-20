using System;

namespace _2._ürüne_indirim
{
    class Program
    {
        static void Main(string[] args)
        {
            double urun1, urun2, toplam;
            
            Console.Write("Birinci Ürünün Fiyatını Giriniz= ");
            urun1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci Ürünün Fiyatını Giriniz= ");
            urun2 = Convert.ToDouble(Console.ReadLine());

            toplam = urun1 + urun2;

            if (toplam >= 200)
            {
                toplam -= urun2 * 0.25;
                Console.Write("İndirimli Toplam Fiyat = {0} TL", toplam);
            }
            else
            {
                Console.Write("Normal Toplam Fiyat = {0} TL", toplam);
            }
            Console.ReadKey();
        }
    }
}
