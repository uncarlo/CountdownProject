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
				ID = 1,
				Name = "Iron Man",
				ReleaseDate = new DateTime(2008, 5, 2),
				Phase = 1
			},
			new MovieInfo
			{
				ID = 2,
				Name = "The Incredible Hulk",
				ReleaseDate = new DateTime(2008, 6, 13),
				Phase = 1
			},
			new MovieInfo 
			{
				ID = 3,
				Name = "Iron Man 2",
				ReleaseDate = new DateTime(2010, 5, 7),
				Phase = 1
			},
			new MovieInfo 
			{
				ID = 4,
				Name = "Thor",
				ReleaseDate = new DateTime(2011, 5, 6),
				Phase = 1
			},
			new MovieInfo 
			{
				ID = 5,
				Name = "Captain America: The First",
				ReleaseDate = new DateTime(2011, 7, 22),
				Phase = 1
			},
			new MovieInfo 
			{
				ID = 6,
				Name = "Marvel's The Avengers",
				ReleaseDate = new DateTime(2012, 5, 4),
				Phase = 1
			},
			// Phase 2
			new MovieInfo 
			{
				ID = 7,
				Name = "Iron Man 3",
				ReleaseDate = new DateTime(2013, 5, 3),
				Phase = 2
			},
			new MovieInfo 
			{
				ID = 8,
				Name = "Thor: The Dark World",
				ReleaseDate = new DateTime(2013, 11, 8),
				Phase = 2
			},
			new MovieInfo 
			{
				ID = 9,
				Name = "Captain America: The Winter Soldier",
				ReleaseDate = new DateTime(2014, 4, 4),
				Phase = 2
			},
			new MovieInfo 
			{
				ID = 10,
				Name = "Guardians of the Galaxy",
				ReleaseDate = new DateTime(2014, 8, 1),
				Phase = 2
			},
			new MovieInfo 
			{
				ID = 11,
				Name = "Avengers: Age of Ultron",
				ReleaseDate = new DateTime(2015, 5, 1),
				Phase = 2
			},
			new MovieInfo 
			{
				ID = 12,
				Name = "Ant-Man",
				ReleaseDate = new DateTime(2015, 7, 17),
				Phase = 2
			},
			// Phase 3
			new MovieInfo 
			{
				ID = 13,
				Name = "Captain America: Civil War",
				ReleaseDate = new DateTime(2016, 5, 6),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 14,
				Name = "Doctor Strange",
				ReleaseDate = new DateTime(2016, 11, 4),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 15,
				Name = "Guardians of the Galaxy 2",
				ReleaseDate = new DateTime(2017, 5, 5),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 16,
				Name = "Spider-Man",
				ReleaseDate = new DateTime(2017, 7, 28),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 17,
				Name = "Thor: Ragnarok",
				ReleaseDate = new DateTime(2017, 11, 3),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 18,
				Name = "Avengers: Infinity War Part 1",
				ReleaseDate = new DateTime(2018, 5, 4),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 19,
				Name = "Black Panther",
				ReleaseDate = new DateTime(2018, 7, 6),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 20,
				Name = "Captain Marvel",
				ReleaseDate = new DateTime(2018, 11, 2),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 21,
				Name = "Avenger: Infinity War Part 2",
				ReleaseDate = new DateTime(2019, 5, 3),
				Phase = 3
			},
			new MovieInfo 
			{
				ID = 22,
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
			movie.ID = _movieInfoList.Count;

			_movieInfoList.Add(movie);

			return true;
		}

		public async Task<bool> AddMovieAsync(MovieInfo movie)
		{
			movie.ID = _movieInfoList.Count + 1;

			_movieInfoList.Add(movie);

			return await new Task<bool>(x => true, null);
		}

		#endregion Public Methods
	}
}