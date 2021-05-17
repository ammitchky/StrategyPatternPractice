namespace StrategyPatternPractice
{
    public class ElectricCarRefuelingStrategy : IVehicleStrategy
    {
        public decimal fuelCost = 0.5M;
        public decimal calculateCost(int currCapacity, int maxCapacity)
        {
            return (maxCapacity - currCapacity) * fuelCost;
        }
    }
}