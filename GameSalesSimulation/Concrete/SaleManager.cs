using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            int sumPrice =(int)(game.Price-((campaign.Discount * game.Price) / 100));
            
            Console.WriteLine("Satın Alınan Oyun: "+game.Name);
            Console.WriteLine("Satın Alan Oyuncu: "+gamer.FirstName+" "+gamer.LastName);
            Console.WriteLine("Satın Alınan Oyunun Fiyatı: " + game.Price);
            Console.WriteLine("İndirim Miktarı: %"+ campaign.Discount);
            Console.WriteLine("İndirimli Fiyat: "+ sumPrice);
        }

        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine("Satın Alınan Oyun: " + game.Name);
            Console.WriteLine("Satın Alan Oyuncu: " + gamer.FirstName + " " + gamer.LastName);
            Console.WriteLine("Satın Alınan Oyunun Fiyatı: "+game.Price);

            Console.WriteLine("Satış İşlemi Başarıyla Gerçekleştirildi.");
        }
    }
}
