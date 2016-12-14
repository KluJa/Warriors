using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretorians
{
    class Mage : Farmer
    {
        

        //Konstruktor
        public Mage()
        {
            this.cube = new Random();
            this.fortune = 3;
            this.hitPoints = 10;
            this.maxHitPoints = 10;
        }


        //Pretizeny konstruktor
        public Mage(int customHitPoints)
        {
            this.cube = new Random();
            this.fortune = 3;
            this.hitPoints = customHitPoints;
            this.maxHitPoints = customHitPoints;
        }

        //Pretizeny Konstruktor jmeno
        public Mage(string name)
        {
            this.Name = name;
            this.cube = new Random();
            this.fortune = 3;
            this.hitPoints = 10;
            this.maxHitPoints = 10;
        }

        //Pretizeny Konstruktor Jmeno + Zivot
        public Mage(string name, int customHitPoints )
        {
            this.Name = name;
            this.cube = new Random();
            this.fortune = 3;
            this.hitPoints = customHitPoints;
            this.maxHitPoints = customHitPoints;

        }

        public override void Damage (int hitPoints)
        {
            this.hitPoints -= hitPoints;
        }
        // Utok
        public int Attack()
        {
            int attack;
            attack = cube.Next(1, 4);
            return attack;
        }

        public void Defense(int hitPoints) {
            int defense;
            defense = cube.Next(0, 3);
            Damage(hitPoints - defense);
        }

        

    }
}
