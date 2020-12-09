using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_library
{
    public class DeveloperTeam_Repo
    {
        private List<DeveloperTeam> _developerTeam = new List<DeveloperTeam>();

        private Developer_Repo _developerList = new Developer_Repo();
        // Create 
        public bool CreateDeveloperTeam(List<Developer> developer, string teamName, int teamIdentifier)
        {
            var newDeveloperTeam = new DeveloperTeam
            {
                Developer = developer,
                TeamName = teamName,
                TeamIdentifier = teamIdentifier,
            };
            _developerTeam.Add(newDeveloperTeam);
            return true;
        }
        public bool AddTeamMember(int teamIndentifier, int developerIdentifier)
        {
            var team = FindDeveloperByTeamID(teamIndentifier);
            var developer = _developerList.FindDeveloperByID(developerIdentifier);
            if (developer is null || team is null)
                return false;
            else
            {
                team.Developer.Add(developer);
                return true;
            }
        }
        public bool RemoveTeamMember(int teamIdentifier, int developerIdentifier)
        {
             var team = FindDeveloperByTeamID(teamIdentifier);
            var developer = _developerList.FindDeveloperByID(developerIdentifier);
            if (developer is null || team is null)
                return false; 
            else
            {
                team.Developer.Remove(developer);
                return true;
            }
        }
     



    // Read
    public List<DeveloperTeam> ViewDeveloperTeam()
    {
        return _developerTeam;
    }
    // Update
    public bool UpdateDeveloperTeam(DeveloperTeam newDeveloperTeam)
    {
        var developerTeam = (newDeveloperTeam.TeamIdentifier);
        if (developerTeam != null)
        {
            newDeveloperTeam.TeamName = newDeveloperTeam.TeamName;

            return true;
        }
        else
        {
            return false;
        }
    }
    public DeveloperTeam FindDeveloperByTeamID(int developerTeamIdentifier)
    {
        foreach (var developerTeam in _developerTeam)
            if (developerTeam.TeamIdentifier == developerTeam.TeamIdentifier)
                return developerTeam;

        return null;
    }

    // Delete

    public bool DeleteDeveloperTeam(int developerTeamIdentifier)
    {
        var developerTeam = FindDeveloperByTeamID(developerTeamIdentifier);
        return developerTeam != null && DeleteDeveloperTeam(developerTeamIdentifier);
    }
}
}
