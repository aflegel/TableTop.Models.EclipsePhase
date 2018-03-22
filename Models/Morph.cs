using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class Morph
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public short Age { get; set; }
        public short MaxApptitude { get; set; }
        public short Durablility { get; set; }
        public short CpCost { get; set; }
        public string CreditCost { get; set; }
        public int MorphId { get; set; }
    }
}
