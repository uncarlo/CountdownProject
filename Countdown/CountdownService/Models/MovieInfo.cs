using System;
using CountdownService.Models.Enums;

namespace CountdownService.Models
{
	public class MovieInfo
	{
		public string Name { get; internal set; }
		public DateTime ReleaseDate { get; internal set; }
		public int Phase { get; internal set; }

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
	}
}