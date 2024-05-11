using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOgrenciKayit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList ogrenciler = new ArrayList();
            string secenek = "e";
            while(secenek == "e")
            {
                Ogrenci ogr = new Ogrenci();
                Console.Write("Lütfen öğrenci adını giriniz= ");
                ogr.Isim = Console.ReadLine();

                Console.Write("Lütfen öğrenci soyadını giriniz= ");
                ogr.SoyIsim = Console.ReadLine();

                Console.Write("Lütfen öğrenci numarasını giriniz= ");
                ogr.OkulNo = Convert.ToInt32(Console.ReadLine());
                ogrenciler.Add(ogr);

                Console.WriteLine("Öğrenci eklemeye devam edilsin mi? = e/h");
                secenek = Console.ReadLine();
            }
            Console.WriteLine("*-*-*-*-Öğrenciler-*-*-*-*");
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                Ogrenci veri = (Ogrenci)ogrenciler[i];
                Console.WriteLine("No = " + veri.OkulNo + ") "+ veri.Isim + " " + veri.SoyIsim);
            }
        }
    }

    class Ogrenci
    {
        public int OkulNo{ get; set; }

        public string Isim { get; set; }

        public string SoyIsim { get; set; }

    }




}
