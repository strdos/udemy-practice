﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IDestroyable
    {
        public string DestructionSound { get; set; }
        void Destroy();
    }
}
