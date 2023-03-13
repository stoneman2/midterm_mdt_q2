namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Insert time: ");
            int time = int.Parse(Console.ReadLine());

            int breakfast = 5;
            int weekend = 2;
            int coffee = 3;

            while(true)
            {
                Console.Write("Insert food set: ");
                string foodSet = Console.ReadLine();

                switch (foodSet)
                {
                    case "Breakfast Set":
                        if ( breakfast > 0 && time < 11 )
                        {
                            breakfast--;
                        }
                        else if ( time > 11 )
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        else if ( breakfast == 0 )
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;
                    case "Weekend Set":
                        if ( weekend > 0 && day > 5 )
                        {
                            weekend--;
                        }
                        else if ( day < 6 )
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        else if ( weekend == 0 )
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;
                    case "Coffee":
                        if (coffee > 0)
                        {
                            coffee--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;
                    case "End":
                        return;
                    default:
                        Console.WriteLine("Please enter a valid menu");
                        break;
                }
            }
        }
    }
}