using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ora
{       

    class Auto
    {
        public string tipus { get; set; }
        public int ev { get; set; }
        public string rendszam { get; set; }
        public string szin { get; set; }

        public int korkiir()
        {
            int kor = 2022 - ev;

            return kor;
        }

        public Auto(string _rendszam)
           {
            rendszam = _rendszam;
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Auto("ABCD-123");
            a1.ev = 2010;
            a1.szin = "zold";
            a1.tipus = "suzuki";
            Console.WriteLine($"A {a1.tipus} {a1.korkiir()} éves");





           
            Console.ReadLine();
        }
    }
}
