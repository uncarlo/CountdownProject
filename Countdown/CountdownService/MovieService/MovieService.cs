using System;
using System.Collections.Generic;
using System.Data;
using CountdownService.MovieService.Services;

namespace CountdownService.MovieService
{
	internal class MovieService
	{
		#region Singleton

		internal static MovieService Instance = new MovieService();

		private MovieService()
		{
#if TestMode
			MovieProvider = new MockMovieProvider();
#else
			MovieProvider = new MovieDBProvider();
#endif
		}

		#endregion Singleton

		#region Properties

		internal IMovieProvider MovieProvider { get; private set; }

		#endregion Properties
	}
}