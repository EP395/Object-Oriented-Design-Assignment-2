using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class CommandWords
    {
        private static String[] validCommands = { "quit", "clear", "room", "engine",
                                                    "list", "report", "recall", "refill", "goto",
                                                    "roomId", "help" };
        public String[] ValidCommands { get { return validCommands; } }

        public static Boolean isCommand(String command)
        {
            if (validCommands.Contains(command))
                return true;
            return false;
        }
    }
}
