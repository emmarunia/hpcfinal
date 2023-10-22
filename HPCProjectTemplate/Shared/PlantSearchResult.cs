using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCProjectTemplate.Shared;

public class PlantSearchResult
{
    public List<PlantList> results{ get; set; }
    public int totalResults { get; set; }
    
}