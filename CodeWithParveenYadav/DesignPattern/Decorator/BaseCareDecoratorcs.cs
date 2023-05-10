using CodeWithParveenYadav.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.DesignPattern.Decorator
{
    internal abstract class BaseCareDecorator : ICarService
    {
        ICarService _carService;

        public BaseCareDecorator(ICarService carService)
        {
            _carService = carService;
        }

        public virtual int GetCost()
        {
            return _carService.GetCost();
        }

        public virtual string GetDescription()
        {
            return _carService.GetDescription();
        }
    }
}
