namespace StrategyPatternPractice
{
    public class ElectricCarRefuelingStrategy : IVehicleStrategy
    {
        private decimal fuelCost = 0.5M;
        public decimal CalculateCost(int currCapacity, int maxCapacity)
        {
            return (maxCapacity - currCapacity) * fuelCost;
        }
    }
}