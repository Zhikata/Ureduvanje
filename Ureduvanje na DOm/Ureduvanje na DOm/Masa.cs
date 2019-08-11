using System;

namespace Ureduvanje_na_DOm
{
    public class Masa
    {
        public int Dolzina { get; set; }
        public int Shirina { get; set; }

       public Masa()
        { 
        }

        public Masa(int dolzina, int shirina)
        {
            Dolzina = dolzina;
            Shirina = shirina;
        }

        public void pecati()
        {
            Console.WriteLine($"{Dolzina}{Shirina}");

        }



    }
}
