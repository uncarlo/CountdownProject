using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
using CountdownService.Helpers;
using CountdownService.Models;
using CountdownService.Models.Enums;

namespace CountdownService.Controllers
{
	public class MovieInfoController : ApiController
	{
		// Movie Phases:
		// http://en.wikipedia.org/wiki/Marvel_Cinematic_Universe#Films

		private static string DomainNameUrl = "http://api.rottentomatoes.com";
		private static string GetMethodUrl = "/api/public/v1.0/movies.json?q=Marvel&page_limit=10&page=1&apikey=";
		private static string APIKey = "748u4b2qvrhhwtuh3rrsee4g";

		// GET api/movieinfo
		public async Task<IEnumerable<MovieInfo>> GetAsync()
		{
			var json = new WebClient().DownloadString(DomainNameUrl + GetMethodUrl + APIKey);

			var serializer = new JavaScriptSerializer();
			serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

			dynamic obj = serializer.Deserialize(json, typeof(object));

			List<MovieInfo> movieInfoList = new List<MovieInfo>();

			movieInfoList.Add(new MovieInfo
			{
				Name = "Iron Man",
				ReleaseDate = new DateTime(2008, 5, 2),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "The Incredible Hulk",
				ReleaseDate = new DateTime(2008, 6, 13),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Iron Man 2",
				ReleaseDate = new DateTime(2010, 5, 7),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Thor",
				ReleaseDate = new DateTime(2011, 5, 6),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Captain America: The First",
				ReleaseDate = new DateTime(2011, 7, 22),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Marvel's The Avengers",
				ReleaseDate = new DateTime(2012, 5, 4),
				Phase = 1
			});

			return await new Task<List<MovieInfo>>(x => movieInfoList, null);
		}

		public IEnumerable<MovieInfo> Get()
		{
			List<MovieInfo> movieInfoList = new List<MovieInfo>();

			// Phase 1
			movieInfoList.Add(new MovieInfo
			{
				Name = "Iron Man",
				ReleaseDate = new DateTime(2008, 5, 2),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "The Incredible Hulk",
				ReleaseDate = new DateTime(2008, 6, 13),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Iron Man 2",
				ReleaseDate = new DateTime(2010, 5, 7),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Thor",
				ReleaseDate = new DateTime(2011, 5, 6),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Captain America: The First",
				ReleaseDate = new DateTime(2011, 7, 22),
				Phase = 1
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Marvel's The Avengers",
				ReleaseDate = new DateTime(2012, 5, 4),
				Phase = 1
			});

			// Phase 2
			movieInfoList.Add(new MovieInfo
			{
				Name = "Iron Man 3",
				ReleaseDate = new DateTime(2013, 5, 3),
				Phase = 2
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Thor: The Dark World",
				ReleaseDate = new DateTime(2013, 11, 8),
				Phase = 2
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Captain America: The Winter Soldier",
				ReleaseDate = new DateTime(2014, 4, 4),
				Phase = 2
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Guardians of the Galaxy",
				ReleaseDate = new DateTime(2014, 8, 1),
				Phase = 2
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Avengers: Age of Ultron",
				ReleaseDate = new DateTime(2015, 5, 1),
				Phase = 2
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Ant-Man",
				ReleaseDate = new DateTime(2015, 7, 17),
				Phase = 2
			});

			// Phase 3
			movieInfoList.Add(new MovieInfo
			{
				Name = "Captain America: Civil War",
				ReleaseDate = new DateTime(2016, 5, 6),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Doctor Strange",
				ReleaseDate = new DateTime(2016, 11, 4),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Guardians of the Galaxy 2",
				ReleaseDate = new DateTime(2017, 5, 5),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Spider-Man",
				ReleaseDate = new DateTime(2017, 7, 28),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Thor: Ragnarok",
				ReleaseDate = new DateTime(2017, 11, 3),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Avengers: Infinity War Part 1",
				ReleaseDate = new DateTime(2018, 5, 4),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Black Panther",
				ReleaseDate = new DateTime(2018, 7, 6),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Captain Marvel",
				ReleaseDate = new DateTime(2018, 11, 2),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Avenger: Infinity War Part 2",
				ReleaseDate = new DateTime(2019, 5, 3),
				Phase = 3
			});
			movieInfoList.Add(new MovieInfo
			{
				Name = "Inhumans",
				ReleaseDate = new DateTime(2019, 7, 12),
				Phase = 3
			});

			return movieInfoList;
		}

		// GET api/movieinfo/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/movieinfo
		public void Post([FromBody]string value)
		{
		}

		// PUT api/movieinfo/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/movieinfo/5
		public void Delete(int id)
		{
		}
	}
}
