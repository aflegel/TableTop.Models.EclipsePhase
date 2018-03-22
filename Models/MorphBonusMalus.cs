using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class MorphBonusMalus
    {
        public string Morph { get; set; }
        public string BonusMalus { get; set; }
        public short Occur { get; set; }
        public int MorphId { get; set; }
        public int BonusMalusId { get; set; }
    }
}
