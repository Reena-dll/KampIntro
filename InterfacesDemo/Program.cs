using System;
using System.Collections.Generic;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker>()
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            List<IEat> eats = new List<IEat>()
            {
                new Worker(),
                new Manager(),
            };
        }
    }
}
