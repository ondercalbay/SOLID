using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Tank : Force
    {
        public override void Setup()
        {
            base.Setup();
        }

        public override void Move(int x, int y, int z)
        {
            base.Move(x, y, z);
        }
    }
}
