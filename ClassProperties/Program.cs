namespace ClassProperties;

class Program
{
    public static void Main(string[] args)
    {
        Box bx = new Box();
        bx.setLength(3);
        bx.setWidth(4);
        bx.setHeight(5);

        bx.getBoxInfo();
        Console.ReadLine();
    }
}
