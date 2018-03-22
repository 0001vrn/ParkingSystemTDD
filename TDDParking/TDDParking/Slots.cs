using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDParking
{
    public class Slots
    {
        
        public readonly int TotalBikeSlots = 20;

        public readonly int TotalCarSlots = 20;

        public int OccupiedBikeSlots { private get; set; }

        public int OccupiedCarSlots { private get; set; }

        public int AvailableBikeSlots {
            get
            {
                return TotalBikeSlots - OccupiedBikeSlots;
            }
        }

        public int AvailableCarSlots {
            get
            {
                return TotalCarSlots - OccupiedCarSlots;
            }
        }

        public  bool AddCarInSlot()
        {
            if(AvailableCarSlots > 0)
            {
                OccupiedCarSlots++;
                return true;
            }
            
            return false;
        }


        public  bool AddBikeInSlot()
        {
            OccupiedBikeSlots++;
            return true;
        }

        public bool RemoveCarFromSlot()
        {
            if (OccupiedCarSlots > 0)
            {
                OccupiedCarSlots--;
                return true;
            }
            return false;
        }
    }
}
