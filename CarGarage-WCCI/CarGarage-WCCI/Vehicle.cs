using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage_WCCI
{
    public abstract class Vehicle
    {
        public int Speed;
        public int TopSpeed;

        public abstract void Accelerate();
        public abstract void Brake();
        public abstract void Tick();
    }
}
