using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedevenc skibidi = new Kedevenc("István", "lila", 62);
            Console.WriteLine(skibidi.ToString());
            Console.WriteLine(skibidi.Kerekfelezo());
            Console.ReadKey();
            //nem voltam előző órán :c
        }


    }

    class Kedevenc
    {
        private int kerekekSzama;
        private string name;
        private string szin;
        private double suj;
        public Kedevenc(string name, string szin, double suj, int kerekekSzama)
        {
            this.kerekekSzama = kerekekSzama;
            this.name = name;
            this.szin = szin;
            this.suj = suj;
        }
        public Kedevenc(string name, string szin, double suj)
        {
            this.kerekekSzama = 2;
            this.name = name;
            this.szin = szin;
            this.suj = suj;
        }
        public string Name { get { return this.name; } }
        public int Kerekekszama { get { return this.kerekekSzama; } }
        public double Suj { get { return this.suj; } }
        public string Szin { get { return this.szin; } set { this.szin = value; } }
        public override string ToString()
        {
            return name + ";" + szin + ";" + suj + ";" + kerekekSzama;
        }
        public int Kerekfelezo() 
        {
            kerekekSzama = kerekekSzama / 2;
            return kerekekSzama;
        }
    }   

}
