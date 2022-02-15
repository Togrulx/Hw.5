using System;

namespace Hw._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masininizin brandin daxil edin!");
            string brand = Console.ReadLine();
            Console.WriteLine("Masininizin rengin daxil edin!");
            string color = Console.ReadLine();
            Console.WriteLine("Masininizin Km ne qederdir daxil edin!");
            int.TryParse(Console.ReadLine(), out int millage);
            //Console.WriteLine("Masininizin MAXBenzin daxil edin!");
            //double.TryParse(Console.ReadLine(), out double fuelcapacity);
            //Console.WriteLine("Masininizin Olan Benzin daxil edin!");
            //double.TryParse(Console.ReadLine(), out double currentfuel);
            //Console.WriteLine("Masininizin Neqeder yandirir daxil edin!");
            //double.TryParse(Console.ReadLine(), out double fuelfor1km);
            Console.WriteLine("Gedeceyiniz yol miqdari");
            double.TryParse(Console.ReadLine(), out double yol);

            //Car car1 = new Car(brand, color, millage, fuelcapacity, currentfuel, fuelfor1km,yol);


            //car1.Drive();

            Byclecs bike1 = new Byclecs(brand, color, millage, yol);
            Console.WriteLine("Bike");
            bike1.Drive();
        }
    }
}

namespace Hw._5
{
    abstract class Vehicle
    {
        public string Brand;

        public string Color;

        public double Millage;

        public double Yol;

        public Vehicle()
        {

        }

        public Vehicle(string brand, string color, double millage, double yol) : this()
        {
            Brand = brand;
            Color = color;
            Millage = millage;
            Yol = yol;
        }

        public virtual string ShowInfo()
        {
            return $"{Brand} {Color} {Millage}";
        }

        public virtual void Drive()
        {

        }


    }
}

namespace Hw._5
{
    class Car : Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1Km;


        public Car(string brand, string color, double millage, double fuelcapacity, double currentfuel, double fuelfor1km, double yol) : base(brand, color, millage, yol)
        {
            FuelCapacity = fuelcapacity;
            CurrentFuel = currentfuel;
            FuelFor1Km = fuelfor1km;
            Yol = yol;
        }

        public override void Drive()
        {
            if (CurrentFuel / FuelFor1Km == Yol)
            {
                CurrentFuel--;
                Millage++;
                Console.WriteLine("Sag Salamat qardash");

            }
            else
            {
                Console.WriteLine("Fuel-niz bu yola yetmiyecek");
            }
        }

    }
}
namespace Hw._5
{
    class Byclecs : Vehicle
    {

        public Byclecs(string brand, string color, double millage, double yol) : base(brand, color, millage, yol)
        {


        }

        public override void Drive()
        {
            for (int i = 0; i < Yol; i++)
            {
                Millage++;


            }
            Console.WriteLine(Millage);
        }
    }
}