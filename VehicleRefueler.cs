using System.Globalization;
using StrategyPatternPractice;

namespace DefaultNamespace
{
    public class VehicleRefueler
    {
        public string RefuelVehicle(IVehicleStrategy strategy, int currentCapacity, int maxCapacity)
        {
            decimal strat = strategy.CalculateCost(currentCapacity, maxCapacity);

            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            return strat.ToString();
        }
    }
}