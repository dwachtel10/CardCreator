using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardCreator.Interfaces
{
    public interface IAlienRepository
    {
        void AddAlien(Alien alien);
        void EditAlien(Alien alien, Alien editedAlien);
        void DeleteAlien(Alien alien);
        Alien ViewAlien(string name);
        List<Alien> ListAliens();
    }
}
