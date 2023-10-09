using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCProjectTemplate.Shared
{
    public class PerenualPlantResponse
    {
        public int id { get; set; }
        public string common_name { get; set; }
        public string[] scientific_name { get; set; }
        public string[] other_name { get; set; }
        public object family { get; set; }
        public string[] origin { get; set; }
        public string type { get; set; }
        public string dimension { get; set; }
        public Dimensions dimensions { get; set; }
        public string cycle { get; set; }
        public object[] attracts { get; set; }
        public string[] propagation { get; set; }
        public Hardiness hardiness { get; set; }
        public Hardiness_Location hardiness_location { get; set; }
        public string watering { get; set; }
        [JsonIgnore]
        public object[] depth_water_requirement { get; set; }
        public object[] volume_water_requirement { get; set; }
        public object watering_period { get; set; }
        public Watering_General_Benchmark watering_general_benchmark { get; set; }
        public object[] plant_anatomy { get; set; }
        public string[] sunlight { get; set; }
        public string[] pruning_month { get; set; }
        [JsonIgnore]
        public object[] pruning_count { get; set; }
        public int seeds { get; set; }
        public object maintenance { get; set; }
        public string careguides { get; set; }
        public object[] soil { get; set; }
        public string growth_rate { get; set; }
        public bool drought_tolerant { get; set; }
        public bool salt_tolerant { get; set; }
        public bool thorny { get; set; }
        public bool invasive { get; set; }
        public bool tropical { get; set; }
        public bool indoor { get; set; }
        public string care_level { get; set; }
        public object[] pest_susceptibility { get; set; }
        public string pest_susceptibility_api { get; set; }
        public bool flowers { get; set; }
        public object flowering_season { get; set; }
        public string flower_color { get; set; }
        public bool cones { get; set; }
        public bool fruits { get; set; }
        public bool edible_fruit { get; set; }
        public string edible_fruit_taste_profile { get; set; }
        public string fruit_nutritional_value { get; set; }
        public object[] fruit_color { get; set; }
        public object harvest_season { get; set; }
        public bool leaf { get; set; }
        public string[] leaf_color { get; set; }
        public bool edible_leaf { get; set; }
        public bool cuisine { get; set; }
        public bool medicinal { get; set; }
        public int poisonous_to_humans { get; set; }
        public int poisonous_to_pets { get; set; }
        public string description { get; set; }
        public Default_Image default_image { get; set; }
        public string other_images { get; set; }

        public class Dimensions
        {
            public string type { get; set; }
            public int min_value { get; set; }
            public int max_value { get; set; }
            public string unit { get; set; }
        }

        public class Hardiness
        {
            public string min { get; set; }
            public string max { get; set; }
        }

        public class Hardiness_Location
        {
            public string full_url { get; set; }
            public string full_iframe { get; set; }
        }

        public class Watering_General_Benchmark
        {
            public string value { get; set; }
            public string unit { get; set; }
        }

        public class Default_Image
        {
            public int license { get; set; }
            public string license_name { get; set; }
            public string license_url { get; set; }
            public string original_url { get; set; }
            public string regular_url { get; set; }
            public string medium_url { get; set; }
            public string small_url { get; set; }
            public string thumbnail { get; set; }
        }
    }
}
