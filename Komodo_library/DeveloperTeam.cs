using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_library
{
    public class DeveloperTeam
    {
        public List<Developer> Developer { get; set; }
        public string TeamName { get; set; }
        public int TeamIdentifier { get; set; }

        public DeveloperTeam() { }
        public DeveloperTeam(List<Developer> developer, string teamName, int teamIdentifier)
        {
        Developer = developer;
        TeamName = teamName;
        TeamIdentifier = teamIdentifier;
        }
    }
}
