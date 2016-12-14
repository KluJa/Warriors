using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretorians
{
    class Pretorian : Player
    {
        public override void Damage(int hitPoints)
        {
            this.hitPoints -= hitPoints * cube.Next(fortune);
        }

        public int Attack()
        {
            int attack;
            attack = cube.Next(1, 6);
            return attack;
        
        }
        
        public Pretorian()
        {
            this.cube = new Random();
            this.fortune = 5;
        }


    }
}
