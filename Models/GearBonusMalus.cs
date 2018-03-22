using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class GearBonusMalus
    {
        public string Gear { get; set; }
        public string BonusMalus { get; set; }
        public short Occur { get; set; }
        public int GearId { get; set; }
        public int BonusMalusId { get; set; }
    }
}
