using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        public void Cikarma(int sayi1,int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine(sonuc);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine(sonuc);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine(sonuc);
        }

    }
}
