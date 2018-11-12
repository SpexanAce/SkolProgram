using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvaLiteDÅ
{
    class Program
    {
        static void Main(string[] args)
        {

            //string FirstName = "Bill";
            //string LastName = " Selander";

            Console.Write("Vad heter du?");
            string FullName = Console.ReadLine();

            
            //string FullName = FirstName + LastName;


            Console.WriteLine ("Gomorron " + FullName);
            Console.ReadLine();

            DateTime dagensDatum = new DateTime();
            dagensDatum = DateTime.Now;

            Console.WriteLine("När är du född?");
            string född = Console.ReadLine();

            DateTime borndate=Convert.ToDateTime(född);

 

            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan alder = dagensDatum - borndate;

            int alderInYears = (zeroTime + alder).Year - 1;
            Console.WriteLine(alderInYears);
            Console.ReadLine();



















        }
    }
}
