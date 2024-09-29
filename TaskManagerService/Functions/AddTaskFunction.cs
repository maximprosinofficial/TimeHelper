namespace TimeHelper.TaskManagerService.Functions;

using Models;

public class AddTaskFunction
{
    public static void AddTask(List<TaskModel> list)
    {
        Console.Write("\nВведите название новой задачи: ");
        string? title = Console.ReadLine();
        
        Console.Write("Введите дату выполнения задачи (01.01.2001): ");
        DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out var date);
        
        Console.Write("Введите время выполнения задачи (15:30): ");
        DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out var time);

        if (title != null) list.Add(new TaskModel(title, date, time));

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nЗадача успешно добавлена");
        Console.ResetColor();
    }
}