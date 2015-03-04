using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.WebPages.Scope;
using CountdownService.Models;

namespace CountdownService.MovieService
{
	internal interface IMovieProvider
	{
		#region Public Methods

		List<MovieInfo> GetMovies(string searchQuery);
		Task<List<MovieInfo>> GetMoviesAsync(string searchQuery);
		bool AddMovie(MovieInfo movie);
		Task<bool> AddMovieAsync(MovieInfo movie);

		#endregion Public Methods
	}
}
