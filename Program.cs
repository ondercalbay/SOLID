using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

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

    interface IRouteSaver
    {
        void Write(string Content);
    }

    class TextSaver : IRouteSaver
    {
        public void Write(string Content)
        {
            File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "Routes.tx"), Content);
        }
    }

    class DbSaver : IRouteSaver
    {

        public void Write(string Content)
        {
            throw new NotImplementedException();
        }
    }

    class DeviceSaver : IRouteSaver
    {

        public void Write(string Content)
        {
            throw new NotImplementedException();
        }
    }

    class ConsoleSaver : IRouteSaver
    {

        public void Write(string Content)
        {
            Console.WriteLine(Content);
        }
    }

    interface IMovement
    {
        void Move(int x, int y, int z);
    }

    interface ISetup
    {
        void Setup();
    }

    interface ILocationControl
    {
        bool Check();
    }

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

    class Infantry : Force
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

    class Bastion : ISetup
    {

        public void Setup()
        {
            throw new NotImplementedException();
        }
    }

    class Paratrooper : Force, ILocationControl
    {
        public bool Check()
        {
            return true;
        }
    }



}
