using System;

namespace Interface
{
    public interface INdexer
    {
        int this[int index] { get; set; }
    }

    public interface ISingingWorker : IWork, ISing, IPerson { }// наследование интерфейсов
    public interface IWork
    {
        void Work();
    }

    public interface ISing
    {
        void Sing();
    }

    public interface IPerson
    {
        string Name { get; set; }
    }
    class Worker : IWork, IPerson
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Work()
        {
            Console.WriteLine($"{_name} is working");
        }
    }

    class Digger : Worker, ISingingWorker
    {
        public new void Work()
        {
            Console.WriteLine($"{Name} is digging");
        }
        public void Sing()
        {
            Console.WriteLine($"{Name} is singing for fun");
        }

        void IWork.Work() // отработает если обьект по ссылке интерфеса создавался
        {
            Console.WriteLine($"{Name} is I_digging");

        }
    }

    class Singer : ISing
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Sing()
        {
            Console.WriteLine($"{_name} is singing");
        }

    }

    class Artist : Worker, ISing
    {
        public void Sing()
        {
            Console.WriteLine($"{Name} is working as singer");
        }
    }

}
