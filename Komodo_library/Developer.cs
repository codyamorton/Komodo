using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_library
{
    public class Developer
    {
        public string DeveloperName { get; set; }
        public bool PluralSightAccess { get; set; }
        public int DeveloperIdentifier { get; set; }

        public Developer() { }
        public Developer(string developerName, bool pluralSightAccess, int developerIdentifier)
        {
            DeveloperName = developerName;
            PluralSightAccess = pluralSightAccess;
            DeveloperIdentifier = developerIdentifier;
        }
    }
}
