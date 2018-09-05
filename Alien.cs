using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator
{
    public class Alien
    {
        public string Species { get; set; }
        public int PointValue { get; set; }
        public int Muscle { get; set; }
        public int Skill { get; set; }
        public int Brains { get; set; }
        public int Charm { get; set; }
        public bool isPassForHuman { get; set; }
        public bool isAggressive { get; set; }
        public bool isMultiLimbed { get; set; }
        public bool isRavenous { get; set; }
        public bool isGross { get; set; }
        public string extraText { get; set; }

    }
}
