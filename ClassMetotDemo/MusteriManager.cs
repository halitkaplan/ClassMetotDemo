﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Eklendi -> " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriTC);
            
            
        }


    }
}
