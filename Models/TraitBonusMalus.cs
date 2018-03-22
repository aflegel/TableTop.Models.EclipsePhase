using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class TraitBonusMalus
    {
        public string TraitName { get; set; }
        public string BonusMalusName { get; set; }
        public short Occur { get; set; }
        public int TraitId { get; set; }
        public int BonusMalusId { get; set; }
    }
}
