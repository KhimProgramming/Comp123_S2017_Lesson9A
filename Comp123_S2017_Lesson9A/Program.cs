﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Khim Tang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.4 - Added another Power to the SuperHuman object
 *              - Also displayed all the powers in the Powers List
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
            superHuman.DisplayPowers();
        }
    }
}
