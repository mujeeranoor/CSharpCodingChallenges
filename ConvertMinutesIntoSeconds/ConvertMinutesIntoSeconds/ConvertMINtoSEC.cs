using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMinutesIntoSeconds
{
    class ConvertMINtoSEC
    {
        /// <summary>
        /// Converts minutes into seconds
        /// </summary>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public int convert(int minutes)
        {
            int m = minutes * 60;
            Console.WriteLine(m);
            return minutes;
        }
    }
}
