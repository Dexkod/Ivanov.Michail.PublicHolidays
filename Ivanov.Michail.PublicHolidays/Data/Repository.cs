namespace Ivanov.Michail.PublicHolidays.Data
{
	/// <summary>
	/// Вместо бд.
	/// </summary>
	public static class Repository
	{
		/// <summary>
		/// Страны.
		/// </summary>
		public static List<string> Countries { get; set; } = new List<string>()
		{
			"RU",
			"AT",
			"US"
		};

		/// <summary>
		/// Получение годов.
		/// </summary>
		/// <returns>Список годов.</returns>
		public static List<string> GetYears()
		{
			var list = new List<string>();

			for (int i = 0; i < 5; i++)
			{
				list.Add(DateTime.Now.AddYears(-i).Year.ToString());
			}

			return list;
		}

		/// <summary>
		/// Получение всех дней в году.
		/// </summary>
		/// <param name="year">Год.</param>
		/// <returns>Список дней.</returns>
		public static List<Day> GetAllDaysInYear(int year)
		{
			var days = new List<Day>();
			var day = new DateTime(year, 1, 1);

			while (day.Year == year)
			{
				days.Add(new Day(day));
				day = day.AddDays(1);
			}

			return days;
		}
	}
}
