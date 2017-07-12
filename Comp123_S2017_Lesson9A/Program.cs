using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Khim Tang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.2 - Instantiated an object of type SuperHuman
 */



namespace Comp123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Spider Climing", 50));
        }
    }
}
