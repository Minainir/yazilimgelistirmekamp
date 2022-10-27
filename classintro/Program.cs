using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimgelistirmekamp
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursad = "C#";
            kurs1.egitmenad = "Engin Demiroğ";
            kurs1.izlenmeorani = 85;

            kurs kurs2 = new kurs();
            kurs2.kursad = "Java";
            kurs2.egitmenad = "Murat Yücedağ";
            kurs2.izlenmeorani = 81;


            kurs kurs3 = new kurs();
            kurs3.kursad = "javascript";
            kurs3.egitmenad = "Angela Yu";
            kurs3.izlenmeorani = 70;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kursumuzun adı " + kurs.kursad + " Eğitmen Adı " + kurs.egitmenad + " izlenme oranları: " + kurs.egitmenad);
            }



            Console.ReadLine();
        }
    }

    class kurs
    {
        public string kursad { get; set; }
        public string egitmenad { get; set; }
        public int izlenmeorani { get; set; }
    }
}
