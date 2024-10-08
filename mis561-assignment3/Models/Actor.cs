using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace mis561_assignment3.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        
        [DisplayName("IMDB Link")]
        public string IMDBLink { get; set; }

        [DataType(DataType.Upload)]
        [DisplayName("Actor Image")]
        public byte[]? ActorImage { get; set; }
    }
}
