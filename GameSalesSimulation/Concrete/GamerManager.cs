using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        List<Gamer> gamers = new List<Gamer>();
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Veritabanına Kayıt Edildi: " + gamer.FirstName);
                gamers.Add(gamer);

            }
            else
            {
                Console.WriteLine("Veritabanına Kayıt Edilemedi: "+gamer.FirstName);
            }
        }

        public void Delete(Gamer gamer)
        {

            gamers.Remove(gamer);
            Console.WriteLine(gamer.FirstName+" Kişisi Silindi.");
            
            ListGamer();
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Oyuncu Güncellendi.");
            ListGamer();
        }

        public void ListGamer()
        {
            Console.WriteLine("Veritabanına Kayıtlı Oyuncular");
            foreach (Gamer gamer in gamers)
            {
                Console.WriteLine(gamer.FirstName+" "+gamer.LastName);
            }
        }

        
       
    }
}
