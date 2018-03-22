using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class BackgroundBonusMalus
    {
        public string Background { get; set; }
        public string BonusMalus { get; set; }
        public short Occurrence { get; set; }
        public int BackgroundId { get; set; }
        public int BonusMalusId { get; set; }
    }
}
