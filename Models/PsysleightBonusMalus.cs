using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class PsysleightBonusMalus
    {
        public string Psy { get; set; }
        public string Bonusmalus { get; set; }
        public short Occur { get; set; }
        public int PsysleightId { get; set; }
        public int BonusMalusId { get; set; }
    }
}
