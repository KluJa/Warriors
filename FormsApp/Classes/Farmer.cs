using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretorians
{
    class Farmer : Player
    {
        protected int maxHitPoints;

        public virtual int Heal()
        {
            int healing = cube.Next(1, 3);
            return healing;
        }

        public virtual void Healing(int heal)
        {
            if ((hitPoints + heal) <= maxHitPoints)
            {
                hitPoints = hitPoints + heal;
            }
            else
            {
                hitPoints = maxHitPoints;
            }


        }
    }
}
