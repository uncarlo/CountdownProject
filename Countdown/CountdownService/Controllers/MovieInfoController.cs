using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
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
//			using (var client = new HttpClient())
//			{
//				client.BaseAddress = new Uri(DomainNameUrl);
//				client.DefaultRequestHeaders.Accept.Clear();
//				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//			
//				// New code:
//				HttpResponseMessage response = await client.GetAsync(GetMethodUrl + APIKey);
//				if (response.IsSuccessStatusCode)
//				{
//			
//				}
//				else
//				{
//					
//				}
//			}

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
