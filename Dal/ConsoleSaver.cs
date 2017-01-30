using SOLID.Interfaces;
using System;

namespace SOLID
{
    class ConsoleSaver : IRouteSaver
    {

        public void Write(string Content)
        {
            Console.WriteLine(Content);
        }
    }
}
