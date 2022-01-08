using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Raw_Data
{
    class Car
    {
        public string Model { get; set; }
        public Engine CarEngine = new Engine();
        public Cargo CarCargo = new Cargo();
    }
}
