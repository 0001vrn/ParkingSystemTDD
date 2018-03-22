using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDParking
{
    public class Parking
    {

        public Parking()
        {
            Slots = new Slots();
          
        }

        public Slots Slots { get; private set; }

        public bool IsCarSlotAvailable()
        {
            return Slots.AvailableCarSlots > 0;
        }

        public bool IsBikeSlotAvailable()
        {
            return Slots.AvailableBikeSlots > 0;
        }

        public int AddCarInParking()
        {
            this.Slots.AddCarInSlot();
            return this.Slots.AvailableCarSlots;
        }

        public int AddBikeInParking()
        {
            this.Slots.AddBikeInSlot();
            return this.Slots.AvailableBikeSlots;
        }
    }
}
