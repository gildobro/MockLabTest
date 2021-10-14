using System;
using System.Collections.Generic;
using System.Text;

namespace MockLabTest
{
    class Sedan : Car
    {
        private bool backseatFridge;
        private bool backseatRecliner;

        public Sedan(int vin, int mileage, string make, string model, int seats, bool fridge, bool recliner) : base(vin, mileage, make, model, seats)
        {
            this.backseatFridge = fridge;
            this.backseatRecliner = recliner;
        }

        public bool hasFridge()
        {
            return backseatFridge;
        }

        public bool hasRecliner()
        {
            return backseatRecliner;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "\nSub Type: Sedan";
            s += "\nBackseat Fridge: " + backseatFridge;
            s += "\nBackseat Recliner: " + backseatRecliner;
            return s;
        }
    }
}
