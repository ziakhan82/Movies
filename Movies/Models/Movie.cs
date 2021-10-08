using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int Year {get; set; }
        public int RunningTimeInMin { get; set; }
        public int StudioId { get; set; }
    }
}
