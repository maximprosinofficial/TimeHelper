using TimeHelper.TaskManagerService.Models;
using TimeHelper.TaskManagerService.Functions;

namespace TimeHelper.TaskManagerService;

public class TaskManager
{
    static List<TaskModel> _tasks = new List<TaskModel>();
    static List<TaskModel> _tasksAsCompleted = new List<TaskModel>();
    static List<TaskModel> _tasksAsDeleted = new List<TaskModel>();

    public static void TaskManager_Load()
    {
        Console.Title = "Task Manager | x1mhp.sys";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Нажмите любую клавишу для продолжения");
        Console.ResetColor();

        Console.ReadKey();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВыберите действие: \n1. Добавить задачу \n2. Просмотреть текущие задачи \n3. Отметить задачу как выполненную \n4. Изменить задачу \n5. Удалить задачу \n6. Посмотреть выполненные задачи \n7. Посмотреть удаленные задачи \n8. Выйти\n");
            Console.ResetColor();
            
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1: AddTaskFunction.AddTask(_tasks); break;
                case 2: DisplayListsFunction.DisplayTasks(_tasks); break;
                case 3: MarkTaskAsCompleteFunction.MarkTaskAsComplete(_tasks, _tasksAsCompleted); break;
                case 4: EditTaskFunction.EditTask(_tasks); break;
                case 5: DeleteTaskFunction.DeleteTask(_tasks, _tasksAsDeleted); break;
                case 6: DisplayListsFunction.DisplayAsCompletedTasks(_tasksAsCompleted); break;
                case 7: DisplayListsFunction.DisplayAsDeletedTasks(_tasksAsDeleted); break;
                case 8: Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nСпасибо за использование Task Manager!");
                    Console.ResetColor(); return;
                default: Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНекорректный ввод. Повторите попытку."); 
                    Console.ResetColor(); break;
            }
        }
    }
}