using Microsoft.AspNetCore.Mvc;
using Sol_CoreMovieInfo_ViewComponent.Core.Context;
using Sol_CoreMovieInfo_ViewComponent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_CoreMovieInfo_ViewComponent.Components
{
    public class SingleMovieComponents: ViewComponent
    {
        #region Declaration
        private readonly IMovieContext movieContext = null;
        #endregion

        #region Constructor
        public SingleMovieComponents(IMovieContext movieContext)
        {
            this.movieContext = movieContext;
        }
        #endregion

        private MovieViewModel Tasks { get; set; }

        public async Task<IViewComponentResult> InvokeAsync(string controllerName, string actionName, int id)
        {
            Tasks = new MovieViewModel();
            Tasks.Movie = (await movieContext?.GetSingleMovieData(id));
            Tasks.ActionTuple = Tuple.Create(controllerName, actionName);
            return View<MovieViewModel>(Tasks);
        }
    }
}
