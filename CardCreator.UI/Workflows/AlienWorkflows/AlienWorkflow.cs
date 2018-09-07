using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator.UI.Workflows
{
    public class AlienWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Alien Menu");
            Console.WriteLine("1. View All Aliens");
            Console.WriteLine("2. View Alien Details");
            Console.WriteLine("3. Add Alien");
            Console.WriteLine("4. Edit Alien");
            Console.WriteLine("5. Delete Alien");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Please enter your selection: ");

            bool validInput = false;
            while (validInput == false)
            {
                string input = Console.ReadLine();
                switch(input)
                { 
                    case "1":
                        ViewAllAliensWorkflow viewAll = new ViewAllAliensWorkflow();
                        validInput = true;
                        viewAll.Execute();
                        break;

                    case "2":
                        ViewAlienWorkflow view = new ViewAlienWorkflow();
                        validInput = true;
                        view.Execute();
                        break;

                    case "3":
                        AddAlienWorkflow add = new AddAlienWorkflow();
                        validInput = true;
                        add.Execute();
                        break;

                    case "4":
                        EditAlienWorkflow edit = new EditAlienWorkflow();
                        validInput = true;
                        edit.Execute();
                        break;
                    case "5":
                        DeleteAlienWorkflow delete = new DeleteAlienWorkflow();
                        validInput = true;
                        delete.Execute();
                        break;
                    case "Q":
                        Console.Clear();
                        MainMenu.Main();
                        break;
                    default:
                        Console.WriteLine("Invalid selection.  Please enter one of the above options.");
                        break;

                }
            }

        }
    }
}
