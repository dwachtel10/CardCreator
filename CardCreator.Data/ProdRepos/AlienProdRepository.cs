using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardCreator.Interfaces;

namespace CardCreator.Data.ProdRepos
{
    public class AlienProdRepository : IAlienRepository
    {
        private const string FILENAME = @"C:\Documents\Aliens";
        private const string FILEEXT = ".txt";
        
        public Alien ViewAlien(string species)
        {
            var aliens = ReadFromFile();
            return aliens[species];
        }

        public void AddAlien(Alien alien)
        {
            var aliens = ReadFromFile().Values.ToList();
            aliens.Add(alien);

            var fileName = FILENAME + FILEEXT;

            WriteToFile(aliens, fileName);
        }

        public void EditAlien(Alien alien, Alien editedAlien)
        {
            var aliens = ReadFromFile().Values.ToList();
            var alienToRemove = aliens.FirstOrDefault(a => a.Species == alien.Species);
            aliens.Remove(alienToRemove);
            aliens.Add(editedAlien);
            aliens = aliens.OrderBy(a => a.Species).ToList();

            var fileName = FILENAME + FILEEXT;

            WriteToFile(aliens, fileName);
        }

        public void DeleteAlien(Alien alien)
        {
            var aliens = ReadFromFile().Values.ToList();
            var alienToDelete = aliens.Where(a => a.Species == alien.Species).FirstOrDefault();
            aliens.Remove(alienToDelete);
            var fileName = FILENAME + FILEEXT;

            WriteToFile(aliens, fileName);
        }
        private Dictionary<string, Alien> ReadFromFile()
        {
            var fileName = FILENAME + FILEEXT;
            Dictionary<string, Alien> aliens = new Dictionary<string, Alien>();

            if (File.Exists(fileName))
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    sr.ReadLine();

                    string inputLine = "";
                    while ((inputLine = sr.ReadLine()) != null)
                    {
                        string[] inputParts = inputLine.Split(',');
                        Alien newAlien = new Alien()
                        {
                            Species = inputParts[0],
                            PointValue = int.Parse(inputParts[1]),
                            Muscle = int.Parse(inputParts[2]),
                            Skill = int.Parse(inputParts[3]),
                            Brains = int.Parse(inputParts[4]),
                            Charm = int.Parse(inputParts[5]),
                            isPassForHuman = inputParts[6],
                            isAggressive = inputParts[7],
                            isMultiLimbed = inputParts[8],
                            isRavenous = inputParts[9],
                            isGross = inputParts[10],
                            extraText = inputParts[11]
                        };

                        aliens.Add(newAlien.Species, newAlien);
                    }
                }
            }
            return aliens;
        }
        
        public List<Alien> ListAliens()
        {
            var aliens = ReadFromFile().Values.ToList();
            return aliens;
        }
        private void WriteToFile(List<Alien> aliens, string FileName)
        {
            using (StreamWriter sw = new StreamWriter(FileName, false))
            {
                sw.WriteLine("SPECIES,POINT VALUE,MUSCLE,SKILL,BRAINS,CHARM,PASS FOR HUMAN,AGGRESSIVE,MULTILIMBED,RAVENOUS,GROSS,EXTRA TEXT");

                foreach(var alien in aliens)
                {
                    sw.WriteLine($"{alien.Species},{alien.PointValue},{alien.Muscle},{alien.Skill},{alien.Brains},{alien.Charm},{alien.isPassForHuman},{alien.isAggressive},{alien.isMultiLimbed},{alien.isMultiLimbed},{alien.isRavenous},{alien.isGross},{alien.extraText}");
                }
            }
        }
    }
}
