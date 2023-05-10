using CodeWithParveenYadav.Interfaces;
using CodeWithParveenYadav.Models;

namespace CodeWithParveenYadav.Service
{
    class CarService : ICarService
    {
        public int GetCost()
        {
            return 2000000;
        }

        public string GetDescription()
        {
            return "This is Luxary Car";
        }
    }
}
