using MyWebAPI.Services;

namespace MyWebAPI.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting()
        {
            return "Assalamualaikum, Welcome to Web API!";
        }
    }
}