﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class Parser
    {
        public Command getCommand()
        {
            string inputLine = "";
            inputLine = Console.ReadLine();
            String[] values = inputLine.Split(' ', '\n');

            if (CommandWords.isCommand(values[0]))
                if (values.Count() == 1)
                    return new Command { CommandWord = values[0], SecondWord = null, ThirdWord = null, FourthWord = null };
                else if (values.Count() == 2)
                    return new Command { CommandWord = values[0], SecondWord = values[1], ThirdWord = null, FourthWord = null };
                else if (values.Count() == 3)
                    return new Command { CommandWord = values[0], SecondWord = values[1], ThirdWord = values[2], FourthWord = null };
                else if (values.Count() == 4)
                    return new Command { CommandWord = values[0], SecondWord = values[1], ThirdWord = values[2], FourthWord = values[3] };
            return new Command();

        }
    }
}
