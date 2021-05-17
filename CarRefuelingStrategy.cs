namespace StrategyPatternPractice
{
    public class CarRefuelingStrategy : IVehicleStrategy
    {
        private decimal fuelCost = 2.0M;

        public decimal CalculateCost(int currCapacity, int maxCapacity)
        {
            return (maxCapacity - currCapacity) * fuelCost;
        }
    }
}