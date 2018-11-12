using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Skriv ett program där jag anger ett tal.
            //   Om talet är större än 5 och mindre än 10 så skrivs följande ut:
            //   Talet är 6,7,8 eller 9
            //     Console.WriteLine("Skriv ett tal mellan 1 och 10");
            //  int tal1 = Convert.ToInt32(Console.ReadLine());
            //  if (tal1 >= 6 && tal1 <= 9)
            //    Console.WriteLine("Talet är 6,7,8 eller 9");


            //Console.ReadLine();





            ////2.Skriv ett program där jag anger ett tal.
            ////   Om talet är större än 32 och mindre än 40 ELLER
            ////   om det är större än 82 och mindre än 90
            ////   så skrivs följande ut:
            ////       -”Talet är inom ramen”
            ////   annars så skrivs det ut att talet är ogiltigt

            //Console.WriteLine("Skriv ett tal mellan 1 och 100 som är inom den dolda ramen");
            //int tal2 = Convert.ToInt32(Console.ReadLine());
            //if (tal2 >= 32 && tal2 <= 40)
            //    Console.WriteLine("Talet är inom ramen");

            //else if (tal2 >= 82 && tal2 <= 90)
            //    Console.WriteLine("Talet är inom ramen");

            //else Console.WriteLine("Talet är ogiltigt");
            //Console.ReadLine();



            ////3.Skriv ett program där det skrivs ut följande när man matar in en ålder:
            ////     om ålder  0 - 12->barn skrivs ut
            ////     om ålder  13 - 19->ungdom skrivs ut
            ////     om ålder  20 - 64->vuxen skrivs ut
            ////     om ålder  65 -    ->pensionär skrivs ut

            //Console.WriteLine("Skriv in din ålder i siffror");

            //int ålder = Convert.ToInt32(Console.ReadLine());

            //if (ålder >= 0 && ålder <= 12)
            //    Console.WriteLine("Barn");

            //else if (ålder >= 13 && ålder <= 19)
            //    Console.WriteLine("Ungdom");

            //else if (ålder >= 20 && ålder <= 64)
            //    Console.WriteLine("Vuxen");

            //else Console.WriteLine("Pensionär");
            //Console.ReadLine();


            ////4.Skriv ett program där jag anger två tal.Sedan skrivs det ut
            ////   vilket tal som är störst, minst och differensen dem emellan.

            //Console.WriteLine("Skriv in 2 tal");
            //int tal01 = Convert.ToInt32(Console.ReadLine());
            //int tal02 = Convert.ToInt32(Console.ReadLine());
            //int biggest;
            //int smallest;
            //int differensen;


            //if (tal01 >= tal02)
            //{
            //    biggest = tal01;
            //    smallest = tal02;
            //    differensen = biggest - smallest;
            //    Console.WriteLine("Störst är:" + biggest + " minst är:" + smallest + " differensen är:" + differensen);
            //}

            //else if (tal02 >= tal01)
            //{ 
            //    biggest = tal02;
            //    smallest = tal01;
            //    differensen = biggest - smallest;
            //    Console.WriteLine("Störst är:" + biggest + " minst är:" + smallest + " differensen är:" + differensen);
            //}

            ////Console.WriteLine("Störst är:" + biggest + " minst är:" + smallest + " differensen är:" + differensen);
            //Console.ReadLine();




            //5.Översätt ett veckodagnummer till vilken veckodag i klartext det är
            //   t.ex. 1 = "Måndag", 2 = ”Tisdag” osv.
            //   Använd Switch - case satsen

            //int veckotal = Convert.ToInt32(Console.ReadLine());


            //switch (veckotal)
            //{
            //    case 1:
            //        Console.WriteLine("Måndag ");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tisdag");
            //        break;
            //    case 3:
            //        Console.WriteLine("Onsdag");
            //        break;
            //    case 4:
            //        Console.WriteLine("Torsdag");
            //        break;
            //    case 5:
            //        Console.WriteLine("Fredag");
            //        break;
            //    case 6:
            //        Console.WriteLine("Lördag");
            //        break;
            //    case 7:
            //        Console.WriteLine("Söndag");
            //        break;
            //    default:
            //        Console.WriteLine("Finns bara 7 veckodagar ");
            //        break;
            //}
            //Console.ReadLine();


            //6.Skriv ett program där jag anger ett datum och skriv sedan ut om det är idag, igår, i morgon, i framtiden eller har varit.

            //DateTime Datum;
            //Console.WriteLine("Skriv ett datum dd-mm-åå");
            //Datum = DateTime.Parse(Console.ReadLine());

            //if (Datum == DateTime.Today.AddDays(1))
            //{
            //    Console.WriteLine("Tomorrow");
            //}

            //if (Datum == DateTime.Today.AddDays(-1))
            //{
            //    Console.WriteLine("Yesterday");
            //}

            //if (Datum == DateTime.Today)
            //{
            //    Console.WriteLine("Idag");
            //}

            //if (Datum > DateTime.Today)
            //{
            //    Console.WriteLine("Framtiden");
            //}

            //if (Datum < DateTime.Today)
            //{
            //    Console.WriteLine("Förr i Tiden");
            //}

            //Console.ReadLine();


            //7.Mata in två textsträngar, jämför dessa om de är lika.



            //Svår

            //8.Skriv ett program där jag anger veckonummer och dagnummer och
            //  där jag får tvätta bara på udda veckor och jämna dagnummer(dagdatum).
            //   Modulo operator ger vad som blir resten vid en division
            //   Syntax(talet % 2) ger 0 om jämt tal





            //LOOOOPAAAAR

            //1.Skriv ett program som skriver ut en valfri textsträng 5 gånger, prova att använda först for-loopen, sedan while-loopen och sedan do -loopen.

            //Console.WriteLine("Skriv en mening");
            //string mening;
            //mening = Console.ReadLine();

            //int number = 5;

            //for (int i = 0; i < number; i++)
            //    Console.WriteLine(mening);


            //Console.ReadLine();


            //2.Skriv ett program där man anger en textsträng samt också hur många
            //gånger den skall skrivas ut, använd valfri loop.

            //Console.WriteLine("Skriv en mening");
            //string mening;
            //mening = Console.ReadLine();

            //Console.WriteLine("Skriv hur många gånger du vill se meningen");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //    Console.WriteLine(mening);


            //Console.ReadLine();

            //3.Skriv ett program som skriver ut en multiplikationstabell, valfri storlek.

            Console.WriteLine("Vilken gångertabbel vill du se?");
            int tal = int.Parse(Console.ReadLine());

            int n = tal;
            int i = 1;
            while (n <= (tal * 10))
            {
                Console.WriteLine("{0} x {1} = {2}", i,tal, n);
                n = n + tal;
                i++;
            }
            Console.ReadLine();

            

            //4.Skriv ett program som skriver ut en textsträng lodrätt

            //5.Skriv ett program där man matar in en valfri text, programmet skall sedan vända på texten. t.ex. "majonäs" blir "sänojam"

            //6.Skriv ett program som räknar fram och skriver ut alla primtal upp till 100.Ett primtal är ett naturligt tal, som är större än 1 och som inte har några andra positiva delare än 1 och talet självt.

            //7.Skriv ett program som först läser in en textsträng, sedan ska programmet fråga efter ett tecken(char). Programmet skall sedan räkna ut hur många gånger detta tecken förekommer i textsträngen.



        }
    }
}
