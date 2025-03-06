using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benjamin_CarApp
{
    internal class Car
    {
        private string owner;
        private string brand;
        private string model;
        private int productionYear;
        private char fuleType;
        private char gearType;
        private double milesDriven;
        private double milesPrUnit;
        private bool engienRunning = false;

        public Car(String owner_input, String brand_input, String model_input, int productionYear_input, Char fuleType_input, Char gearType_input, Double milesDriven_input, Double milesPrUnit_input)
        {
            owner = owner_input;
            brand = brand_input;
            model = model_input;
            productionYear = productionYear_input;
            fuleType = fuleType_input;
            gearType = gearType_input;
            milesDriven = milesDriven_input;
            milesPrUnit = milesPrUnit_input;
        }

        public bool drive(Double distance)
        {

            if (!engienRunning)
            {
                Console.WriteLine("Start engien first.");
                return false;
            }

            if (distance > 0)
            {
                milesDriven += distance;
            }
            controller.pressAnyKey();

            return true;
        }

        public void printDetails() 
        {
            Console.WriteLine("___________DETAILS____________");
            Console.WriteLine(String.Format("{0,-15}{1, 15}", "Brand:", brand));
            Console.WriteLine(String.Format("{0,-15}{1, 15}", "Model:", model));
            Console.WriteLine(String.Format("{0,-15}{1, 15}", "Owner:", owner));
            Console.WriteLine(String.Format("{0,-15}{1, 15}", "Year:", productionYear));
            Console.WriteLine(String.Format("{0,-15}{1, 15}", "Fule Type:", fuleType));
            Console.WriteLine(String.Format("{0,-15}{1, 15}", "Gear Type:", gearType));
            Console.WriteLine(String.Format("{0,-15}{1, 15}", "Miles:", milesDriven));
            Console.WriteLine(String.Format("{0,-15}{1, 15}", "Miles Pr./Unit:", milesPrUnit));
        }

        public void turnOnEngien()
        {
            engienRunning = true;
        }

        public void turnOfEngien()
        {
            engienRunning = false;
        }

        public double calcTripPrice(double distance, double fulePrice)
        {
            return distance / milesPrUnit * fulePrice;
        }
    }
}
