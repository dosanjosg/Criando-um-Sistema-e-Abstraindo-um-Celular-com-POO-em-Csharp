namespace SystemPoo.Entities 
{
    public class Iphone(string number, string model, string imei, int size) : 
        Smartphone (number, model, imei, size) 
    {
        public override void InstalarAplicativo(string nameApp)
        {
            Console.WriteLine("Utilize o app IphoneInstall");
        }

    }
}