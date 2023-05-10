using CodeWithParveenYadav.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.DesignPattern.Decorator
{
    internal class BasicAssecoriesForCarDecorator : BaseCareDecorator
    {
        ICarService _carService;

        public BasicAssecoriesForCarDecorator(ICarService carService) : base(carService)
        {
            _carService = carService;
        }

        public int GetCost()
        {
            var legacyCost = _carService.GetCost();

            return legacyCost + 2000;

        }

        public string GetDescription()
        {
            var legacyDescription = _carService.GetDescription();

            return legacyDescription + "This also has been added by some Basic Assecories";
        }

    }

    internal class SportsAssecoriesForCarDecorator : BaseCareDecorator
    {
        public SportsAssecoriesForCarDecorator(ICarService carService) : base(carService)
        {

        }

        public override int GetCost()
        {
            var legacyCost = base.GetCost();

            return legacyCost + 2000;

        }

        public override string GetDescription()
        {
            var legacyDescription = base.GetDescription();

            return legacyDescription + "This also has been added by some Sports Assecories";
        }

    }
}
