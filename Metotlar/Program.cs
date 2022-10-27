using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Fiyati + " " + urun.Aciklama);
            }
            Console.WriteLine("----------Metotlar---------");
            sepetmanager spt = new sepetmanager();
            spt.ekle(urun1);
            spt.ekle(urun2);
            




            Console.ReadLine();
        }
    }
}
