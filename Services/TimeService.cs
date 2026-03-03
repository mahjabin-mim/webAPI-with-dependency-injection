using MyWebAPI.Services;

namespace MyWebAPI.Services
{
    public class TimeService : ITimeService
    {
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}