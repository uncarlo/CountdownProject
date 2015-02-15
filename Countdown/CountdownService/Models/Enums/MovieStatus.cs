using System.ComponentModel;

namespace CountdownService.Models.Enums
{
	public enum MovieStatus
	{
		[Description("Released")]
		Released,
		[Description("Post-Production")]
		PostProduction,
		[Description("Pre-Production")]
		PreProduction,
		[Description("In Development")]
		InDevelopment,
		[Description("Openning Soon")]
		OpenningSoon
	}
}