﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    public class NAND : GenericComponent
    {
        public NAND()
        {
            input = new GenericComponent[2];
        }

        public override void Execute()
        {
            if (!(input[0].state && input[1].state))
            {
                this.state = true;
            }
            notifyOutput();
        }
    }
}
