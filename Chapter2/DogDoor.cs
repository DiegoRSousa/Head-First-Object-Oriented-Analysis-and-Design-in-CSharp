namespace Chapter2
{
    public class DogDoor
    {
        public bool Open { get; private set; }

        public DogDoor()
        {
            this.Open = false;
        }

        public void OpenDor()
        {
            System.Console.WriteLine("The dog door opens.");
            this.Open = true;
        }

        public void CloseDor()
        {
            System.Console.WriteLine("The dog door closes.");
            this.Open = false;
        }


    }
}
