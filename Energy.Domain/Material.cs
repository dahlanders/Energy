using System;

namespace Energy.Domain
{
    public class Material
    {
        public int Id { get; set; }
        public string NameofTheMaterial { get; set; }
        public decimal LamdaValue { get; set; }
        public EnumForMaterial EnumForMaterial { get; set; }
             


    }
}
