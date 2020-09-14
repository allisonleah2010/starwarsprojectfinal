using System.ComponentModel;

namespace StarWarsProjectFinal.Models
{
    public class PersonViewModel
    {
        public string Name { get; set; }

        [DisplayName("Birth Year")]
        public string BirthYear { get; set; }

        public string Height { get; set; }

        public string Mass { get; set; }

        [DisplayName("Eye Color")]
        public string EyeColor { get; set; }

        [DisplayName("Film Count")]
        public string FilmCount { get; set; }
    }
}
