namespace SystemPoo.Entities 
{
    public class Nokia(string number, string model, string imei, int size) : 
        Smartphone(number, model, imei, size)
    {
        public override void InstalarAplicativo(string nameApp)
        {
            Console.Write("Utilize o aplicativo NokiaInstall");
        }

    }
}