// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe
using System;
using System.Drawing;

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
    // I tak dla klasy HomoSapiens będą to na przykład
    // wartość jednego z podstawowych elementów różnicujących,
    // czyli średni współczynnik encefalizacji oraz ilość nóg,
    // co zadeklarować można w następujący sposób 
    class HomoSapiens : Primatomorpha
    {
        float _skullCapacity = 7.6F;
        int _legsNumber = 2;
        public float SkullCapacity { get => _skullCapacity; }
        public int LegsNumber { get => _legsNumber; }
    }

    // Na kolejnym poziomie dziedziczenia mamy Naczelne.
    // Po naczelnych może na przykład dziedziczyć
    // umiejscowienie oczu z przodu twarzoczaszki
    // oraz pięciopalczaste kończyny,
    // co w przełożeniu na język programowania można zapisać tak:
    class Primatomorpha : Ssak
    {
        string[] _eyesLocation;
        int _nbOfFingers = 5;
        public Primatomorpha()
        {
            _eyesLocation = new string[3];
            _eyesLocation[0] = "on the sides of the head";
            _eyesLocation[1] = "on the front of the head";
            _eyesLocation[2] = "on the top of the head";
        }
        public string this[int index]
        {
            get { return _eyesLocation[index]; }
        }
        public int NbOfFingers { get => _nbOfFingers; }
    }

    // Wreszcie Ssaki. Po nich też co nieco dziedziczy nasza Scarlett.
    // Niech to będzie ilość kręgów szyjnych i kosteczek słuchowych,
    // a zapisać to można tak:
    class Ssak
    {
        int _auditoryOssicles = 3;
        int _cervicalVertebrae = 7;
        public int AuditoryOssicles
        {
            get => _auditoryOssicles;
        }
        public int CervicalVertebrae
        {
            get => _cervicalVertebrae;
        }
    }

    // Pozostała nam jeszcze klasa główna, czyli klasa Woman,
    // ponieważ nasza Scarlett będzie jedynym i niepowtarzalnym
    // obiektem tego właśnie typu.
    // Można umieścić tu wiele cech charakterystycznych,
    // ale powiedzmy, że na potrzeby naszej konstrukcji wystarczy,
    // że damy możliwość ustalenia imienia, koloru włosów i wzrostu.
    // W takim wypadku klasa Woman mogła by przyjąć taką postać.
    class Woman : HomoSapiens
    {
        string _name;
        Color _hairColor;
        int _height;
        public Woman (string name, Color hairColor, int height)
        {
            _name = name;
            _hairColor = hairColor;
            _height = height;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public Color HairColor
        {
            get => _hairColor;
            set => _hairColor = value;
        }
        public int Height
        {
            get => _height;
            set => _height = value;
        }
    }

    // W celu sprawdzenia jak zadziała nasze dziedziczenie
    // wymodelujemy treść metody Main tak,
    // aby powołać do życia w niej obiekt klasy Woman
    // i pokazać wartości wszystkich pól z klasy własnej
    // oraz nadrzędnych jakie dziedziczy. 
    class Program
    {
        static void Main(string[] args)
        {
            Woman scarlettJohansson = new Woman("Scarlett", Color.Brown, 164);
            string eyesLocation = scarlettJohansson[1];
            Console.WriteLine("\n\n  właśnie powołałeś do życia obiekt klasy " +
                              "Woman, który posiada następujące cechy:");
            Console.WriteLine("\n  Po klasie Ssak Scarlett dziedziczy:");
            Console.WriteLine("  Liczba kostek słuchowych wynosi: " 
                              + scarlettJohansson.AuditoryOssicles);
            Console.WriteLine("  Liczba kręgów szyjnych to: " 
                              + scarlettJohansson.CervicalVertebrae);
            Console.WriteLine("\n  Po klasie Naczelne dziedziczy:");
            Console.WriteLine("  Oczy położone są: " + eyesLocation);
            Console.WriteLine("  Każda kończyna posiada " 
                              + scarlettJohansson.NbOfFingers + " palców.");
            Console.WriteLine("\n  A po klasie HomoSapiens dziedziczy:");
            Console.WriteLine("  Średni współczynnik encefalizacji równy: " 
                              + scarlettJohansson.SkullCapacity);
            Console.WriteLine("  Ilość nóg, która wynosi: " 
                              + scarlettJohansson.LegsNumber);
            Console.WriteLine("\n  I wreszcie jej unikalne cechy " +
                              "charakterystyczne to:");
            Console.WriteLine("  Imie: " + scarlettJohansson.Name);
            Console.WriteLine("  Kolor włosów: " + scarlettJohansson.HairColor);
            Console.WriteLine("  Wzrost: " + scarlettJohansson.Height);
            Console.ReadKey();
        }
    }
}
