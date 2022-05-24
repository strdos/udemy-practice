using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP

{
    internal class Property
    {
        private int volume;
        private int height;
        private int length;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        // read-only property
        public int FrontSurface 
        {
            get { return height * length; } 
        }

    }
}
