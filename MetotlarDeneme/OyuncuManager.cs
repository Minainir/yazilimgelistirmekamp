using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarDeneme
{
    class OyuncuManager
    {
        public void ekle(Oyuncu eklenenoyuncu)
        {
            Console.WriteLine("Bloğa eklenen oyuncu: " + eklenenoyuncu.OyuncuAd + " " + eklenenoyuncu.OyuncuNumara + " " + eklenenoyuncu.OyuncaTakim);
        }
    }
}
