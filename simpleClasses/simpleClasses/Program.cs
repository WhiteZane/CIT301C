using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleClasses
{
    enum TrafficLight
    {
        Red,
        RedAmber,
        Green,
        Amber
    };

    class Program
    {
        static void Main(string[] args)
        {
            Car mynewCar = new simpleClasses.Car();

            int car = 1995;
            mynewCar.Make = "Volvo";
            mynewCar.Model = "850";
            mynewCar.Year = car;
            mynewCar.Color = "Yellow";

<<<<<<< HEAD
            
=======
            ArrayList theBooks = new ArrayList();
>>>>>>> 369684e222fc63696fc4d4b2500343bb1c648181


            TrafficLight light;
            light = TrafficLight.Red;

            Console.WriteLine("{0} - {1} - {2} - {3}",
                mynewCar.Make,
                mynewCar.Year,
                mynewCar.Color, light);

            //double marketValueOfCar = DetermineMarketValue(mynewCar);
            Console.WriteLine("cars value {0:C}", mynewCar.DetermineMarketValue());

<<<<<<< HEAD
            

    Console.ReadLine();
=======
            Console.ReadLine();
>>>>>>> 369684e222fc63696fc4d4b2500343bb1c648181
        }
        private static double DetermineMarketValue(Car car)
        {
            double carValue = 100.0;

            //somedat come go online

            return carValue;
        }
    }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public double DetermineMarketValue()
            {
                double carValue = 100.0;
                if (this.Year > 1990)
                    carValue = 10000.00;
                else
                    carValue = 2000.0;



                //somedat come go online

                return carValue;
            }
        }

    }




