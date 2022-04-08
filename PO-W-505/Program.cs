// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe
using System;

namespace PO_W_505
{
    // ========  1  ========
    //class Ssak
    //{ }
    //class Primatomorpha : Ssak
    //{ }
    //class HomoSapiens : Primatomorpha
    //{ }
    //class Woman : HomoSapiens
    //{ }

    // ========  2  ========
    class Ssak
    {
        private const string sposobKarmienia = "mleko matki";
        public string SposobKarmienia
        {
            get => sposobKarmienia;
        }
    }
    // ========  3  ========
    class Primatomorpha : Ssak
    {
        private string[] sposobPoruszania;
        public Primatomorpha()
        {
            sposobPoruszania = new string[3];
            sposobPoruszania[0] = "pływanie";
            sposobPoruszania[1] = "dwu i cztero nożny";
            sposobPoruszania[2] = "wyprostowany dwunożny";
        }
        public string this[int index]
        {
            get { return sposobPoruszania[index]; }
            set { sposobPoruszania[index - 1] = value; }
        }
    }
    // ========  4  ========
    class HomoSapiens : Primatomorpha
    {
        // średni współczynnik encefalizacji dla człowieka
        private float wielkoscMuzgu = 7.6F;
        public float WielkoscMuzgu
        {
            get => wielkoscMuzgu;
            set => wielkoscMuzgu = value;
        }
    }
    // ========  5  ========
    class Woman : HomoSapiens
    {
        private string _name;
        private string _kolorWlosow;
        private int _wzrost;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string KolorWlosow
        {
            get { return _kolorWlosow; }
            set { _kolorWlosow = value; }
        }
        public int Wzrost
        {
            get { return _wzrost; }
            set { _wzrost = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Woman jakas = new Woman();
            jakas.WielkoscMuzgu = 7.4F;
            Console.WriteLine(jakas.WielkoscMuzgu);
            Console.ReadKey();
        }
    }
}
