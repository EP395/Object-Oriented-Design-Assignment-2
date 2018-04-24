using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class Game
    {
        public enum GameSpeed { SLOW = 10000, AVERAGE = 5000, FAST = 1000 }

        public int RefreshRate = (int)GameSpeed.FAST;

        public Motel motel = new Motel();

        public void TickTock(Object data)
        {
            if (motel.TempHandler != null) motel.TempHandler();
            motel.CheckRooms();
            motel.GetRoomTemps();
        }
    }
}
