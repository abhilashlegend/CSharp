namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Philips");
            myRadio.SwitchOn();
            myRadio.ListenToRadio();

            TV myTV = new TV(false, "Samsung");
            myTV.WatchTV();
        }
    }
}