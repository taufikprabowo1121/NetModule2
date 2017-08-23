using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModule2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
             Keyword Virtual, Override
            BuffaloMonster buffalo = new BuffaloMonster();
            (buffalo as Monster).Attack();
            (buffalo as BuffaloMonster).Attack();
            (buffalo as Monster).MelarikanDiri();
            (buffalo as BuffaloMonster).Escape();
            Console.ReadKey();
            
             

            /*constructors
            BuffaloMonster buffalo1, buffalo2;

            buffalo1 = new BuffaloMonster();
            buffalo2 = new BuffaloMonster();
            Console.WriteLine("bufalo1 health = {0}", buffalo1.Health);
            Console.WriteLine("bufalo1 health = {0}", buffalo2.Health);
            Console.ReadKey();
            */

            /*
             *  Polymorphism
            Monster[] monster = new Monster[4];
            monster[0] = new OctopusMonster();
            monster[1] = new Cockroach();
            monster[2] = new BuffaloMonster();
            monster[3] = new Bat();
            for(int i=0; i<=4; i++)
            {
                monster[1].Attack();
            }
            Console.ReadKey();
            */

            /*
             *      Inheritance Method
            OctopusMonster octopus = new OctopusMonster();
            Cockroach cockroach = new Cockroach();
            BuffaloMonster buffalo = new BuffaloMonster();
            Bat bat = new Bat();
             
            octopus.Attack();
            cockroach.Attack();
            buffalo.Attack();
            bat.Attack();
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
            */
        }
    }
}
