using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp123_S2017_Lesson9A
{
    public class SuperHero : SuperHuman,IHasKarma
    {
        // PRIVATE INSTANCE VARIABLE
        private int _karma;
        // PUBLIC PROPERTIES
        public int Karma { get { return this._karma; } set {this._karma=value; } }
        // CONSTRUCTORS
        /// <summary>
        /// This is main constructor for super Human
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        public SuperHero(string name, int karma) :base(name)
        {
            this.Karma = karma;
        }
        // PRIVATE METHODS
        // PUBLIC NETHODS
    }
}