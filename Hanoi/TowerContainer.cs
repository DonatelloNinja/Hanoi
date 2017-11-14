using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class TowerContainer
    {
        private List<Tower> m_towers;

        public TowerContainer()
        {
            m_towers = new List<Tower>();
        }

        public void Add(Tower tower)
        {
            m_towers.Add(tower);
        }

        public Tower GetTower(int index)
        {
            return m_towers[index];
        }

        public int Size()
        {
            return m_towers.Count();
        }
    }
}
