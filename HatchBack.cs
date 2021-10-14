using System;
using System.Collections.Generic;
using System.Text;

namespace MockLabTest
{
    class HatchBack : Car
    {
        private bool foldableSeats;


        public HatchBack(int vin, int mileage, string make, string model, int seats,bool foldable) : base(vin, mileage, make, model, seats)
        {
            this.foldableSeats = foldable;
        }

        public bool getFoldableSeats()
        {
            return foldableSeats;
        }


        public override string ToString()
        {
            string s = base.ToString();
            s += "\nSub Type: Hatchback";
            s += "\nFoldable seats: " + foldableSeats;
            return s;
        }
    }
}
