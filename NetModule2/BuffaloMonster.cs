using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModule2
{
    public class BuffaloMonster:LandMonster
    {
        //public int Health;
        public BuffaloMonster()
        {
              Health = 100;
        }
        public override void Attack()
        {
            Console.WriteLine("Buffalo butting");
        }
        public new void Escape()
        {
            Console.WriteLine("Buffalo escaping");
        }
    }
}
