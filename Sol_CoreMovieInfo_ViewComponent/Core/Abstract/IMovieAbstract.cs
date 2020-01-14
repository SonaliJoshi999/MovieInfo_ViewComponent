using Sol_CoreMovieInfo_ViewComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_CoreMovieInfo_ViewComponent.Core.Abstract
{
    public interface IMovieAbstract
    {
        Task<IEnumerable<MovieModel>> GetMovieDataAsync();
        Task<MovieModel> GetSingleMovieData(int id);
    }
}
