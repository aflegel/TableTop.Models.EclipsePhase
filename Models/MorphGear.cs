using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class MorphGear
    {
        public string Morph { get; set; }
        public string Gear { get; set; }
        public short Occur { get; set; }
        public int MorphId { get; set; }
        public int GearId { get; set; }
    }
}
