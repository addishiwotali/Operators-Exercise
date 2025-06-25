namespace OperatorExercise
{  public class Program
    {
        public static double AreaCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaCircle()
        {
            Console.WriteLine("what is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"the are of a circle with radius {radius} is {Math.Round(AreaCircle(radius), 3)}");
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            
            int division = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {division} remainder {remainder}");
            
            PrintAreaCircle();
        }
    }
}
