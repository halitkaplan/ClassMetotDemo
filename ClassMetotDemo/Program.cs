using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAdi = Console.ReadLine();
            musteri.MusteriSoyadi = Console.ReadLine();
            musteri.MusteriTC = Convert.ToString(Console.ReadLine());

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri);

        }
    }
}
