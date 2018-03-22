using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class Sapient
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public short Cost { get; set; }
        public string Unique { get; set; }
        public int SapientId { get; set; }
    }
}
