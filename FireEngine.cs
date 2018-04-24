using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesMotel
{
    class FireEngine
    {
        public int EnigineID { get; set; }

        public int Coolant { get; set; }

        public enum EngineState { Free, OnCall, Stationed }

        public FireEngine()
        {

        }
    }
}
