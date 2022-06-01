using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class M3 : BMW
    {
        public M3(string model, int hP, string color) : base(model, hP, color)
        {
            Model = model;
        }
        public override void Repair()
        {
            base.Repair();
        }
    }
}
