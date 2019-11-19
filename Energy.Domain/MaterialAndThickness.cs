using System;
using System.Collections.Generic;
using System.Text;

namespace Energy.Domain
{
    public class MaterialAndThickness
    {
        public string Name { get; set; }
        public decimal UValue { get; set; }
        public decimal Thickness { get; set; }

        public EnumForMaterial EnumForMaterial { get; set; }
    }
}
