//Enrick De Munter 5ITN 9/10/2019 
/*vraag welk artikel
 * vraag aantal stuks
 * vraag eenheidsprijs
 * vraag of het een onderneming is 
 * zo ja moet de eenheidsprijs - btw
 * zo nee blijft de eenheidsprijs zoals het is
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_shop2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie
            string artikel;
            ushort aantal;
            decimal eenheidsprijs;
            bool onderneming;
            string input1, input2, input3, input4;
           

            //input
            //welk artikel is het
            Console.Write("welk artikel is het?: ");
            artikel = Console.ReadLine();

            //wat is het aantal artikelen
            input2 = Console.ReadLine();
            aantal = Convert.ToUInt16(input2);

            //wat is de eenheidsprijs
            input3 = Console.ReadLine();
            eenheidsprijs = Convert.ToUInt16(input3);

            //is het een bedrijf ja of nee
            input4 = Console.ReadLine();
            aantal = Convert.ToUInt16(input4);

            if (onderneming=j)
            {
                onderneming = true;
            }
            else
            {
                onderneming = false;
            }












        }
    }
}
