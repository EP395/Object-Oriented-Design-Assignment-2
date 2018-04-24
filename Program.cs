using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FatesMotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            TimerCallback timerCallback = game.TickTock;
            Timer timer = new Timer(timerCallback, null, 1000, game.RefreshRate);

            HandlingInput hi = new HandlingInput();
            hi.GetInput();
        }
    }
}
