using Sol_CoreMovieInfo_ViewComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_CoreMovieInfo_ViewComponent.ViewModel
{
    public class MovieViewModel
    {
        public List<MovieModel> MovieList { get; set; }

        public MovieModel Movie { get; set; }

        public Tuple<string,string> ActionTuple { get; set; }
    }
}
