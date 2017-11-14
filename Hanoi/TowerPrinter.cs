using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hanoi
{
    public class TowerPrinter
    {
        public static void Print(Tower tower)
        {
            Console.WriteLine(BuildTowerContentAsString(tower));
        }

        protected static string BuildTowerContentAsString(Tower tower)
        {
            StringBuilder towerRepresentation = new StringBuilder("T:>> ");

            if (!tower.IsEmpty())
            {
                for (int i = 0; i < tower.Size(); i++)
                {
                    towerRepresentation.Append("[" + tower.At(i) + "] ");
                }
            }

            towerRepresentation.Append("=>>");
           
            return towerRepresentation.ToString();
        }
    }
}
