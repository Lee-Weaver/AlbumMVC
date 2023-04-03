using System.ComponentModel.DataAnnotations;

namespace AlbumMVC.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }  

    }
}
