using Nop.Services.Caching;

namespace Nop.Services.ScheduleTasks.Caching
{
    /// <summary>
    /// Represents a schedule task cache event consumer
    /// </summary>
    public partial class ScheduleTaskCacheEventConsumer : CacheEventConsumer<Core.Domain.Tasks.ScheduleTask>
    {
    }
}
