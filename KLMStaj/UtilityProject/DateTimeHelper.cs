namespace UtilityProject
{
    public class DateTimeHelper
    {
        private readonly Random random = new Random();

        public DateTime GenerateRandomDate()
        {
            int year = random.Next(1980, 2000 + 1);
            int month = random.Next(1, 12 + 1);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return new DateTime(year, month, day);
        }
    }

}
