using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Helpers;
using CountdownService.Models;
using Newtonsoft.Json;

namespace CountdownService.MovieService.Services
{
	// API_KEY = 156da5185fdda233f68df042a098148c
	// Sample http://api.themoviedb.org/3/company/420/movies?api_key=156da5185fdda233f68df042a098148c
	internal class MovieDBProvider : IMovieProvider
	{
		private readonly string _getMoviesEndpoint =
			"http://api.themoviedb.org/3/company/420/movies?api_key=156da5185fdda233f68df042a098148c";

		#region Public Methods
		
		public List<MovieInfo> GetMovies(string searchQuery)
		{
			using (WebClient webClient = new WebClient())
			{
				string json = webClient.DownloadString(_getMoviesEndpoint);

				dynamic movieData = Json.Decode(json);

				List<MovieInfo> movies = new List<MovieInfo>();

				foreach (dynamic item in movieData.results)
				{
					movies.Add(MovieInfo.GetMovieFromJson(item));
				}

				return movies;
			}
		}

		public async Task<List<MovieInfo>> GetMoviesAsync(string searchQuery)
		{
			// Using HttpClient here because it has "async" get method.
			using (HttpClient httpClient = new HttpClient())
			{
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				string json = string.Empty;
				try
				{
					json = await httpClient.GetStringAsync(_getMoviesEndpoint);
				}
				catch (Exception)
				{
					return null;
				}

				dynamic movieData = Json.Decode(json);

				List<MovieInfo> movies = new List<MovieInfo>();

				foreach (dynamic item in movieData.results)
				{
					movies.Add(MovieInfo.GetMovieFromJson(item));
				}

				return movies;
			}
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