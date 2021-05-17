namespace StrategyPatternPractice
{
    public class CarRefuelingStrategy : IVehicleStrategy
    {
        public decimal fuelCost = 2.0M;

        public decimal calculateCost(int currCapacity, int maxCapacity)
        {
            return (maxCapacity - currCapacity) * fuelCost;
        }
    }
}