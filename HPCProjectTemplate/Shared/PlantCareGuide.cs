using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCProjectTemplate.Shared
{
    public class PlantCareGuide
    {
        public Data data { get; set; }

        public class Data
        {
            public int id { get; set; }
            public int species_id { get; set; }
            public string common_name { get; set; }
            public Section[] section { get; set; }
            public class Section
            {
                public int id { get; set; }
                public string type { get; set; }
                public string description { get; set; }
            }
        }
        

       
    }
}
