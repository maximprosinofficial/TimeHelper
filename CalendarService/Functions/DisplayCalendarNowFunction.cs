using ConsoleTables;

namespace TimeHelper.CalendarService.Functions;

public class DisplayCalendarNowFunction
{
    public static void DisplayCalendarNow()
    {
        DateTime currentDate = DateTime.Now;
        int year = currentDate.Year;
        int month = currentDate.Month;
            
        DateTime date = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
            
        ConsoleTable calendarTable = new ConsoleTable("Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс");
            
        int currentDay = 1;
        int dayOfWeek = ((int)date.DayOfWeek == 0) ? 7 : (int)date.DayOfWeek;

        object[] weekDays = new object[7];

        for (int i = 0; i < dayOfWeek - 1; i++)
        {
            weekDays[i] = "";
        }

        while (currentDay <= daysInMonth)
        {
            for (int i = dayOfWeek - 1; i < 7; i++)
            {
                weekDays[i] = currentDay.ToString();
                currentDay++;
                if (currentDay > daysInMonth)
                {
                    break;
                }
            }

            calendarTable.AddRow(weekDays);
            weekDays = new object[7];
            dayOfWeek = 1;
        }

        calendarTable.Options.EnableCount = false;

        Console.WriteLine("\nКалендарь на " + currentDate.ToString("MMMM yyyy"));
        Console.WriteLine($"{calendarTable}");
    }
}