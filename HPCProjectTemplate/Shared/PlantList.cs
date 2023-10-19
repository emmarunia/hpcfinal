using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCProjectTemplate.Shared
{
    public class PlantList
    {   
        
        public int id { get; set; }
        
        public string common_name { get; set; }
        //public string scientific_name { get; set; }
        //public string other_name { get; set; }
        public string cycle { get; set; }
        public string watering { get; set; }
        //public string sunlight { get; set; }
        public int image_id { get; set; }
        public int license { get; set; }
        public string license_name { get; set; }
        public string license_url { get; set; }

        public string original_url { get; set; }
        public string regular_url { get; set; }
        public string medium_url { get; set; }
        public string small_url { get; set; }
        public string thumbnail { get; set; }

        [NotMapped]
        public Boolean isFavorite { get; set; } = false;

    }
}
