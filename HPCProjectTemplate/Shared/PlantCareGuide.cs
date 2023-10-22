using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCProjectTemplate.Shared
{
    public class PlantCareGuide
    {

        
        public Datum[] data { get; set; }
        public int to { get; set; }
        public int per_page { get; set; }
        public int current_page { get; set; }
        public int from { get; set; }
        public int last_page { get; set; }
        public int total { get; set; }
        

        public class Datum
        {
            public int id { get; set; }
            public int species_id { get; set; }
            public string common_name { get; set; }
            public string[] scientific_name { get; set; }
            public Section[] section { get; set; }
        }

        public class Section
        {
            public int id { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }




    }
}
