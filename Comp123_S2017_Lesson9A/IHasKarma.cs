﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 13, 2017
 * Description: This Interface lists the signature for any Super Hero Subclass
 * Version: 0.1 - declared the karma properties
 */

namespace Comp123_S2017_Lesson9A
{
    public interface IHasKarma
    {
        // Public properties
        int Karma { get; set; }
    }
}