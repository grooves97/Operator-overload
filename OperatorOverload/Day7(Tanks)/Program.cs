using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WorldOfTanks;

namespace Day7_Tanks_
{
    public class Program
    {
        static void Main(string[] args)
        {
            int tankAmount = 5, battles = 5;
            Tank[] t34 = new Tank[tankAmount];
            Tank[] pantera = new Tank[tankAmount];

            for (int i = 0; i < tankAmount; i++)
            {
                t34[i] = new Tank();
                pantera[i] = new Tank();
            }

            bool[] winner = new bool[battles];

            try
            {
                for (int i = 0; i < tankAmount; i++)
                {
                    if (t34[i]._ammunition == 0 || t34[i]._armorLevel == 0 || t34[i]._maneuverability == 0 ||
                        pantera[i]._ammunition == 0 || pantera[i]._armorLevel == 0 || pantera[i]._maneuverability == 0) { throw new Exception(); break; }
                    else
                        winner[i] = t34[i] * pantera[i];
                }
            }
            catch
            {
                Console.WriteLine("The battles was stopped, since one or more participant are disqualification");
            }

            for (int i = 0; i < battles; i++)
            {
                if (winner[i])
                    Console.WriteLine("Pantera has won!!!!!!!");
                else
                    Console.WriteLine("T-34 has won!!!!!!!!!!");
            }
            Console.WriteLine(t34[1].GetTankStat());

            Console.ReadLine();
        }
    }
}
