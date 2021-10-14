using System;
using System.Collections.Generic;
using System.Text;

namespace MockLabTest
{
    class VehicleManager
    {
        private Vehicle[] vehcleList;
        private int numVehicles;
        private int maxVehicles;


        public VehicleManager()
        {
            numVehicles = 0;
            maxVehicles = 100;
            vehcleList = new Vehicle[maxVehicles];
        }

        public bool addVehicle(int vin, int mileage, string make, string model, int seats)
        {
            if(numVehicles < maxVehicles)
            {
                vehcleList[numVehicles] = new Car(vin, mileage, make, model, seats);
                numVehicles++;
                return true;
            }
            return false;
        }
        public bool addVehicle(int vin, int mileage, string make, string model, int seats, bool foldableSeats)
        {
            if (numVehicles < maxVehicles)
            {
                vehcleList[numVehicles] = new HatchBack(vin, mileage, make, model, seats, foldableSeats);
                numVehicles++;
                return true;
            }
            return false;
        }
        public bool addVehicle(int vin, int mileage, string make, string model, int seats, bool fridge, bool recliner)
        {
            if (numVehicles < maxVehicles)
            {
                vehcleList[numVehicles] = new Sedan(vin, mileage, make, model, seats, fridge, recliner);
                numVehicles++;
                return true;
            }
            return false;
        }
        public bool addVehicle(int vin, int mileage, string make, string model, bool radar)
        {
            if (numVehicles < maxVehicles)
            {
                vehcleList[numVehicles] = new Boat(vin, mileage, make, model, radar);
                numVehicles++;
                return true;
            }
            return false;
        }

        public string listAllVehicles()
        {
            string s = "<------Vehicle List ------>\n";
            for(int x = 0; x < numVehicles; x++)
            {
                s += "\n" + vehcleList[x] + "\n";
            }
            return s;
        }
    }
}
