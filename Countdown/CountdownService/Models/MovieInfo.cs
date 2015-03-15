using System;
using CountdownService.Models.Enums;

namespace CountdownService.Models
{
	public class MovieInfo
	{
		public int ID { get; internal set; }
		public string Name { get; set; }
		public DateTime ReleaseDate { get; set; }
		public int Phase { get; set; }

		public MovieStatus Status
		{
			get
			{
				DateTime now = DateTime.Now;

				MovieStatus movieStatus;

				if (ReleaseDate <= now)
				{
					movieStatus = MovieStatus.Released;
				}
				else if (ReleaseDate <= now.AddDays(5))
				{
					movieStatus = MovieStatus.OpenningSoon;
				}
				else if (ReleaseDate <= now.AddDays(366))
				{
					movieStatus = MovieStatus.PostProduction;
				}
				else if (ReleaseDate <= now.AddDays(732))
				{
					movieStatus = MovieStatus.PreProduction;
				}
				else
				{
					movieStatus = MovieStatus.InDevelopment;
				}

				return movieStatus;
			}
		}

		internal static MovieInfo GetMovieFromJson(dynamic movieData)
		{
			DateTime releaseDate = DateTime.Parse(movieData.release_date);
			return new MovieInfo
			{
				ID = movieData.id,
				Name = movieData.title,
				Phase = GetMoviePhaseFromReleaseDate(releaseDate),
				ReleaseDate = releaseDate
			};
		}

		private static int GetMoviePhaseFromReleaseDate(DateTime movieDate)
		{
			int year = movieDate.Year;
			if (year <= 2012)
			{
				return 1;
			}
			else if (year >= 2013 && year <= 2015)
			{
				return 2;
			}

			return 3;
		}
	}
}