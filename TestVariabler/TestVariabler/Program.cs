using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVariabler
{
    class Program
    {
        static void Main(string[] args)
        {

            //int Antal = 44;
            //int antal = 33;

            //Console.WriteLine("Variablen Antal har värde : " + Antal + ". Medan variabeln antal har : " + antal);
            //Console.ReadLine();

            //int a;
            //double b;

            //a = 5;
            //b = 2;

            //double c = a / b;

            //int dummy5 = 0;

            //Console.WriteLine(c);
            //Console.ReadLine();

            //char baraEttTecken = '?';
            //char ettAnnatTecken = '?';

            //bool varDetSamma = baraEttTecken.Equals(ettAnnatTecken);
            //int dummy8 = 0;

            ////Console.WriteLine (c);
            ////Console.ReadLine();

            ////Variabeltyp string - textsträngar
            //string alfabetet;
            //alfabetet = "abcdefghijklmnopqrstuvwxyzåäö";
            //int antalBokstäver = alfabetet.Length;
            //string delAvAlfabetet1 = alfabetet.Substring(10);
            //string delAvAlfabetet2 = alfabetet.Substring(8, 5);

            //string firstName = "Bill";
            ////string lastName = "Selander";
            ////string fullName = firstName + " " + lastName;

            ////Console.WriteLine("Hallå " + fullName);
            ////Console.ReadLine();

            //string text1 = "fy och blä";
            //string text2 = "cccccccc";

            //char t1 = 'f';
            //char t2 = 'g';

            //bool lika = text1.Equals(text2);
            //int likaTkn = t1.CompareTo(t2);

            //Console.WriteLine(lika);
            //Console.WriteLine(likaTkn);
            //Console.ReadLine();


            //string a = likaTkn.ToString;
            //string b = firstName;

            //int kvadrat = 81;
            //double rot = Math.Sqrt(kvadrat);

            //Console.WriteLine("Kvadratroten ur " + kvadrat + " är " + rot);
            //Console.ReadLine();



            DateTime dagensDatum = new DateTime();
            dagensDatum = DateTime.Now;

            DateTime minFodelsedag = new DateTime(1991, 04, 14);

            Console.WriteLine(dagensDatum);
            Console.WriteLine(minFodelsedag);
            Console.ReadLine();

            DateTime zeroTime=new DateTime(1, 1, 1);
            TimeSpan alder = dagensDatum - minFodelsedag;
            int alderInYears = (zeroTime + alder).Year - 1;
            Console.WriteLine(alderInYears);
            Console.ReadLine();







        }
    }
}
