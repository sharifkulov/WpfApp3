using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Application
    {
        /// <summary>
        /// Ссылка на единственный экземпляр класса приложения.
        /// </summary>
        private Application application;
        /// <summary>
        /// Список со списком задач.
        /// </summary>
        private List<TaskList> taskLists;
        /// <summary>
        /// Конструктор инициализирует список со списком задач и добавляет в него список задач с именем Входящие
        /// </summary>
        public Application()
        {
            taskLists = new List<TaskList>() { new TaskList("Входящие") };
        }
        /// <summary>
        /// Возвращает ссылку на экземпляр приложения, а в его отсутствие создает экземпляр.
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if (application == null)
                application = new Application();
            return application;
        }
        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskLists.
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(string name)
        {
            List<TaskList> taskLists = new List<TaskList>();
            taskLists.Add(new TaskList(name));
        }
        /// <summary>
        /// Возвращает имена списков задач
        /// </summary>
        /// <returns></returns>
        public List<string> GetTaskListNames()
        {
            var name = taskLists.Select(t => t.GetName()).ToList();
            return name;
        }
        /// <summary>
        /// Возвращает список задач по имени списка.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TaskList GetTaskByName(string name)
        {
            var taskList = taskLists.FirstOrDefault(t => t.GetName()==name);
            return taskList;
        }


    }
}
