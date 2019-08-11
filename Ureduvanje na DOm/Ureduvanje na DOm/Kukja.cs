namespace Ureduvanje_na_DOm
{
    public class Kukja
    {
        Soba soba = new Soba();
        public Soba Sobce { get; set; }
        public string Adresa { get; set; }

       public Kukja()
        {


        }

        public Kukja(Soba sobce, string adresa)
        {
            Sobce = sobce;
            Adresa = adresa;
        }

        public void pecati()
        {

            soba.pecatiI();

        }

    }
}
