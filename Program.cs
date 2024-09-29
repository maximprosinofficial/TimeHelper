using TimeHelper.TaskManagerService;
using TimeHelper.CalendarService;

namespace TimeHelper;

class Program
{
    static void Main()
    {
        Console.Title = "Time Helper | x1mhp.sys";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Time Helper");
        Console.WriteLine("Разработчик: x1mhp.sys");
        Console.WriteLine("Нажмите любую клавишу для продолжения");
        
        Console.ResetColor();

        Console.ReadKey();

        while (true)
        {
            Console.Title = "Time Helper | x1mhp.sys";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВыберите действие: \n1. TaskManager\n2. Calendar\n3. Exit\n");
            Console.ResetColor();
            
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1: TaskManager.TaskManager_Load(); break;
                case 2: Calendar.Calendar_Load(); break;
                case 3: Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nСпасибо за использование Time Helper!");
                    Console.ResetColor();
                    Thread.Sleep(3000); return;
                default: Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНекорректный ввод. Повторите попытку."); 
                    Console.ResetColor(); break;
            }
        }
    }   
}