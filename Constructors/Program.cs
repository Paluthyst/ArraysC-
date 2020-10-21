using System;

namespace Constructors
{
    class Cars
    {
        public string carManufacturer;
        public int modelDate;
        public string carColor;

        public Cars(string manufacturer, string color, int date)
        {
            carManufacturer = manufacturer;
            carColor = color;
            modelDate = date;
        }
        
        
        static void Main(string[] args)
        {
            Cars toyotaTacoma = new Cars("Toyota", "silver", 2018);
            Console.WriteLine("My car is a " + toyotaTacoma.carManufacturer + " and was made in " + toyotaTacoma.modelDate + ". It's color is " + toyotaTacoma.carColor + ".");
            
        }
    }
}
