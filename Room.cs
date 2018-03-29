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
        public bool IsOnFire { get; set; }
        public int Temperature { get; set; }

        public Room(int RoomNum)
        {
            RoomID = RoomNum;
            IsOnFire = false;
            Temperature = (int)State.SAFE;
        }


        public void HeatUp(int t)
        {
            Temperature += t;
        }
    }
}
