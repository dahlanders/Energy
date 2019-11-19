using System;
using System.Collections.Generic;
using System.Text;

namespace Energy.Domain
{
    class House
    {
        public Roof Roof { get; set; }
        public Wall Wall { get; set; }
        public Window Windows { get; set; }
        public Window WindowNorth { get; set; }
        public Window WindowSouth { get; set; }
        public Window WindowEast { get; set; }
        public Window WindowWest { get; set; }
        public Door Door { get; set; }
        public Ground Ground { get; set; }
    }
}
