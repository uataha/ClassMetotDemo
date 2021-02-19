using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet Bey";
            musteri1.Parasi = 36000;
            musteri1.Tc = "11111111111";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Aslı Hanım";
            musteri2.Parasi = 22500;
            musteri2.Tc = "11111111112";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Sercan Bey";
            musteri3.Parasi = 12311;
            musteri3.Tc = "11111111113";

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Elif Hanım";
            musteri4.Parasi = 450;
            musteri4.Tc = "11111111114";

            Musteri musteri5 = new Musteri();
            musteri5.Adi = "Gamze Hanım";
            musteri5.Parasi = 2000;
            musteri5.Tc = "11111111115";
            
            
            
            
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri2, musteri3, musteri4 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri İsmi: "+musteri.Adi);
                Console.WriteLine("Musteri Hesabındaki Para: "+musteri.Parasi);
                Console.WriteLine("Musteri Tc Kimlik No: "+musteri.Tc);
            }
            Console.WriteLine("Sonradan Giriş Yapan Müşterilerin Bilgileri Aşağıdadır.");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekleme(musteri5);
            
        }
    }
}
