using System.Collections.Generic;
using System.Threading.Tasks;
using CountdownService.Models;

namespace CountdownService.MovieService.Services
{
	// API_KEY = 156da5185fdda233f68df042a098148c
	internal class MovieDBProvider : IMovieProvider
	{
		#region Public Methods
		
		public List<MovieInfo> GetMovies(string searchQuery)
		{
			throw new System.NotImplementedException();
		}

		public Task<List<MovieInfo>> GetMoviesAsync(string searchQuery)
		{
			throw new System.NotImplementedException();
		}

		public bool AddMovie(MovieInfo movie)
		{
			throw new System.NotImplementedException();
		}

		public Task<bool> AddMovieAsync(MovieInfo movie)
		{
			throw new System.NotImplementedException();
		}

		public MovieInfo GetMovieById(int movieId)
		{
			throw new System.NotImplementedException();
		}

		public Task<MovieInfo> GetMovieByIdAsync(int movieId)
		{
			throw new System.NotImplementedException();
		}

		#endregion Public Methods
	}
}