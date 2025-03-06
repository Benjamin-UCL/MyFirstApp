using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Benjamin_CarApp
{
   
    internal class Program
    {
        public static bool isRunning = true;

        // depricated code
        //static private float gasPrize = 12.72f;
        //static private string owner;
        //static private string brand;
        //static private string model;
        //static private int year = 0000;
        //static private bool acceptedYear = false;
        //static private char geartype = '0';
        //static private bool acceptedgeartype = false;
        //static private char fule = '0';
        //static private bool acceptedFuletype = false;
        //static private float miles = 0;
        //static private float milage = 0;



        //// Finished methods
        //static Char menu()
        //{
        //Console.WriteLine("SELECT ACTION");
        //    //Console.WriteLine("(R)egister car");
        //    //Console.WriteLine("(P)rint car");
        //    //Console.WriteLine("(U)pdate gas price");
        //    //Console.WriteLine("(S)how gas price");
        //    ////Console.WriteLine("(V)iew all cars");
        //    //Console.WriteLine("(D)rive");
        //    //Console.WriteLine("(Q)uit");

        //    return Char.ToUpper(Console.ReadLine()[0]);
        //}

        //static void controller(Char input) 
        //{
        //    switch (input)
        //    {
        //        //case 'R':
        //        //    addCar();
        //        //    break;
        //        //case 'D':
        //        //    drive();
        //        //    break;

        //        //case 'P':
        //        //    //viewCar();
        //        //    break;

        //        //case 'Q':
        //        //    isRunning = false;
        //        //    break;

        //        //case 'U':
        //        //    updateGasprice();
        //        //    break;

        //        //case 'S':
        //        //    showGasprice();
        //        //    break;

        //        default:
        //            break;
        //    }
        //    pressAnyKey();
        //    Console.Clear();
        //}
        
        //static void pressAnyKey() 
        //{
        //    Console.WriteLine("Press any key to return");
        //    Console.ReadKey();
        //}

        //static void addCar() 
        //{
        //    Console.Write("Owner name: ");
        //    owner = Console.ReadLine();
            
        //    Console.Write("Brand: ");
        //    brand = Console.ReadLine();
            
        //    Console.Write("Model: ");
        //    model = Console.ReadLine();

        //    // year validation
        //    while (!acceptedYear)
        //    {
        //        int err = 0;

        //        Console.Write("Year: ");
        //        year = int.Parse(Console.ReadLine());

        //        if (year == null) { err++; }
        //        if (year > int.Parse(DateTime.Now.ToString("yyyy"))) { err++; }
        //        if (year < 1800) { err++; }

        //        if (err == 0) { acceptedYear = true; }
        //    }

        //    //geartype validation
        //    while (!acceptedgeartype)
        //    {
        //        Console.Write("type ((A)utomatic/(M)anual): ");
        //        geartype = char.ToUpper(Console.ReadLine()[0]);

        //        if (geartype == 'M' || geartype == 'A') { acceptedgeartype = true; }
        //    }

        //    while (!acceptedFuletype)
        //    {
        //        Console.Write("brandstof type ((B)enzin/(D)isel): ");
        //        fule = char.ToUpper(Console.ReadLine()[0]);

        //        if (fule == 'D' || fule == 'B') { acceptedFuletype = true; }
        //    }

        //    Console.Write("Km p/l: ");
        //    milage = float.Parse(Console.ReadLine());

        //    Console.Write("kilometertæller: ");
        //    miles = float.Parse(Console.ReadLine());
            
          
        //}

        //static void print(string[] arr) 
        //{ 
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //static void drive()
        //{
        //    Console.Write("How fare do you want to drive: ");
        //    float distance  = float.Parse(Console.ReadLine());
        //    float newMilage = addMilage(distance);
        //    float prize = ( gasPrize / milage) * distance; 

        //    string details = distance + " km of " + gasPrize + "dkk/l";
        //    string subtotal = (prize / distance) + " pr. km";
        //    string lineTripTotal = String.Format("{0,-15}{1, 15}", "Total dkk:", prize);
        //    string Update = String.Format("{0,-15}{1, 15}", "New milage:", newMilage);

        //    string[] res = { "___________RECIPT____________", details, subtotal, lineTripTotal, Update };

           

        //    print(res);
        //    if (isPalendrom(newMilage.ToString("0000000000").TrimStart(new Char[] { '0' })))
        //    {
        //        string[] pal = { "Hey, thats a palendrome!" };
        //        print( pal );
        //    }
        //}

        //static float addMilage(float distance)
        //{
        //    miles = miles + distance;
        //    return miles;
        //}

        //static void updateGasprice()
        //{
        //    Console.Write("Enter new gas price: ");
        //    float oldGasprice = gasPrize;
        //    gasPrize = float.Parse(Console.ReadLine());

        //    string line = "Gas price updated from " + oldGasprice  + " dkk/l to " + gasPrize + " dkk/l."; 
        //    string[] update = {"_______UPDATE________" , line} ;
        //    print(update);
        //}

        //static void showGasprice()
        //{
        //    string line = "Gas price are curently at " + gasPrize + " dkk/l.";
        //    string[] show = { "_____CURRENT GAS PRICE______", line };
        //    print(show);
        //}

        //static bool isPalendrom(string input)
        //{
        //    char[] charArray = input.ToCharArray();
        //    Array.Reverse(charArray);            
        //    string revInput = new string(charArray);

        //    //Console.WriteLine(revInput);
        //    //Console.WriteLine(input);

        //    if (input == revInput)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }         
        //}

        


        // Main program thred
     
        
        static void Main(string[] args)
        {
            Car myCar = new Car("Benjamin", "Ford", "Escort", 2006, 'D', 'M', 69243.347, 17.3);

            myCar.printDetails();
            controller.pressAnyKey();
            Console.WriteLine(myCar.calcTripPrice(132.9, 12.32));
            myCar.drive(132.9);
            myCar.printDetails();
            myCar.turnOnEngien();
            myCar.drive(132.9);
            myCar.printDetails();
            myCar.turnOfEngien();

            //while (isRunning)
            //{
            //    controller.router(controller.menu());
            //}
        }
    }
}










