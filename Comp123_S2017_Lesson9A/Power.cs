﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.2 - Added a constructor
 */

namespace Comp123_S2017_Lesson9A
{
    /// <summary>
    /// This is the Power class which will be used as Data type
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        // CONSTRUCTORS ---------------------------

            /// <summary>
            /// This is the main constructor for the Power class.
            /// It takes two arguments - name (string) - rank (int)
            /// </summary>
            /// <param name="name"></param>
            /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

    }
}