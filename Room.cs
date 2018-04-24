using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class Room
    {
        public int RoomID { get; set; }
        public Boolean IsFlammable { get; set; }
        public int Temperature { get; set; }

        public Room(int roomNum)
        {
            RoomID = roomNum;
            IsFlammable = true;
            Temperature = (int)RoomState.SAFE;
        }


        public void HeatUp()
        {
            if(IsFlammable)
            {
                if(Temperature >= (int)RoomState.BURNEDOUT)
                {
                    // do nothing atm
                }
                else
                {
                    Temperature += Constants.TEMP_INCREASE;
                }
            }
        }

        public void CoolDown()
        {
            if(Temperature <= (int)RoomState.SAFE)
            {
                IsFlammable = false;
            }
            else
            {
                Temperature -= Constants.TEMP_DECREASE;
            }
        }
    }
}
