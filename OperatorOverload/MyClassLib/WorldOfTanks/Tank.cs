using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        public int Ammunition { get; set; }
        public int ArmorLevel { get; set; }
        public int Maneuverability { get; set; }


        public Tank(int armor,int maneuverability,int ammuniton)
        {
            int maxValue = 100;
            ArmorLevel=armor%maxValue;
            Maneuverability = maneuverability%maxValue;
            Ammunition = ammuniton % maxValue;
        }

        public static bool operator *(Tank obj1,Tank obj2)
        {
            int winnerObj1 = 0;
            int requiredQuantity = 2;
            if (obj1.Ammunition > obj2.Ammunition) ++winnerObj1;
            if (obj1.ArmorLevel > obj2.ArmorLevel) ++winnerObj1;
            if (obj1.Maneuverability > obj2.Maneuverability) ++winnerObj1;

            return winnerObj1 >= requiredQuantity;
        }
            
        public string GetTankStat()
        {
            string stats = "Ammunition = " + Ammunition.ToString() + " Armor level = " + ArmorLevel.ToString() + " Maneuverability = " + Maneuverability.ToString();
            return stats;
        }

    }
}
