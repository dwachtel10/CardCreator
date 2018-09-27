using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardCreator.Interfaces;
using CardCreator.BLL;
using CardCreator.Data;

namespace CardCreator.BLL
{
    class AlienManager
    {
        public ViewAlienResponses ViewAlien(string name)
        {
            IAlienRepository repo = RepositoryFactory.CreateAlienRepo();
            

        }
    }
}
