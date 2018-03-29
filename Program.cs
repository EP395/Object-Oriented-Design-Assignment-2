using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace FatesMotel
{
    class Program
    {
        static void Main(string[] args)
        {
            HandlingInput hi = new HandlingInput();
            Game game = new Game();
            TimerCallback timerCallBack = game.TickTock;
            Timer timer = new Timer(timerCallBack, null, 1000, game.refreshRate);
            Console.ReadLine();

            //game.playGame();

            hi.Play();
        }
    }
}
