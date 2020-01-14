using Microsoft.AspNetCore.Mvc;
using Sol_CoreMovieInfo_ViewComponent.Core.Context;
using Sol_CoreMovieInfo_ViewComponent.Models;
using Sol_CoreMovieInfo_ViewComponent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_CoreMovieInfo_ViewComponent.Components
{
    public class MovieComponents:ViewComponent
    {
        #region Declaration
        private readonly IMovieContext movieContext = null;
        #endregion

        #region Constructor
        public MovieComponents(IMovieContext movieContext)
        {
            this.movieContext = movieContext;
        }
        #endregion

        private MovieViewModel Tasks { get; set; }

        public async Task<IViewComponentResult> InvokeAsync(string controllerName, string actionName)
        {
            Tasks = new MovieViewModel();
            Tasks.MovieList = (await movieContext?.GetMovieDataAsync()).ToList();
            Tasks.ActionTuple = Tuple.Create(controllerName, actionName);
            return View<MovieViewModel>(Tasks);
        }
    }
}
