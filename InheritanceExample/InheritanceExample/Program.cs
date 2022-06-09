using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product desk = new Desk();
            desk.Price = 100;
            desk.Add();
            desk.Add();

            Console.WriteLine($"Total value of desks in stock: {desk.GetTotalValueInStock()}");

            Product drone = new Drone();
            drone.Price = 200;
            ((Drone)drone).QuantityIncrement = 10;
            drone.Add();
            drone.Add();
            Console.WriteLine($"Total value of drones in stock: {drone.GetTotalValueInStock()}");

            Product droneTurbo = new TurboDrone();
            droneTurbo.Price = 100;
            ((TurboDrone)droneTurbo).QuantityIncrement = 5;
            droneTurbo.Add();
            Console.WriteLine($"Total value of turbo drones in stock: {droneTurbo.GetTotalValueInStock()}");

            Product droneStandard = new StandardDone();
            droneStandard.Price = 50;
            ((StandardDone)droneStandard).QuantityIncrement = 10;
            droneStandard.Add();
            droneStandard.Add();
            Console.WriteLine($"Total value of turbo drones in stock: {droneStandard.GetTotalValueInStock()}");

            Console.ReadKey();
        }
    }

    public class TurboDrone: Drone
    {

    }

    public class StandardDone: Drone
    {

    }
    //drone class inherits from the product class
    public class Drone : Product
    {
        //auto-implemented property
        public int QuantityIncrement { get; set; }

        public Drone()
        {
            QuantityIncrement = 1;
        }

        public override void Add()
        {
            _quantity = _quantity + QuantityIncrement;
        }

    }

    //desk class inherits from product class
    public class Desk : Product
    {
        public override void Add()
        {
            base.Add();
        }
        public Desk()
        {

        }
    }

    public class Product
    {
        protected int _quantity = 0;

        //auto-implemented property
        public decimal Price { get; set; }

        public Product()
        {

        }

        public virtual void Add()
        {
            _quantity++;
        }

        public void Remore()
        {
            if (_quantity > 0)
                _quantity--;
        }

        public decimal GetTotalValueInStock()
        {
            return _quantity * Price;
        }

    }

    
}
