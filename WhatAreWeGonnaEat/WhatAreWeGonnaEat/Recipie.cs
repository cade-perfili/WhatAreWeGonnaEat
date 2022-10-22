using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatAreWeGonnaEat
{
    public class Recipie
    {
        public string name;
        private Func<string?> readLine;

        public Recipie()
        {
        }

        public Recipie(Func<string?> readLine)
        {
            this.readLine = readLine;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
    }
}
