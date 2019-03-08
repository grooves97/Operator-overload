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
            int tankAmount = 5, battles = 5, characterisicsQuantity = 3, totalPanzerAmount = 10;
            Tank[] t34 = new Tank[tankAmount];
            Tank[] pantera = new Tank[tankAmount];
            byte[] rndArray = new byte[characterisicsQuantity * totalPanzerAmount];

            Random randomArray = new Random();
            randomArray.NextBytes(rndArray);

            for (int i = 0, j = 0; i < tankAmount; i++)
            {
                pantera[i] = new Tank(rndArray[j], rndArray[++j], rndArray[++j]);
                t34[i] = new Tank(rndArray[++j], rndArray[++j], rndArray[++j]);
            }

            bool[] winner = new bool[battles];

            try
            {
                for (int i = 0; i < tankAmount; i++)
                {
                    if (t34[i].Ammunition == 0 || t34[i].ArmorLevel == 0 || t34[i].Maneuverability == 0 ||
                        pantera[i].Ammunition == 0 || pantera[i].ArmorLevel == 0 || pantera[i].Maneuverability == 0) { throw new Exception(); break; }
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
