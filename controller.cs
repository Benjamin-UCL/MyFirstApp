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
            Console.WriteLine("This is a menu");
            pressAnyKey();
            return 'd';
        }

        static public void router(char selection)
        {
            switch (selection)
            {
                case '0':
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
