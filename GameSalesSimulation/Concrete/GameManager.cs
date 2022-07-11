using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    public class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Listeye Eklendi.");
            games.Add(game);
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine("Oyun Listeden Kaldırıldı: "+ game.Name);
            ListGame();
        }

        public void ListGame()
        {
            Console.WriteLine("Mevcut Oyunlar Listesi");
            foreach (Game game in games)
            {
                Console.WriteLine(game.Name);
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Oyun Güncellendi.");
            ListGame();
        }
    }
}
