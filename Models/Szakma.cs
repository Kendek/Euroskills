namespace Euriskills.Models
{
    public class Szakma
    {
        public string Id { get; set; }
        public string szakmaNev { get; set; }
        public ICollection<Versenyzo> Versenyzok {  get; set; }
    }
}
