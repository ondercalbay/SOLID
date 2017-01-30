using SOLID.Interfaces;
using System;
using System.Configuration;

namespace SOLID
{
    class Force : IMovement, ISetup
    {
        private static IRouteSaver _saver;

        static Force()
        {
            string saverName = ConfigurationManager.AppSettings["SaverType"];
            _saver = (IRouteSaver)Activator.CreateInstance(Type.GetType(saverName));
        }

        public virtual void Setup()
        {
            //Kurulum İşlemi yapılır.
        }

        public virtual void Move(int x, int y, int z)
        {
            //Move operasyonu yapılır.
            _saver.Write(string.Format("{0} to ({1},{2},{3})", this.GetType().Name, x, y, z));
        }

    }
}
