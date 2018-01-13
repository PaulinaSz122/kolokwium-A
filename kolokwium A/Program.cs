using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium_A
{
#region zadanie 1
    class Samochod
    {
        private float pojemnoscSilnika;
        private string nrVIN;
        public int rocznik;
        public string nazwa;
        public float srednieSpalanie;
        private enum TypTrasy
        {
            autostrada = 1
        };

        private Samochod() { }
        public static Samochod Create(float pojSil, string nrVIN, int rok, string name, float spalanie)
        {
            Samochod auto = new Samochod();

            auto.pojemnoscSilnika = pojSil;
            auto.nrVIN = nrVIN;
            auto.rocznik = rok;
            auto.nazwa = name;
            auto.srednieSpalanie = spalanie;

            return auto;
        }
        public double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy * (double)TypTrasy.autostrada;
        }
    }
#endregion


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
