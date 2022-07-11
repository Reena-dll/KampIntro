using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Gamer { get; set; }
        public string Game { get; set; }
        public int Discount { get; set; }

    }
}
