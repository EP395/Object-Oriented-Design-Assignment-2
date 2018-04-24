using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class Motel
    {
        public List<Room> roomList;

        public delegate void TemperatureChangeHandler();

        public TemperatureChangeHandler TempHandler { get; set; }

        public Motel()
        {
            roomList = new List<Room>();
            for (int i = 0; i < Constants.MAX_ROOMS; i++)
            {
                Room room = new Room(i + 1);
                roomList.Add(room);
            }
            roomList[0].Temperature = 200; // testing - will be random
        }

        public void CheckRooms()
        {
            for (int currentRoom = 0; currentRoom < roomList.Count; currentRoom++)
            {
                int prevRoom = currentRoom - 1;
                int nextRoom = currentRoom + 1;

                if((prevRoom >= 0 && roomList[prevRoom].Temperature >= (int)RoomState.DANGER)
                    || (nextRoom < Constants.MAX_ROOMS && roomList[nextRoom].Temperature >= (int)RoomState.DANGER))
                {
                    AddToDelegate(roomList[currentRoom]);
                }
            }
        }

        public void AddToDelegate(Room room)
        {
            TempHandler -= room.HeatUp; // stop rooms being duplicated
            TempHandler += room.HeatUp;
        }

        public void CountDelegates()
        {
            Console.WriteLine(TempHandler.GetInvocationList().Count());
        }

        public void GetRoomTemps()
        {
            for(int i = 0; i < roomList.Count; i++)
            {
                Console.WriteLine("Room Number: " + roomList[i].RoomID + " - Temperature: " + roomList[i].Temperature);
            }
        }
    }
}
