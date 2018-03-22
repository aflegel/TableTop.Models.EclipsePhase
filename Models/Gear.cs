using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class Gear
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public short Cost { get; set; }
        public short ArmorKinetic { get; set; }
        public short ArmorEnergy { get; set; }
        public string Degat { get; set; }
        public short ArmorPene { get; set; }
        public string JustFor { get; set; }
        public string Unique { get; set; }
        public int GearId { get; set; }
    }
}
