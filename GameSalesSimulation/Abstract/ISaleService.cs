using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    public interface ISaleService
    {
        void Sales(Gamer gamer, Game game, Campaign campaign);
    }
}
