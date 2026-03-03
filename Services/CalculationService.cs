using MyWebAPI.Services;

namespace MyWebAPI.Services
{
    public class CalculationService : ICalculationService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}