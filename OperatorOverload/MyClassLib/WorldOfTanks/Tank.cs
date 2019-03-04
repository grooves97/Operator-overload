using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        public int _ammunition { get; set; }
        public int _armorLevel { get; set; }
        public int _maneuverability { get; set; }

        Random rand = new Random(((int)DateTime.Now.Ticks));

        public Tank()
        {

            _ammunition = rand(0,100);
            _armorLevel = ;
            _maneuverability = ;
        }

        public static bool operator *(Tank obj1,Tank obj2)
        {
            int winnerObj1 = 0;
            int requiredQuantity = 2;
            if (obj1._ammunition > obj2._ammunition) ++winnerObj1;
            if (obj1._armorLevel > obj2._armorLevel) ++winnerObj1;
            if (obj1._maneuverability > obj2._maneuverability) ++winnerObj1;

            return winnerObj1 >= requiredQuantity;
        }
            
        public string GetTankStat()
        {
            string stats = "Ammunition = " + _ammunition.ToString() + " Armor level = " + _armorLevel.ToString() + " Maneuverability = " + _maneuverability.ToString();
            return stats;
        }

    }
}
