using ConsoleTables;

namespace TimeHelper.CalendarService.Functions;

public class DisplayCalendarFunction
{
    public static void DisplayCalendar()
    {
        Console.WriteLine("Введите год:");
        int year = Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine("Введите номер месяца (1-12):");
        int month = Convert.ToInt32(Console.ReadLine());
            
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

        Console.WriteLine($"\n{calendarTable}");
    }
}