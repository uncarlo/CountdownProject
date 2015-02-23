using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Http;
using CountdownService.Models;
using CountdownService.MovieService;

namespace CountdownService.Controllers
{
	public class MovieInfoController : ApiController
	{
		// Movie Phases:
		// http://en.wikipedia.org/wiki/Marvel_Cinematic_Universe#Films

		// GET api/movieinfo
		public async Task<IEnumerable<MovieInfo>> GetAsync()
		{
			try
			{
				return await MovieService.MovieService.Instance.MovieProvider.GetMoviesAsync("Marvel");
			}
			catch (Exception ex)
			{
				Debug.Print("Exception: {0}", ex.Message);
				return null;
			}
		}

		public IEnumerable<MovieInfo> Get()
		{
			try
			{
				return MovieService.MovieService.Instance.MovieProvider.GetMovies("Marvel");
			}
			catch (Exception ex)
			{
				Debug.Print("Exception: {0}", ex.Message);
				return null;
			}
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
