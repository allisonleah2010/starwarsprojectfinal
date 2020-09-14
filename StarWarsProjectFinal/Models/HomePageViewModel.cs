using System.Collections.Generic;

namespace StarWarsProjectFinal.Models
{
    public class HomePageViewModel
    {
        public string SearchName { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<PersonViewModel> People { get; set; }
    }
}
