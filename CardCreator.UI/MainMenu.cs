using System;
using System.Collections.Generic;
using System.IO;
using System.Net; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardCreator.UI.Workflows;

namespace CardCreator.UI
{
    public class MainMenu
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Alien Game Card Management System");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Aliens");
                Console.WriteLine("2. Jobs");
                Console.WriteLine("3. Boosts");
                Console.WriteLine("4. Events");
                Console.WriteLine("Q. Quit");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Please enter a selection");

                bool validInput = false;
                while (validInput == false)
                {
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            AlienWorkflow alien = new AlienWorkflow();
                            validInput = true;
                            alien.Execute();
                            break;

                        case "2":
                            JobWorkflow job = new JobWorkflow();
                            validInput = true;
                            job.Execute();
                            break;

                        case "3":
                            BoostWorkflow boost = new BoostWorkflow();
                            validInput = true;
                            boost.Execute();
                            break;

                        case "4":
                            EventWorkflow events = new EventWorkFlow();
                            validInput = true;
                            events.Execute();
                            break;

                        case "Q":
                            return;
                        default:
                            Console.WriteLine("Invalid selection.  Please enter one of the above options.");
                            break;
        }

    }



            }
            catch
            {
                using (
                    StreamWriter sw =
                    File.AppendText(//file name
                        )
                    )
                {
                    Console.WriteLine("An unhandled exception has occurred.  Shutting down.");
                    sw.WriteLine($"{DateTime.Now}: An unhandled exception occurred.");
                }
            }
    }
  
