using System;
using System.Collections.Generic;
using System.Web.Http;
using CountdownService.Models;
using CountdownService.Models.Enums;

namespace CountdownService.Controllers
{
    public class MovieInfoController : ApiController
    {
	    private static string DomainNameUrl = "www.something.com";
	    private static string GetMethodUrl = "/getmovies";

        // GET api/movieinfo
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
