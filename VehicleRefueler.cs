using System;
using System.Globalization;
using StrategyPatternPractice;

namespace DefaultNamespace
{
    public class VehicleRefueler
    {
        public string RefuelVehicle(IVehicleStrategy strategy, int currentCapacity, int maxCapacity)
        {
            if(currentCapacity > maxCapacity){
                throw new ApplicationException("Current capacity exceeds max capacity.");
            }
            
            decimal strat = strategy.CalculateCost(currentCapacity, maxCapacity);

            return "$" + strat.ToString("0.00") + " gallons: " + (maxCapacity - currentCapacity);
        }
    }
}