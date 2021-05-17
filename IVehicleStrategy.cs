namespace StrategyPatternPractice
{
    public interface IVehicleStrategy
    {
        decimal calculateCost(int currCapacity, int maxCapacity);
    }
}