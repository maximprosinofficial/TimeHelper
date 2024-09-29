using TimeHelper.TaskManagerService.Models;

namespace TimeHelper.TaskManagerService.Functions;

public class EditTaskFunction
{
    public static void EditTask(List<TaskModel> list)
    {
        if (list.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("nСписок задач пуст. Добавьте новую задачу.");
            Console.ResetColor();
        }
        else
        {
            DisplayListsFunction.DisplayTasks(list);
            Console.Write("nВведите номер задачи для изменения: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= list.Count)
            {
                TaskModel selectedTask = list[taskNumber - 1];
                
                Console.Write("\nВведите название новой задачи: ");
                string? newTitle = Console.ReadLine();
        
                Console.Write("Введите дату выполнения задачи (01.01.2001): ");
                DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out var newDate);
        
                Console.Write("Введите время выполнения задачи (15:30): ");
                DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out var newTime);

                if (newTitle != null)
                {
                    selectedTask.Title = newTitle;
                    selectedTask.Date = newDate;
                    selectedTask.Time = new DateTime(newTime.Ticks);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("nЗадача успешно изменена.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНе удалось изменить задачу. Повторите попытку.");
                    Console.ResetColor();
                }
            }
        }
    }
}