namespace Euriskills.Models
{
    public class Orszag
    {
        public string Id { get; set; }
        public string orszagNev { get; set; }
        public ICollection<Versenyzo> Versenyzok { get; set; }
    }
}
