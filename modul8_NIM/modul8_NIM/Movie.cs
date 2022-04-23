using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace modul8_1302201140
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

        public Movie(string title, string director, List<string> stars, string description)
        {
            Title = title;
            Director = director;
            Stars = stars;
            Description = description;


        }

        
    }
}
