namespace StrategyPatternPractice
{
    public class DieselTruckRefuelingStrategy : IVehicleStrategy
    {
        public decimal fuelCost = 3.1M;
        public decimal calculateCost(int currCapacity, int maxCapacity)
        {
            return (maxCapacity - currCapacity) * fuelCost;
        }
    }
}