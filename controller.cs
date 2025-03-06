using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benjamin_CarApp
{
    static class controller
    {
        static public char menu() 
        {
            Console.WriteLine("(D)rive");
            Console.WriteLine("(V)iew car");
            Console.WriteLine("(C)alculate trip");

            return Char.ToUpper(Console.ReadLine()[0]);
        }

        static public void router(char selection)
        {
            switch (selection)
            {
                case 'D':
                    Console.Write("Distance: ");
                    Console.ReadLine();
                    //myCar.drive(distance); // does not work
                    break;
                
                case 'V':
                    
                    break;
                
                case 'C':
                    
                    break;
                
                
                default:
                    Console.WriteLine("Smthing selected -> do somthing");
                    break;
            }
            pressAnyKey();
            Console.Clear();
        }

        static public void pressAnyKey()
        {
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
        }
    }
}
