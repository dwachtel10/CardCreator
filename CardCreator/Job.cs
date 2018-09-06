using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator
{
    public class Job
    {
        public string JobName { get; set; }
        public int PointValue { get; set; }
        public int MuscleReq { get; set; }
        public bool MuscleTarget { get; set; }
        public int SkillReq { get; set; }
        public bool SkillTarget { get; set; }
        public int BrainsReq { get; set; }
        public bool BrainsTarget { get; set; }
        public int CharmReq { get; set; }
        public bool CharmTarget { get; set; }
        public string RequiredTrait { get; set; }
        public string BannedTrait { get; set; }
        public string BonusTrait { get; set; }
        public string ExtraText { get; set; }
    }
}
