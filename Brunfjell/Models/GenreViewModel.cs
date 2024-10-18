using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Brunfjell.Models;

public class GenreViewModel
{
    public List<Gallery>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? Genre { get; set; }
    public string? SearchString { get; set; }
}