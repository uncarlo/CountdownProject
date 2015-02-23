using System;

namespace CountdownService.MovieService.Services
{
	[Flags]
	internal enum MovieProviderTypes
	{
		None = 0,
		Mock = 1,
		MovieDB = 2
	}
}