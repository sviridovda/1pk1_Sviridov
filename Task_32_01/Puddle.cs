using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Puddle : Obstacle
    {
        public Puddle() : base("Лужа") { }

        public override bool UnSpeed(Kolobok kolobok)
        {
            return false;
        }
    }
}