using Sol_CoreMovieInfo_ViewComponent.Core.Abstract;
using Sol_CoreMovieInfo_ViewComponent.Core.Context;
using Sol_CoreMovieInfo_ViewComponent.Core.Repository;
using Sol_CoreMovieInfo_ViewComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_CoreMovieInfo_ViewComponent.Context
{
    public class MovieContext : IMovieContext
    {
        #region Declaration
        private readonly IMovieRepository movieRepository = null;
        #endregion

        #region Constructor
        public MovieContext(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        #endregion


        async Task<IEnumerable<MovieModel>> IMovieAbstract.GetMovieDataAsync()
        {
            return await movieRepository.GetMovieDataAsync();
        }

        async Task<MovieModel> IMovieAbstract.GetSingleMovieData(int id)
        {
            return await movieRepository.GetSingleMovieData(id);
        }
    }
}
