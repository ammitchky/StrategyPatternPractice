namespace StrategyPatternPractice
{
    public class DieselTruckRefuelingStrategy : IVehicleStrategy
    {
        private decimal fuelCost = 3.1M;
        public decimal CalculateCost(int currCapacity, int maxCapacity)
        {
            return (maxCapacity - currCapacity) * fuelCost;
        }
    }
}