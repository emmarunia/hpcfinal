using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCProjectTemplate.Shared
{
    public class Replies
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime Created { get; set; }
        public int TopicId { get; set; }
        public int PostId { get; set; }
        public string? UserName { get; set; }
    }
}
