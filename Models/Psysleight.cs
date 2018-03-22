using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class Psysleight
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Type { get; set; }
        public string Range { get; set; }
        public string Duration { get; set; }
        public string Action { get; set; }
        public string Level { get; set; }
        public string StrainMod { get; set; }
        public string SkillNeeded { get; set; }
        public int PsysleightId { get; set; }
    }
}
