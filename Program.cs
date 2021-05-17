using System;
using DefaultNamespace;

namespace StrategyPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern!");
            var refuler1 = new VehicleRefueler();
            JetRefuelingStrategy jet = new JetRefuelingStrategy();
            DieselTruckRefuelingStrategy truck = new DieselTruckRefuelingStrategy();
            ElectricCarRefuelingStrategy tesla = new ElectricCarRefuelingStrategy();
            Console.WriteLine(refuler1.RefuelVehicle(jet, 100, 201));
            Console.WriteLine(refuler1.RefuelVehicle(truck, 100, 200));
            Console.WriteLine(refuler1.RefuelVehicle(tesla, 100, 200));           
        }
    }
}
