using System.Collections.Generic;

namespace StarWarsProjectFinal.Models
{
    public class ChildrenTokens
    {
        public string count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<object> results { get; set; }
        public List<object> films { get; set; }
    }
}
