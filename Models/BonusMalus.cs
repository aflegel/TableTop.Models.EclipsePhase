using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
	/// <summary>
	/// Bonus/Malus defines the plus or minus
	/// </summary>
    public partial class BonusMalus
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Type { get; set; }
        public string Target { get; set; }
        public float Value { get; set; }
        public string TragetForCh { get; set; }
        public string TypeTarget { get; set; }
        public string OnCost { get; set; }
        public string MultiOccur { get; set; }
        public int BonusMalusId { get; set; }
    }
}
