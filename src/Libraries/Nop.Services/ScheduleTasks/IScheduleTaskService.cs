using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.Services.ScheduleTasks
{
    /// <summary>
    /// Task service interface
    /// </summary>
    public partial interface IScheduleTaskService
    {
        /// <summary>
        /// Deletes a task
        /// </summary>
        /// <param name="task">Task</param>
        Task DeleteTaskAsync(Core.Domain.Tasks.ScheduleTask task);

        /// <summary>
        /// Gets a task
        /// </summary>
        /// <param name="taskId">Task identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the schedule task
        /// </returns>
        Task<Core.Domain.Tasks.ScheduleTask> GetTaskByIdAsync(int taskId);

        /// <summary>
        /// Gets a task by its type
        /// </summary>
        /// <param name="type">Task type</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the schedule task
        /// </returns>
        Task<Core.Domain.Tasks.ScheduleTask> GetTaskByTypeAsync(string type);

        /// <summary>
        /// Gets all tasks
        /// </summary>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the list of schedule task
        /// </returns>
        Task<IList<Core.Domain.Tasks.ScheduleTask>> GetAllTasksAsync(bool showHidden = false);

        /// <summary>
        /// Inserts a task
        /// </summary>
        /// <param name="task">Task</param>
        Task InsertTaskAsync(Core.Domain.Tasks.ScheduleTask task);

        /// <summary>
        /// Updates the task
        /// </summary>
        /// <param name="task">Task</param>
        Task UpdateTaskAsync(Core.Domain.Tasks.ScheduleTask task);
    }
}
