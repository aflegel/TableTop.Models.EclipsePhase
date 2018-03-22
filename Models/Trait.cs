using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class Trait
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Side { get; set; }
        public string Onwhat { get; set; }
        public short? CpCost { get; set; }
        public short Level { get; set; }
        public string JustFor { get; set; }
        public int TraitId { get; set; }
    }
}
