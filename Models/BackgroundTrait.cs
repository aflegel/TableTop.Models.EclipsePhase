using System;
using System.Collections.Generic;

namespace EclipsePhase.Models
{
    public partial class BackgroundTrait
    {
        public string Background { get; set; }
        public string Trait { get; set; }
        public int BackgroundId { get; set; }
        public int TraitId { get; set; }
    }
}
