using System;

namespace Chapter2
{
    public class Remote
    {
        public DogDoor Door { get; private set; }

        public Remote(DogDoor door)
        {
            this.Door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote  control button...");
            if (Door.Open)
                Door.CloseDor();
            else
                Door.OpenDor();
        }
    }
}
