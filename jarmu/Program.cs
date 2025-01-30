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
        }


    }

    class Kedevenc 
    {
        int kerekekSzama;
        string name;
        string szin;
        double suj;
        Kedevenc(int kerekekSzama, string name, string szin, double suj)
        {
            this.kerekekSzama = kerekekSzama;
            this.name = name;
            this.szin = szin;
            this.suj = suj;
        }
        Kedevenc(string name, string szin, double suj)
        {
            this.kerekekSzama = 2;
            this.name = name;
            this.szin = szin;
            this.suj = suj;
        }
    }   
}
