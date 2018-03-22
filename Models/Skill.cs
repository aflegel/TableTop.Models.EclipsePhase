using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class Skill
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string LinkedApt { get; set; }
        public string Prefix { get; set; }
        public string SkillType { get; set; }
        public string Defaultable { get; set; }
    }
}
