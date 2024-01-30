namespace Ivanov.Michail.PublicHolidays.Data
{
	/// <summary>
	/// Праздничный день.
	/// </summary>
	public class PublicHoliday
	{
#pragma warning disable CS8618
		public DateTime Date { get; set; }
		public string LocalName { get; set; }
		public string Name { get; set; }
		public string CountryCode { get; set; }
		public object Counties { get; set; }
		public object LaunchYear { get; set; }
		public string[] Types { get; set; }
#pragma warning restore CS8618
		public bool Fixed { get; set; }
		public bool Global { get; set; }
	}
}
