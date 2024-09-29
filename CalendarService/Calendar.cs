using TimeHelper.CalendarService.Functions;

namespace TimeHelper.CalendarService;

public class Calendar
{
    public static void Calendar_Load()
    {
        Console.Title = "Calendar | x1mhp.sys";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Нажмите любую клавишу для продолжения");
        Console.ResetColor();

        Console.ReadKey();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВыберите действие: \n1. Показать календарь за текущий месяц \n2. Показать календарь за заданный месяц \n3. Выйти в главное меню Time Helper\n");
            Console.ResetColor();
            
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1: DisplayCalendarNowFunction.DisplayCalendarNow(); break;
                case 2: DisplayCalendarFunction.DisplayCalendar(); break;
                case 3: Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nСпасибо за использование Calendar");
                    Console.ResetColor(); return;
                default: Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНекорректный ввод. Повторите попытку."); 
                    Console.ResetColor(); break;
            }
        }
    }
}