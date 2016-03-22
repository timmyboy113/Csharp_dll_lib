using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lib
{
    public class Test
    {
        public static string hello_world()
        {
            return ("Hello World");
        }

        public static string echo(string to_echo)
        {
            return (to_echo);
        }

        public static string add(int numer_one, int number_two)
        {
            int ergebnis = numer_one + number_two;
            return (ergebnis.ToString());          
        }
    }
}
