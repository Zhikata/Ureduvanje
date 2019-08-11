namespace Ureduvanje_na_DOm
{
    public class Soba
    {

        Masa masa = new Masa();

        public Masa Masicka { get; set; }
        public int DolzinaNaSoba { get; set; }
        public int ShirinaNaSoba { get; set; }

        public Soba()
        {

        }

        public Soba(Masa masicka, int dolzinaNaSoba, int shirinaNaSoba )
        {
            Masicka = masicka;
            DolzinaNaSoba = dolzinaNaSoba;
            ShirinaNaSoba = shirinaNaSoba;


        }

        public void pecatiI()
        {

            masa.pecati();

        }
       
    }
}
