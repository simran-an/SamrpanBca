using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamrpanBca
{
    public class StdMarksCal
    {
        int total = 300;
        public double Calculatepercentage(double Dotnet, double mis, double cn)
        {
            double marks_obtained = Dotnet + mis + cn;
            double percentage = (marks_obtained / total) * 100;
            return percentage;

        }
        /* creating function
         * public  calculatepercentage (par1 , par2, par3)
         * double marks_obtained = Dotnet + mis + cn;
         * calculatepercentage()
         * */

    }
}
