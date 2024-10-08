using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace mis561_assignment3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Genre { get; set; }

        [DisplayName("IMDB Link")]
        public string IMDBLink { get; set; }

        [DisplayName("Release Year")]

        public int ReleaseYear { get; set; }

        [DataType(DataType.Upload)]
        [DisplayName("Movie Image")]
        public byte[]? MovieImage { get; set; }
    }
}
