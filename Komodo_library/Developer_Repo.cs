using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_library
{
    public class Developer_Repo
    {
        private List<Developer> _developerList = new List<Developer>();

        //Create
        public bool CreateDeveloper(string developerName, bool pluralSightAccess, int developerIdentifier)
        {

            var newDeveloper = new Developer
            {
                DeveloperName = developerName,
                PluralSightAccess = pluralSightAccess,
                DeveloperIdentifier = developerIdentifier,
            };
            _developerList.Add(newDeveloper);

            return true;

        }

        // Read
        public List<Developer> ViewDeveloper()
        {
            return _developerList;
        }

        // Update
        public bool UpdateDeveloper(Developer newDeveloper)
        {
            var developer = FindDeveloperByID(newDeveloper.DeveloperIdentifier);
            if (developer != null)
            {
                developer.DeveloperName = newDeveloper.DeveloperName;
                developer.PluralSightAccess = newDeveloper.PluralSightAccess;
                developer.DeveloperIdentifier = newDeveloper.DeveloperIdentifier;

                return true;
            }
            else
            {
                return false;
            }
        }


        // Helper Method 
        public Developer FindDeveloperByID(int developerIdentifier)
        {
            foreach (var developer in _developerList)
                if (developer.DeveloperIdentifier == developer.DeveloperIdentifier)
                    return developer;

            return null;
        }


        // Delete
        public bool DeleteDeveloper(int developerIdentifier)
        {
            var developer = FindDeveloperByID(developerIdentifier);
            return developer != null && DeleteDeveloper(developerIdentifier);
        }


        public bool HasAccessToPluralSight(int developerIdentifier)
        {
            var developer = FindDeveloperByID(developerIdentifier);
            if (developer.PluralSightAccess = developer.PluralSightAccess)
                return true;
            else
                return false;

        }
    }

}
