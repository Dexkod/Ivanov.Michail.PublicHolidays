using Newtonsoft.Json;

namespace Ivanov.Michail.PublicHolidays.Data
{
	/// <summary>
	/// Праздничные дни апи.
	/// </summary>
	public class PublicHolidayApi
	{
		/// <summary>
		/// Url.
		/// </summary>
		private string Url = "https://date.nager.at/api/v3/publicholidays";

		/// <summary>
		/// Получение праздничных дней.
		/// </summary>
		/// <param name="year">Год.</param>
		/// <param name="country">Страна.</param>
		/// <returns>Задача получения.</returns>
		public async Task<List<PublicHoliday>> GetPublicHolidaysAsync(string year, string country)
		{
			if (string.IsNullOrWhiteSpace(year) || string.IsNullOrWhiteSpace(country))
			{
				return new List<PublicHoliday>();
			}

			Url += $"/{year}/{country}";

			using (var client = new HttpClient())
			{
				var result = await client.GetAsync(Url);

				if (result == null || !result.IsSuccessStatusCode)
				{
					return new List<PublicHoliday>();
				}

				var days = JsonConvert.DeserializeObject<List<PublicHoliday>>
					(await result.Content.ReadAsStringAsync());

				return days ?? new List<PublicHoliday>();
			}
		}
	}
}
