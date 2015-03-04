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
	}
}