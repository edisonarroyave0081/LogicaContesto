using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared
{
    public class Class1
    {
        public static int  GetInt(string message) { 
        Console.WriteLine(message);
            var numberString=Console.ReadLine();
            var number = 0;
            if (int.TryParse(numberString, out number))
            {
                return number;
            }
            return 0;
        }
    }
}
 