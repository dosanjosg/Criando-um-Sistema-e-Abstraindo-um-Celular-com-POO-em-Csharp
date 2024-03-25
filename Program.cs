using SystemPoo.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Nokia nokia = new("052", "LUMIA", "359730053805228", 36);

        nokia.Call();
        nokia.ReceiveCall();
        nokia.InstalarAplicativo("");

        Iphone iphone = new("13", "Iphone PRO MAX", "359730053805228", 128);

        iphone.Call();
        iphone.ReceiveCall();
        iphone.InstalarAplicativo("");
    }
}