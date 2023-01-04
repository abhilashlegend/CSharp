namespace InputTester;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter input");
        string input  = Console.ReadLine();

        Console.WriteLine("Select any option to test the type");
        Console.WriteLine("1 for string");
        Console.WriteLine("2 for interger");
        Console.WriteLine("3 for boolean");

        int choice = int.Parse(Console.ReadLine());
        bool valid = false;
        string inputValueType = null;

        switch (choice)
        {
            case 1:
                // Check for string
                valid = IsAllAlphabetic(input);
                inputValueType = "String";
                break;
            case 2:
                int retValue = 0;
                // Check for Integer
                valid = int.TryParse(input, out retValue);
                inputValueType = "Integer";
                break;
            case 3:
                // Check for boolean
                bool retFlag = false;
                valid = bool.TryParse(input, out retFlag);
                inputValueType = "Boolean";
                break;
            default:
                Console.WriteLine("Not able to detect the input type, something is wrong");
                break;
        }
        Console.WriteLine("You have entered a value : {0}", input);

        if (valid)
        {
            Console.WriteLine("It is a valid : {0}", inputValueType);
        } 
        else
        {
            Console.WriteLine("It is an invalid : {0}", inputValueType);
        }
        Console.ReadLine();
    }

    static bool IsAllAlphabetic(string value)
    {
        foreach(char c in value)
        {
                if(!char.IsLetter(c)) return false;
        }
        return true;
    }
}
