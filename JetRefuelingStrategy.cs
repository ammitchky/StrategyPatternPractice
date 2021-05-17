namespace StrategyPatternPractice
{
    public class JetRefuelingStrategy : IVehicleStrategy
    {
        private decimal fuelCost = 50.0M;

        public decimal CalculateCost(int currCapacity, int maxCapacity)
        {
            return (maxCapacity - currCapacity) * fuelCost;
        }
    }
}