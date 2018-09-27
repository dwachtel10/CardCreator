using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CardCreator.UI.Workflows.AlienWorkflows
{
    public class AddAlienWorkflow
    {
        public void Execute() { 
            //AlienManager manager = new AlienManager();

            Console.Clear();
            Console.WriteLine("Create New Alien");
            Console.WriteLine(ConsoleIO.HorizontalLine);

            Alien alien = new Alien();

            alien.Species = ConsoleIO.GetRequiredStringFromUser("Enter a name for the Species:");
            alien.PointValue = ConsoleIO.GetRequiredIntFromUser("How many points is it worth?");
            alien.Muscle = ConsoleIO.GetRequiredIntFromUser("What is its Muscle score?");
            alien.Skill = ConsoleIO.GetRequiredIntFromUser("What is its Skill score?");
            alien.Brains = ConsoleIO.GetRequiredIntFromUser("What is its Brains score?");
            alien.Charm = ConsoleIO.GetRequiredIntFromUser("What is its Charm score?");
            alien.isPassForHuman = ConsoleIO.GetRequiredYesOrNoFromUser("Can it Pass For Human? (Y/N)");
            alien.isAggressive = ConsoleIO.GetRequiredYesOrNoFromUser("Is it Aggressive? (Y/N)");
            alien.isMultiLimbed = ConsoleIO.GetRequiredYesOrNoFromUser("Is it Multi-limbed? (Y/N)");
            alien.isRavenous = ConsoleIO.GetRequiredYesOrNoFromUser("Is it Ravenous? (Y/N)");
            alien.isGross = ConsoleIO.GetRequiredYesOrNoFromUser("Is it Gross? (Y/N)");
            alien.extraText = ConsoleIO.GetOptionalStringFromUser("Add any flavor text or special rules, or press enter to leave this blank.");

        }


    }
}
