using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Hanoi;

namespace HanoiTests
{
    public class TowerPrinterTestable : TowerPrinter
    {
        public static new string BuildTowerContentAsString(Tower tower)
        {
            return TowerPrinter.BuildTowerContentAsString(tower);
        }
    }

    public class TowerPrinterTest
    {
        public Tower MakeTestTower()
        {
            int size = 3;
            var tower = new Tower(size);

            tower.Push(1);
            tower.Push(2);
            tower.Push(3);

            return tower;
        }

        [Test]
        public void TowerPrinterShouldPrintTowerContent()
        {
            string expectedTowerRepresentation = "T:>> [1] [2] [3] =>>";
            var tower = MakeTestTower();

            Assert.AreEqual(expectedTowerRepresentation, TowerPrinterTestable.BuildTowerContentAsString(tower));
        }

        [Test]
        public void TowerPrinterShouldPrintEmptyTowerContent()
        {
            string expectedTowerRepresentation = "T:>> =>>";
            int dummySize = 3;
            var tower = new Tower(dummySize);

            Assert.AreEqual(expectedTowerRepresentation, TowerPrinterTestable.BuildTowerContentAsString(tower));
        }
    }
}
