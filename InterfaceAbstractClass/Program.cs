using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMovable> transport = new List<IMovable>();

            transport.Add(new Car());
            transport.Add(new Bus());
            transport.Add(new Hourse());
            transport.Add(new Aircraft());

            foreach (var item in transport)
            {
                item.Move();
            }
        }
    }
    public interface IMovable
    {
        void Move();
    }
    public abstract class Vehicle
    {
    }

    public class Car : Vehicle, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
    public class Bus : Vehicle, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Автобус едет");
        }
    }
    public class Hourse : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Лошадь скачет");
        }
    }
    public class Aircraft : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Самолет летит");
        }
    }
}
