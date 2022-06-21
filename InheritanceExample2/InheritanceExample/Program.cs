using System;
using System.Linq;
using System.Collections.Generic;
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
            Console.WriteLine($"Total value of standard drones in stock: {droneStandard.GetTotalValueInStock()}");


            Product desk2 = new Desk();
            ((Desk)desk2).ImportTaxPercentage = 2;
            desk2.Price = 100;
            desk2.Add();
            desk2.Add();
            Console.WriteLine($"Total value of desk2 in stock: {desk2.GetTotalValueInStock()}");

            /*
            Product[] products = new Product[3];
            products[0] = desk;
            products[1] = droneStandard;
            products[2] = droneTurbo;
            */

            List<Product> products = new List<Product>();
            products.Add(desk);
            products.Add(droneStandard);
            products.Add(droneTurbo);

            Console.WriteLine();
            Console.WriteLine("Stock Inventory Report");
            Console.WriteLine("______________________");
            Console.WriteLine();

            foreach(Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
            decimal grandTotalStockValues = products.Sum(p => p.GetTotalValueInStock());
            Console.WriteLine($"Grand total value of all products in stock: {grandTotalStockValues}");

            Console.ReadKey();
        }
    }

    public class TurboDrone: Drone
    {
        public override string ProductName
        {
            get
            {
                return "Turbo Drone";
            }
            set
            {

            }
        }
    }

    public class StandardDone: Drone
    {
        public override string ProductName
        {
            get
            {
                return "Standard Drone";
            }
            set
            {

            }
        }
    }
    //drone class inherits from the product class
    public class Drone : Product
    {
        //auto-implemented property
        public int QuantityIncrement { get; set; }
        public override string ProductName 
        {
            get
            {
                return "Drone";
            }
            set
            {

            }
        }


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
        //property
        public decimal ImportTaxPercentage { get; set; }
        public override string ProductName 
        {
            get
            {
                return "desk";
            }
            set
            {

            }
        }

        public override void Add()
        {
            base.Add();
        }
        public Desk()
        {

        }

        public override decimal GetTotalValueInStock()
        {
            decimal netTotal = base.GetTotalValueInStock() - ( base.GetTotalValueInStock() * (ImportTaxPercentage/100) );


            return netTotal;
        }
    }

    public abstract class Product
    {
        protected int _quantity = 0;

        //auto-implemented property
        public decimal Price { get; set; }

        public Product()
        {

        }

        //abstract property, if we delete the setter here, we can delete it from children classes that implement this property
        public abstract string ProductName { get; set; }

        public virtual void Add()
        {
            _quantity++;
        }

        public void Remove()
        {
            if (_quantity > 0)
                _quantity--;
        }

        public virtual decimal GetTotalValueInStock()
        {
            return _quantity * Price;
        }

        public override string ToString()
        {
            return $"Product Name: {ProductName}, Price: {Price}, Quantity: {_quantity}, Total Value: {GetTotalValueInStock()}";
        }

    }

    
}
