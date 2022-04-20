using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Task
    {
        /// <summary>
        /// Название задачи.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Дата и время завершения задачи.
        /// </summary>
        public DateTime Due { get; set; }
        /// <summary>
        /// Отметка о выполнении задачи.
        /// </summary>
        public bool Done { get; set; }
        /// <summary>
        /// Конструктор для класса Task
        /// </summary>
        /// <param name="title"></param>
        /// <param name="due"></param>
        /// <param name="done"></param>
        public Task(string title, DateTime due, bool done)
        {
            this.Title = title;
            this.Due = due;
            this.Done = done;
        }
    }
}
