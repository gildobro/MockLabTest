using System;
using System.Collections.Generic;
using System.Text;

namespace MockLabTest
{
    class Boat : Vehicle
    {
        private bool radar;

        public Boat(int vin, int mileage, string make, string model, bool radar) :base(vin, mileage, make, model)
        {
            this.radar = radar;
        }

        public bool getRadar()
        {
            return radar;
        }

        public override string ToString()
        {
            string s =  base.ToString();
            s += "\nType: Boat";
            s += "\nRadar: " + radar;
            return s;
        }

    }
}
