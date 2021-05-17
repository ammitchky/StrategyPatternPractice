namespace StrategyPatternPractice
{
    public interface IVehicleStrategy
    {
        decimal CalculateCost(int currCapacity, int maxCapacity);
    }
}