using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TaskList
    {
        /// <summary>
        /// Имя списка с задачами.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Список задач, относящихся к списку.
        /// </summary>
        private List<Task> tasks = new List<Task>();
        /// <summary>
        /// Конструктор инициализирует список задач с указанным именем.
        /// </summary>
        /// <param name="name"></param>
        public TaskList(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Добавляет задачу в список задач
        /// </summary>
        /// <param name="title"></param>
        /// <param name="due"></param>
        /// <param name="done"></param>
        public void AddTask(string title, DateTime due, bool done)
        {
            tasks.Add(new Task(title, due, done));
        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTask()
        {
            return tasks;
        }
        /// <summary>
        /// Удаляет задачу из списка задач
        /// </summary>
        public void Remove()
        {
            foreach(var task in tasks)
            {
                tasks.Remove(task);
            }
        }
        /// <summary>
        /// Возвращает задачи запланированные на сегодня в хронологическом порядке.
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            var today = DateTime.Now.ToShortDateString();
            var taskByToday = tasks.Where(t => t.Due.ToShortDateString() == today).ToList();
            return taskByToday;
        }
        /// <summary>
        /// Возвращает задачи на завтра и позже в хронологическом порядке.
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            var future = DateTime.Now;
            var taskByFuture = tasks.Where(t => t.Due > future).ToList();
            return taskByFuture;
        }

    }
}
