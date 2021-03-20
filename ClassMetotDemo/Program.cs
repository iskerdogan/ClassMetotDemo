using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Erdoğan";
            musteri1.MusteriSoyad = "IŞIK";
            musteri1.MusteriMiktar = 500000;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Yusuf";
            musteri2.MusteriSoyad = "IŞIK";
            musteri2.MusteriMiktar = 2000000;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Emine";
            musteri3.MusteriSoyad = "IŞIK";
            musteri3.MusteriMiktar = 1000000;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAd = "Şevval";
            musteri4.MusteriSoyad = "IŞIK";
            musteri4.MusteriMiktar = 600000;

            Musteri musteri5 = new Musteri();
            musteri5.MusteriAd = "Ahu Zülal";
            musteri5.MusteriSoyad = "IŞIK";
            musteri5.MusteriMiktar = 400000;

            Musteri musteri6 = new Musteri();
            musteri6.MusteriAd = "Mehmet Erdem";
            musteri6.MusteriSoyad = "IŞIK";
            musteri6.MusteriMiktar = 500000;

            Musteri[] musterliler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, musteri6 };

            MusteriManager MusteriManager = new MusteriManager();
            MusteriManager.Ekle(musteri1);
            MusteriManager.Ekle(musteri2);
            MusteriManager.Ekle(musteri3);
            MusteriManager.Ekle(musteri4);
            MusteriManager.Ekle(musteri5);
            MusteriManager.Ekle(musteri6);
            Console.WriteLine("------------------------------------------------------------------");
            MusteriManager.Sil(musteri1);
            MusteriManager.Sil(musteri2);
            MusteriManager.Sil(musteri3);
            MusteriManager.Sil(musteri4);
            MusteriManager.Sil(musteri5);
            MusteriManager.Sil(musteri6);
            Console.WriteLine("------------------------------------------------------------------");
            MusteriManager.Listele(musterliler);
        }
    }
}
