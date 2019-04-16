using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCdotNetCRUDapp.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies;
        public SelectList Genres;
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
