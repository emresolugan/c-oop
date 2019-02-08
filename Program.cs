using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface vites
    {
        int vites { get; set; }
        void VitesArttir();
          void vitesDusur();
    }
    abstract class Car
    {
        public string Marka;
        public int vitessayisi;
        public int hiz;

        public abstract void hizartir();
        public abstract void hizdüsür();
       
    }

    class Mercedes : Car, vites
    {
        public int vitess;
        public int vites { get { return vitess; } set { vitess = value; } }

        public override void hizartir()
        {
            hiz++;
            Console.WriteLine("Yeni Hız");
            Console.WriteLine("Hiz: {0}", hiz);
        }

        public override void hizdüsür()
        {
            hiz--;
            Console.WriteLine("Yeni Hız");
            Console.WriteLine("Hiz: {0}", hiz);
        }

        public void VitesArttir()
        {
            vites++;
            Console.WriteLine("Yeni Vites");
            Console.WriteLine("Vites: {0}", vites);
        }

        public void vitesDusur()
        {
            vites--;
            Console.WriteLine("Yeni Vites");
            Console.WriteLine("Vites: {0}", vites);
        }
    }

    class Bmw : Car, vites
    {
        public int vitess;
        public int vites { get { return vitess; } set { vitess = value; } }

        public override void hizartir()
        {
            hiz++;
            Console.WriteLine("Yeni Hız");
            Console.WriteLine("Hiz: {0}", hiz);
        }

        public override void hizdüsür()
        {
            hiz--;
            Console.WriteLine("Yeni Hız");
            Console.WriteLine("Hiz: {0}", hiz);
        }

        public void VitesArttir()
        {
            vites++;
            Console.WriteLine("Yeni Vites");
            Console.WriteLine("Vites: {0}", vites);
        }

        public void vitesDusur()
        {
            vites--;
            Console.WriteLine("Yeni Vites");
            Console.WriteLine("Vites: {0}", vites);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes m = new Mercedes();
            Bmw b = new Bmw();
            m.hiz = 50;
            b.hiz = 45;
            m.vites = 2;
            m.vites = 2;
            m.hizartir();
            m.hizartir();
            m.hizartir();
            m.hizdüsür();
            m.VitesArttir();
            m.vitesDusur();
            m.VitesArttir();
            m.VitesArttir();
            Console.ReadKey();
        }

    }
}
