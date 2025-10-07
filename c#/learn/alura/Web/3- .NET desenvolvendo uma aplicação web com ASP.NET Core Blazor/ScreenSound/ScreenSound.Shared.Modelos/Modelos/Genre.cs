
using ScreenSound.Modelos;

namespace ScreenSound.Shared.Modelos.Modelos;

public class Genre
{
    public int Id { get; set; }
    public string? Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public virtual ICollection<Song> Songs { get; set; }

    public Genre(string? name, string? description)
    {
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        return $"Nome: {Name} - Descrição: {Description}";
    }
}