namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Vehicle car = new Vehicle(200, 200);

            car.Drive(50);
            System.Console.WriteLine(car);

            Car carr = new Car(200, 200);

            carr.Drive(50);
            System.Console.WriteLine(carr);
        }
    }
}
