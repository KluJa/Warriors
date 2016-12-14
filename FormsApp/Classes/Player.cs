using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretorians
{
    public class Player
    {
        public string Name { get; set; }
        protected int hitPoints;
        protected Random cube;
        protected int fortune;

        public int HitPoints
        {
            get { return hitPoints; }
            set { hitPoints = value; }
        }

        public virtual void Damage (int hitPoints) { }






    }
}
