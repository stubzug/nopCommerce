using System.Threading.Tasks;

namespace Nop.Services.ScheduleTasks
{
    /// <summary>
    /// Task manager interface
    /// </summary>
    public interface ITaskManager
    {
        /// <summary>
        /// Initializes task scheduler
        /// </summary>
        /// <returns></returns>
        Task Initialize();

        /// <summary>
        /// Starts the task scheduler
        /// </summary>
        public void StartScheduler();

        /// <summary>
        /// Stops the task scheduler
        /// </summary>
        public void StopScheduler();
    }
}