using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.OyuncuAd = "Ronaldo";
            oyuncu1.OyuncuNumara = 7;
            oyuncu1.OyuncaTakim = "Manchester United";

            Oyuncu oyuncu2 = new Oyuncu();
            oyuncu2.OyuncuAd = "Neymar";
            oyuncu2.OyuncuNumara = 10;
            oyuncu2.OyuncaTakim = "Psg";

            Oyuncu[] oyuncular = new Oyuncu[] { oyuncu1, oyuncu2 };
            foreach (Oyuncu oyuncu in oyuncular)
            {
                Console.WriteLine("İncelediğimiz Oyuncular: "+oyuncu.OyuncuAd+" "+oyuncu.OyuncuNumara+" "+oyuncu.OyuncaTakim);
            }

            OyuncuManager oyuncumanager = new OyuncuManager();
            oyuncumanager.ekle(oyuncu1);
            oyuncumanager.ekle(oyuncu2);
            Console.ReadLine();


        }
    }
}
