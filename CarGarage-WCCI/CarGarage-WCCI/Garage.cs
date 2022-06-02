using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage_WCCI
{
    public class Garage
    {
        public int Capacity;
        public List<Vehicle> Vehicles;
        public bool HasBikeRacks;
        public bool HasGas;
        public bool IsDoorOpen;

        public Garage(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
            HasBikeRacks = true;
            HasGas = true;
            IsDoorOpen = true;
        }

        public Garage(List<Vehicle> vehicles)
        {
            Capacity = vehicles.Count;
            Vehicles = vehicles;
            HasBikeRacks = true;
            HasGas = true;
            IsDoorOpen = false;
        }

        public void OpenDoor()
        {
            Console.WriteLine("The garge door is opened!");
            IsDoorOpen = true;
        }

        public void ClosingDoor()
        {
            Console.WriteLine("The garge door is closed!");
            IsDoorOpen = false;
        }

        public void ToggleDoor()
        {
            if(IsDoorOpen)
            {
                IsDoorOpen = false;
            }
            else
            {
                IsDoorOpen = true;
            }
        }
        public void ShortToggleDoor()
        {
            IsDoorOpen = !IsDoorOpen;
        }
    }
}
