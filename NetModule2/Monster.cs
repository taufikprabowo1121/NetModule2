using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModule2
{
    public class Monster
    {
        private int _health;

        public int Health
        {
           get { return _health; }
           set { _health = value; }
        }
        public virtual void Attack()
        {
            Console.WriteLine("Enemy Attack");
        }
        public void MelarikanDiri()
        {
            Console.WriteLine("Enemy Escape");
        }
        /*
        public void Attack()
        {
            Console.WriteLine("Enemy Attack");
        }
        */

    }
}
