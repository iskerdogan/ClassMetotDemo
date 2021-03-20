using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd+" "+musteri.MusteriSoyad+" "+"Adına Hesap oluşturuldu.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad +"'ın hesabı silindi.");
        }
        public void Listele(Musteri[] musteri )
        {
            foreach (Musteri musteriList in musteri)
            {
                Console.WriteLine("Müşterilerin Adları: " + musteriList.MusteriAd);
                Console.WriteLine("Müşterilerin Soyadları: " + musteriList.MusteriSoyad);
                Console.WriteLine("Müşterilerin Banka Hesabındaki Para: " + musteriList.MusteriMiktar);
                Console.WriteLine("------------------------------------------------------------------");


            }
        }
    }
}
