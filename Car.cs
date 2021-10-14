using System;
using System.Collections.Generic;
using System.Text;

namespace MockLabTest
{
    class Car : Vehicle
    {
        private int seats;


        public Car(int vin, int mileage, string make, string model, int seats):base(vin, mileage, make, model)
        {
            this.seats = seats;
        }

        public int getSeats()
        {
            return seats;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "\nType: Car";
            s += "\nSeats: " + seats;
            return s;
        }
    }
}
