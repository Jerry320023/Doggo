namespace SchroniskoPsy.Models
{
    public class Psy
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public string Charakter { get; set; }
        public string Rasa { get; set; }
        public string Plec { get; set; }
        public int SchroniskoID { get; set; }
        public virtual Schronisko? Schronisko { get; set; }
    }
}
