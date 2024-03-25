

namespace SystemPoo.Entities 
{
    public abstract class Smartphone(string number, string model, string imei, int size)
    {
        public string Number { get; set; } = number;
        private string Model { get; set; } = model;
        private string IMEI { get; set; } = imei;
        private int Size { get; set; } = size;

        public void Call() 
        {
            Console.WriteLine("Starting a call...");
        }
        public void ReceiveCall() 
        {
            Console.WriteLine("Receiving a call...");
        }
        public abstract void InstalarAplicativo(string nameApp);
    }
}