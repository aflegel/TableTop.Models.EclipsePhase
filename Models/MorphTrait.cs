using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class MorphTrait
    {
        public string Morph { get; set; }
        public string Trait { get; set; }
        public int MorphId { get; set; }
        public int TraitId { get; set; }
    }
}
