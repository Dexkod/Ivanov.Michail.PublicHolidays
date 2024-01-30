namespace Ivanov.Michail.PublicHolidays.Data
{
    /// <summary>
    /// День.
    /// </summary>
    public class Day
    {
        /// <summary>
        /// Время.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Выходной ли день.
        /// </summary>
        public bool IsPublicHoliday { get; set; } = false;

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public Day(DateTime time)
        {
            Time = time;
        }
    }
}
