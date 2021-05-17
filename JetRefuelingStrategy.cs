namespace StrategyPatternPractice
{
    public class JetRefuelingStrategy : IVehicleStrategy
    {
        public decimal fuelCost = 50.0M;

        public decimal calculateCost(int currCapacity, int maxCapacity)
        {
            return (maxCapacity - currCapacity) * fuelCost;
        }
    }
}