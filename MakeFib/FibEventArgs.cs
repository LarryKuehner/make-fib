using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace libMakeFib
{
    public class FibEventArgs : EventArgs
    {
        public uint Number { get; private set; }

        public FibEventArgs()
        {
        }

        public FibEventArgs(uint number)
        {
            this.Number = number;
        }
    }
}