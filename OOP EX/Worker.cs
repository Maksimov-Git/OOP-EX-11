using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_EX
{
    public abstract class Worker
    {
        public string FIO;
        public float ZP;
        private int flour;

        public event System.EventHandler getZP;
    }
}