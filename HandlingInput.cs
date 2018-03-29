using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class HandlingInput
    {
        private Parser parser = new Parser();

        public void Play()
        {
            Boolean finished = false;
            while (!finished)
            {
                Console.Write("Command: ");
                Command command = parser.getCommand();
                finished = ProcessCommand(command);
            }
        }

        private Boolean ProcessCommand(Command command)
        {
            if (command.IsUnknown)
            {
                Console.WriteLine("Don't understand command");
                return true;
            }
            return false;
        }
    }
}
