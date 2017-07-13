using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Khim Tang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.5 - implemented the ToString method of the superhuman class
 * Version: 0.7 - Modified Driver class to implement SuperHero
 */



namespace Comp123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climing", 50);
            superHuman.AddPower("Webcasting", 40);
            Console.WriteLine(superHuman.ToString());
            SuperHero superHero = new SuperHero("Super Dude", 20);            
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());

            
        }
    }
}
