using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator.Responses
{
    public class AddAlienResponses : Responses
    {
        public List<Alien> aliens { get; set; }
    }

    public class AddJobResponses : Responses
    {
        public List<Job> jobs { get; set; }
    }

    public class AddBoostResponses: Responses
    {
        public List<Boost> boosts { get; set; }
    }

    public class AddEventResponses: Responses
    {
        public List<Event> events { get; set; }
    }
}
