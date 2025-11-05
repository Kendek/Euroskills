namespace Euriskills.Models
{
    public class Versenyzo
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string szakmaId { get; set; }
        public string orszagId { get; set; }
        public int Pont { get; set; }
        public Szakma Szakma { get; set; }
        public Orszag Orszag { get; set; }
    }
}
