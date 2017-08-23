using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModule2
{
   public class Cockroach:AirMonster
    {
        public Cockroach()
        {
            Health = 80;
        }
        public override void Attack()
        {
            Console.WriteLine("Cockroach Beating");
        }
    }
}
