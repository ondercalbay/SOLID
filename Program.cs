using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Force> forces = new List<Force>
            {
                new Tank(),
                new Infantry()
            };

            foreach (Force force in forces)
            {
                force.Setup();
                force.Move(40, 40, 40);
            }

            Force t80 = new Tank();
            t80.Setup();
            t80.Move(3, 5, 6);

            Paratrooper specialForces = new Paratrooper();
            if (specialForces.Check())
            {
                specialForces.Setup();
                specialForces.Move(3, 6, 10);
            }
        }
    }
}