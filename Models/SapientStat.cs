using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class SapientStat
    {
        public string Ai { get; set; }
        public string Stat { get; set; }
        public short Value { get; set; }
        public int SapientId { get; set; }
        public int StatId { get; set; }
    }
}
