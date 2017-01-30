using SOLID.Interfaces;
using System;
using System.IO;

namespace SOLID
{
    class TextSaver : IRouteSaver
    {
        public void Write(string Content)
        {
            File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "Routes.tx"), Content);
        }
    }
}
