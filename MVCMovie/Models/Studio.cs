namespace MvcMovie.Models;
public class Studio
{
    public int StudioId { get; set; }
    public string Nome { get; set; }

    public string Pais { get; set; }
    public ICollection<Movie>? Movies {get; set;}
}
