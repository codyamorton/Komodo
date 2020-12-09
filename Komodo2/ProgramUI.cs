using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo2
{
    public class ProgramUI
    {
        private Developer _developerList = new Developer();

        // Method that runs/starts the app
        public void Run()
        {
            
            Menu();
        }

        //Menu 
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                // Display options to user 
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create a New Developer:\n" +
                    "2. View all Developers:\n" +
                    "3. View Teams:\n" +
                    "4. Edit Developers:\n" +
                    "5. Edit Teams:\n" +
                    "6. Exit");

                // Get the users input
                string input = Console.ReadLine();
                // Evaluate the users input and act accordingly
                switch (input)
                {
                    case "1":
                        //creae new dev
                        break;
                    case "2":
                        // view devs
                        break;
                    case "3.":
                        // view teams
                        break;
                    case "4.":
                        // delete devs
                        break;
                    case "5.":
                        //delete teams

                        break;
                    case "6.":
                        //exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }   
        // create new dev
        private void CreateNewDeveloper()
        {
            CreateNewDeveloper newDeveloper = new CreateNewDeveloper();

            // DeveloperName
            Console.WriteLine("Enter the Name for the New Developer");
            newDeveloper.DevName = Console.ReadLine();

            // PluralSight Access Y/N
            Console.WriteLine("Does the Developer Have Pluralsight Access?");
            string PluralSightString = Console.ReadLine().ToLower();
            if (PluralSightString == "y")
            {
                newDeveloper.TheyHavePluralSight = true;
            }
            else
            {
                newDeveloper.TheyHavePluralSight = false;
            }

            // DeveloperIdentifier
            Console.WriteLine("Enter the Id Number for new Developer..");
            string idAsString = Console.ReadLine();
            int IdNumberAsInt = int.Parse(idAsString);

            _developerList.CreateNewDeveloper(newDeveloper);


            // view existing devs
       
            private void SeedDeveloperList()
            {
                Developer codyMorton = new Developer("Cody Morton", true, 3);
                Developer jesseJames = new Developer("Jesse James", false, 2);
                Developer laurenAshleigh = new Developer("Lauren Ashleigh", true, 1);

                _developerList.CreateNewDeveloper(codyMorton);
                _developerList.CreateNewDeveloper(jesseJames);
                _developerList.CreateNewDeveloper(laurenAshleigh);
            }
            // Update existing devs
            private void ViewOrEditTeams()
            {

            }
            // Update existing teams 
            private void DeleteDevelopers()
            {

            }
            private void DeleteTeams()
            {


            }
        }
    }
}


