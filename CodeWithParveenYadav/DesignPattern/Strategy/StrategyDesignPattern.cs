using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.DesignPattern.Strategy
{

    public interface ITravelStrategy
    {
        int GetCost();
    }

    public class CarStrategy : ITravelStrategy
    {
        public int GetCost()
        {
            return 2000;
        }
    }

    public class TrainStrategy : ITravelStrategy
    {
        public int GetCost()
        {
            return 2000;
        }
    }

    public class BikeStrategy : ITravelStrategy
    {
        public int GetCost()
        {
            return 2500;
        }
    }

    public class TravelContextStrategy
    {
        ITravelStrategy _travelStrategy;
        public TravelContextStrategy(ITravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }

        public int GetCostStrategy()
        {
            return _travelStrategy.GetCost();
        }
    }
}
