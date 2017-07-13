using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Khim Tang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9 
 * Version: 0.8 - Modified Driver class to implement SuperVillain
 */



namespace Comp123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperVillain superVillain = new SuperVillain("Super Bad Dude", 30);
            superVillain.AddPower("Shooting Fire", 66);
            superVillain.AddPower("Forcingfire", 30);
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Malice points: " + superVillain.Malice + "\n");

            SuperHero superHero = new SuperHero("Super Good Dude", 20);
            superHero.AddPower("Spider Climbing", 55);
            superHero.AddPower("Webcasting", 20);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma points: " + superHero.Karma + "\n");

            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climing", 50);
            superHuman.AddPower("Webcasting", 40);
            Console.WriteLine(superHuman.ToString());
            
        }
    }
}
