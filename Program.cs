using System;
using System.Linq.Expressions;

namespace Benjamin_CarApp
{

    //public static class menu
    //{
    //    

    //    public static void handel(char code)
    //    {
    //        switch (code)
    //        {
    //            case 'R':

    //                Car myCar = new Car();

    //                break;


    //            case 'P':

    //                Console.WriteLine("Print car");

    //                break;


    //            case 'V':

    //                Console.WriteLine("View all cars");
                    
    //                break;


    //            case 'D':

    //                Console.WriteLine("Drive car");
                    
    //                break;


    //            case 'Q':

    //                return;


    //            default:
                    
    //                Console.WriteLine("Try again");
                    
    //                break;
    //        }
    //        handel(prompt());
    //    }
    //} 

    //public static class response
    //{
    //    public static void print(string[] list)
    //    {
    //        Console.WriteLine();
    //        Console.WriteLine();
    //        foreach (var item in list)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //public class Car
    //{
    //    private string brand;
    //    private string model;
    //    private int year = 0000;
    //    private bool acceptedYear = false;
    //    private char geartype = '0';
    //    private bool acceptedgeartype = false;
    //    private char fule = '0';
    //    private bool acceptedFuletype = false;
    //    private float miles = 0;
    //    private float milage = 0;

    //    public Car()
    //    {
    //        Console.Write("Brand: ");
    //        brand = Console.ReadLine();
    //        Console.Write("Model: ");
    //        model = Console.ReadLine();

    //        // year validation
    //        while (!acceptedYear)
    //        {
    //            int err = 0;

    //            Console.Write("Year: ");
    //            year = int.Parse(Console.ReadLine());

    //            if (year == null) { err++; }
    //            if (year > int.Parse(DateTime.Now.ToString("yyyy"))) { err++; }
    //            if (year < 999) { err++; }

    //            if (err == 0) { acceptedYear = true; }
    //        }

    //        //geartype validation
    //        while (!acceptedgeartype)
    //        {
    //            Console.Write("type ((A)utomatic/(M)anual): ");
    //            geartype = char.ToUpper(Console.ReadLine()[0]);

    //            if (geartype == 'M' || geartype == 'A') { acceptedgeartype = true; }
    //        }

    //        while (!acceptedFuletype)
    //        {
    //            Console.Write("brandstof type ((B)enzin/(D)isel): ");
    //            fule = char.ToUpper(Console.ReadLine()[0]);

    //            if (fule == 'D' || fule == 'B') { acceptedFuletype = true; }
    //        }

    //        Console.Write("Km p/l: ");
    //        milage = float.Parse(Console.ReadLine());
    //        Console.Write("kilometertæller: ");
    //        miles = float.Parse(Console.ReadLine());
    //    }

    //    public void print()
    //    {
    //        string lineBrand = String.Format("{0,-15}{1, 15}", "Brand:", brand);
    //        string lineModel = String.Format("{0,-15}{1, 15}", "Model:", model);
    //        string lineGear = String.Format("{0,-15}{1, 15}", "type:", geartype);
    //        string lineYear = String.Format("{0,-15}{1, 15}", "År:", year);
    //        string lineFuletype = String.Format("{0,-15}{1, 15}", "Brændstof:", fule);
    //        string lineMilage = String.Format("{0,-15}{1, 15}", "km/l:", milage);
    //        string lineMiles = String.Format("{0,-15}{1, 15}", "km:", miles);

    //        string[] res = { "___________OVERVIEW___________", lineBrand, lineModel, lineGear, lineYear, lineFuletype, lineMilage, lineMiles };

    //        response.print(res);
    //    }

    //    public void drive() { 
        



    //        Console.WriteLine();
    //        Console.WriteLine();
    //        // spørg køretur
    //        Console.Write("Ønskede distance (km): ");
    //        float trip = float.Parse(Console.ReadLine());
    //        miles = miles + trip;

    //        // pris
    //        float benzinPris = 12.7F;
    //        float diselPris = 10.57F;

    //        float brandstofspris = benzinPris;
    //        if (fule != "B"[0]) { brandstofspris = diselPris; }

    //        float liter = trip / milage;
    //        float pris = liter * benzinPris;



    //        // Print kvitering
    //        string details = trip + " km af " + benzinPris + "kr/l";
    //        string subtotal = (pris/trip) + " pr. km";
    //        string lineTripTotal = String.Format("{0,-15}{1, 15}", "Total kr:", pris);


    //        string[] res = { "__________KVITERING__________", details, subtotal, lineTripTotal };

    //        response.print(res);

    //    }
    //}



    internal class Program
    {
    
        // Finished
        static Char menu()
        {
        Console.WriteLine("SELECT ACTION");
            Console.WriteLine("(R)egister car");
            Console.WriteLine("(P)rint car");
            Console.WriteLine("(V)iew all cars");
            Console.WriteLine("(D)rive");

            return Char.ToUpper(Console.ReadLine()[0]);
        }


        // Work in progress
        static void controller(Char input) 
        {
            Console.WriteLine(input);
        }


        // Not started
        static bool isPalendrom(string input)
        { 
            // revers string
            // check reveresed string against string
            // return true if match
            return true;
        }

        static void print(string[] arr) 
        { 
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        

        // Main program thred
        static void Main(string[] args)
        {
            controller(menu());

        }
    }
}










