using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountdownService.Models;

namespace CountdownService.MovieService.Services
{
	internal class MockMovieProvider : IMovieProvider
	{
		#region Private Members

		private List<MovieInfo> _movieInfoList = new List<MovieInfo>
		{
			// Phase 1
			new MovieInfo
			{
				Name = "Iron Man",
				ReleaseDate = new DateTime(2008, 5, 2),
				Phase = 1
			},
			new MovieInfo
			{
				Name = "The Incredible Hulk",
				ReleaseDate = new DateTime(2008, 6, 13),
				Phase = 1
			},
			new MovieInfo 
			{
				Name = "Iron Man 2",
				ReleaseDate = new DateTime(2010, 5, 7),
				Phase = 1
			},
			new MovieInfo 
			{
				Name = "Thor",
				ReleaseDate = new DateTime(2011, 5, 6),
				Phase = 1
			},
			new MovieInfo 
			{
				Name = "Captain America: The First",
				ReleaseDate = new DateTime(2011, 7, 22),
				Phase = 1
			},
			new MovieInfo 
			{
				Name = "Marvel's The Avengers",
				ReleaseDate = new DateTime(2012, 5, 4),
				Phase = 1
			},
			// Phase 2
			new MovieInfo 
			{
				Name = "Iron Man 3",
				ReleaseDate = new DateTime(2013, 5, 3),
				Phase = 2
			},
			new MovieInfo 
			{
				Name = "Thor: The Dark World",
				ReleaseDate = new DateTime(2013, 11, 8),
				Phase = 2
			},
			new MovieInfo 
			{
				Name = "Captain America: The Winter Soldier",
				ReleaseDate = new DateTime(2014, 4, 4),
				Phase = 2
			},
			new MovieInfo 
			{
				Name = "Guardians of the Galaxy",
				ReleaseDate = new DateTime(2014, 8, 1),
				Phase = 2
			},
			new MovieInfo 
			{
				Name = "Avengers: Age of Ultron",
				ReleaseDate = new DateTime(2015, 5, 1),
				Phase = 2
			},
			new MovieInfo 
			{
				Name = "Ant-Man",
				ReleaseDate = new DateTime(2015, 7, 17),
				Phase = 2
			},
			// Phase 3
			new MovieInfo 
			{
				Name = "Captain America: Civil War",
				ReleaseDate = new DateTime(2016, 5, 6),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Doctor Strange",
				ReleaseDate = new DateTime(2016, 11, 4),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Guardians of the Galaxy 2",
				ReleaseDate = new DateTime(2017, 5, 5),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Spider-Man",
				ReleaseDate = new DateTime(2017, 7, 28),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Thor: Ragnarok",
				ReleaseDate = new DateTime(2017, 11, 3),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Avengers: Infinity War Part 1",
				ReleaseDate = new DateTime(2018, 5, 4),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Black Panther",
				ReleaseDate = new DateTime(2018, 7, 6),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Captain Marvel",
				ReleaseDate = new DateTime(2018, 11, 2),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Avenger: Infinity War Part 2",
				ReleaseDate = new DateTime(2019, 5, 3),
				Phase = 3
			},
			new MovieInfo 
			{
				Name = "Inhumans",
				ReleaseDate = new DateTime(2019, 7, 12),
				Phase = 3
			}
		};


		#endregion Private Members

		#region Public Methods

		public List<MovieInfo> GetMovies(string searchQuery)
		{
			return _movieInfoList;
		}

		public async Task<List<MovieInfo>> GetMoviesAsync(string searchQuery)
		{
			return await new Task<List<MovieInfo>>(x => _movieInfoList, null);
		}

		public bool AddMovie(MovieInfo movie)
		{
			_movieInfoList.Add(movie);

			return true;
		}

		public async Task<bool> AddMovieAsync(MovieInfo movie)
		{
			_movieInfoList.Add(movie);

			return await new Task<bool>(x => true, null);
		}

		#endregion Public Methods
	}
}