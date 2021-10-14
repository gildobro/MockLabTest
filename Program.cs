using System;

namespace MockLabTest
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager vm = new VehicleManager();
            vm.addVehicle(1233, 89000, "Mitsubishi", "Galant", 5);
            vm.addVehicle(2223, 1000, "Yaht", "Seabreeze", true);
            vm.addVehicle(7788, 102030, "Toyota", "Yaris", 5, true);
            vm.addVehicle(3023, 12000, "Nissan", "Almera", 5, true, false);

            Console.WriteLine(vm.listAllVehicles());
        }
    }
}
