namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // First ad poster!
            Console.Write("Enter the first ad poster's center X: ");
            double x1 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter the first ad poster's center Y: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the first ad poster's width: ");
            double w1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the first ad poster's height: ");
            double h1 = double.Parse(Console.ReadLine());
            
            // Second ad poster!
            Console.Write("Enter the second ad poster's center X: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second ad poster's center Y: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second ad poster's width: ");
            double w2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second ad poster's height: ");
            double h2 = double.Parse(Console.ReadLine());

            // Get what area the first ad poster owns!
            double area1 = w1 * h1;
            
            double boundX1 = x1 - w1;
            double boundX2 = x1 + w1;

            double boundY1 = y1 - h1;
            double boundY2 = y1 + h1;

            // Get what area the second ad poster owns!
            double area2 = w2 * h2;

            double boundX3 = x2 - w2;
            double boundX4 = x2 + w2;

            double boundY3 = y2 - h2;
            double boundY4 = y2 + h2;

            // from -1 to 3 and 2 to 9

            // Check if boundX3 is between boundX1 and boundX2 or boundX4 is between boundX1 and boundX2
            if (boundX3 >= boundX1 && boundX3 <= boundX2 || boundX4 >= boundX1 && boundX4 <= boundX2)
            {
                if (boundY3 >= boundY1 && boundY3 <= boundY2 || boundY4 >= boundY1 && boundY4 <= boundY2)
                {
                    double xOverlap = Math.Min(boundX2, boundX4) - Math.Max(boundX1, boundX3);
                    double yOverlap = Math.Min(boundY2, boundY4) - Math.Max(boundY1, boundY3);
                    double areaOverlap = xOverlap * yOverlap;
                    
                    if (areaOverlap > 8)
                    {
                        Console.WriteLine("Too Much Overlaping");
                    }
                    else
                    {
                        Console.WriteLine("Not Much Overlapping");
                    }
                }
                else
                {
                    Console.WriteLine("No Overlapping");
                }
            }
            else
            {
                Console.WriteLine("No Overlapping");
            }
        }
    }
}