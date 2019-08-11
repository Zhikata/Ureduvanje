using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ureduvanje_na_DOm
{
    class Program
    {

       static Kukja kukja = new Kukja();

    
        static void Main(string[] args)
        {
            System.Console.WriteLine("Vnesi broj na kukji");
            int brojNaKukji = System.Convert.ToInt32(System.Console.ReadLine());

            for(int i = 0; i < brojNaKukji; i++)
            {
                VnesiParametriZaKukji();
            }
        }

        public static void VnesiParametriZaKukji()
        {
            
            System.Console.WriteLine("Vnesi sirina na masa" );
            kukja.Sobce.Masicka.Shirina = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Vnesi dolzina na masa");
            kukja.Sobce.Masicka.Dolzina = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Vnesi sirina na soba");
            kukja.Sobce.ShirinaNaSoba = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Vnesi dolzina na soba");
            kukja.Sobce.DolzinaNaSoba = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Vnesi adresa");
            kukja.Adresa = (System.Console.ReadLine());
        }

    }
}
