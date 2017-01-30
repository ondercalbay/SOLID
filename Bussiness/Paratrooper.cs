using SOLID.Interfaces;

namespace SOLID
{
    class Paratrooper : Force, ILocationControl
    {
        public bool Check()
        {
            return true;
        }
    }
}
