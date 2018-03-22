using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class SapientAptitude
    {
        public string Ai { get; set; }
        public string Aptitude { get; set; }
        public short Value { get; set; }
        public int SapientId { get; set; }
        public int AptitudeId { get; set; }
    }
}
