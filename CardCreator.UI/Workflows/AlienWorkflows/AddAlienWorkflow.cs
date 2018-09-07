using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 


namespace CardCreator.UI.Workflows.AlienWorkflows
{
    public class AddAlienWorkflow
    {
        public void Execute() { 
            AlienManager manager = new AlienManager();

            Console.Clear();
            Console.WriteLine("Create New Alien");
            Console.WriteLine("--------------------------");

            Alien alien = new Alien();

            alien.Species = ConsoleIO.GetRequiredStringFromUser("Enter a name for the Species:");
       
        }


    }
}
