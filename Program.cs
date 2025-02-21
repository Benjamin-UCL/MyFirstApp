using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Benjamin_CarApp
{
   
    internal class Program
    {

        static public bool isRunning = true;

        static private float gasPrize = 12.72f;
        static private string owner;
        static private string brand;
        static private string model;
        static private int year = 0000;
        static private bool acceptedYear = false;
        static private char geartype = '0';
        static private bool acceptedgeartype = false;
        static private char fule = '0';
        static private bool acceptedFuletype = false;
        static private float miles = 0;
        static private float milage = 0;



        // Finished methods
        static Char menu()
        {
        Console.WriteLine("SELECT ACTION");
            Console.WriteLine("(R)egister car");
            Console.WriteLine("(P)rint car");
            Console.WriteLine("(U)pdate gas price");
            Console.WriteLine("(S)how gas price");
            //Console.WriteLine("(V)iew all cars");
            Console.WriteLine("(D)rive");
            Console.WriteLine("(Q)uit");

            return Char.ToUpper(Console.ReadLine()[0]);
        }

        static void controller(Char input) 
        {
            switch (input)
            {
                case 'R':
                    addCar();
                    break;
                case 'D':
                    drive();
                    break;

                case 'P':
                    viewCar();
                    break;

                case 'Q':
                    isRunning = false;
                    break;

                case 'U':
                    updateGasprice();
                    break;

                case 'S':
                    showGasprice();
                    break;

                default:
                    break;
            }
            Console.Clear();
        }
        
        static void pressAnyKey() 
        {
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
        }

        static void addCar() 
        {
            Console.Write("Owner name: ");
            owner = Console.ReadLine();
            
            Console.Write("Brand: ");
            brand = Console.ReadLine();
            
            Console.Write("Model: ");
            model = Console.ReadLine();

            // year validation
            while (!acceptedYear)
            {
                int err = 0;

                Console.Write("Year: ");
                year = int.Parse(Console.ReadLine());

                if (year == null) { err++; }
                if (year > int.Parse(DateTime.Now.ToString("yyyy"))) { err++; }
                if (year < 1800) { err++; }

                if (err == 0) { acceptedYear = true; }
            }

            //geartype validation
            while (!acceptedgeartype)
            {
                Console.Write("type ((A)utomatic/(M)anual): ");
                geartype = char.ToUpper(Console.ReadLine()[0]);

                if (geartype == 'M' || geartype == 'A') { acceptedgeartype = true; }
            }

            while (!acceptedFuletype)
            {
                Console.Write("brandstof type ((B)enzin/(D)isel): ");
                fule = char.ToUpper(Console.ReadLine()[0]);

                if (fule == 'D' || fule == 'B') { acceptedFuletype = true; }
            }

            Console.Write("Km p/l: ");
            milage = float.Parse(Console.ReadLine());

            Console.Write("kilometertæller: ");
            miles = float.Parse(Console.ReadLine());
            
          
        }
        
        static void viewCar() 
        {
            string lineowner = String.Format("{0,-15}{1, 15}", "Owner:", owner);
            string lineBrand = String.Format("{0,-15}{1, 15}", "Brand:", brand);
            string lineModel = String.Format("{0,-15}{1, 15}", "Model:", model);
            string lineGear = String.Format("{0,-15}{1, 15}", "type:", geartype);
            string lineYear = String.Format("{0,-15}{1, 15}", "År:", year);
            string lineFuletype = String.Format("{0,-15}{1, 15}", "Brændstof:", fule);
            string lineMilage = String.Format("{0,-15}{1, 15}", "km/l:", milage);
            string lineMiles = String.Format("{0,-15}{1, 15}", "km:", miles);

            string[] res = { "___________OVERVIEW___________", lineowner, lineBrand, lineModel, lineGear, lineYear, lineFuletype, lineMilage, lineMiles };
            print(res);
        }

        static void print(string[] arr) 
        { 
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            pressAnyKey();
        }

        static void drive()
        {
            Console.Write("How fare do you want to drive: ");
            float distance  = float.Parse(Console.ReadLine());
            float newMilage = addMilage(distance);
            float prize = ( gasPrize / milage) * distance; 

            string details = distance + " km of " + gasPrize + "dkk/l";
            string subtotal = (prize / distance) + " pr. km";
            string lineTripTotal = String.Format("{0,-15}{1, 15}", "Total dkk:", prize);
            string Update = String.Format("{0,-15}{1, 15}", "New milage:", newMilage);

            string[] res = { "___________RECIPT____________", details, subtotal, lineTripTotal, Update };
            print(res);
        }

        static float addMilage(float distance)
        {
            miles = miles + distance;
            return miles;
        }

        static void updateGasprice()
        {
            Console.Write("Enter new gas price: ");
            float oldGasprice = gasPrize;
            gasPrize = float.Parse(Console.ReadLine());

            string line = "Gas price updated from " + oldGasprice  + " dkk/l to " + gasPrize + " dkk/l."; 
            string[] update = {"_______UPDATE________" , line} ;
            print(update);
        }

        static void showGasprice()
        {
            string line = "Gas price are curently at " + gasPrize + " dkk/l.";
            string[] show = { "_____CURRENT GAS PRICE______", line };
            print(show);
        }

        // Work in progress

        static bool isPalendrom(string input)
        { 
            // revers string
            // check reveresed string against string
            // return true if match
            return true;
        }

        static void printCar(int id) 
        { 
        
        }
        


        // Main program thred
        static void Main(string[] args)
        {
            while (isRunning)
            {

                Char menuSelection = menu();
                controller(menu());
            }
        }
    }
}










