using GameSalesSimulation.Adapters;
using GameSalesSimulation.Concrete;
using GameSalesSimulation.Entities;
using System;

namespace GameSalesSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Denedim, umarım olmuştur :P
            // Kişisel Veri Girmeden Çalışmaz !!!!
            Gamer Reena, Reena2, Reena3;
            Game game, game2, game3, game4, game5, game6;
            Campaign campaign, campaign1, campaign2;

            GamerMethod(out Reena, out Reena2, out Reena3);
            GameMethod(out game, out game2, out game3, out game4, out game5, out game6);
            CampaignMethod(out campaign, out campaign1, out campaign2);

            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            CampaignManager campaignManager = new CampaignManager();
            SaleManager salaManager = new SaleManager();
            

            gamerManager.Add(Reena);
            gamerManager.Add(Reena2);
            gamerManager.Add(Reena3);
            gamerManager.ListGamer();
            gamerManager.Delete(Reena2);
            gamerManager.Update(Reena);
            gameManager.Add(game);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.Add(game4);
            gameManager.Add(game5);
            gameManager.Add(game6);
            gameManager.Delete(game6);
            campaignManager.Add(campaign);
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign2);
            salaManager.Sales(Reena, game2, campaign);






            Console.ReadLine();
        }

        

        private static void CampaignMethod(out Campaign campaign, out Campaign campaign2, out Campaign campaign3)
        {
            campaign = new Campaign()
            {
                Id = 1,
                Name = "Haziran Ayı Bonus",
                Discount = 25,
            };
            campaign2 = new Campaign()
            {
                Id = 1,
                Name = "Yaza HoşGeldin Bonus",
                Discount = 35,
            };
            campaign3 = new Campaign()
            {
                Id = 1,
                Name = "Av Mevsimi Bonus",
                Discount = 45,
            };
        }

        private static void GameMethod(out Game game, out Game game2, out Game game3, out Game game4 , out Game game5, out Game game6)
        {
            game = new Game()
            {
                Id = 1,
                Name = "Counter Strike : Global Offensive",
                Price = 125
            };
            game2 = new Game()
            {
                Id = 2,
                Name = "Half Life",
                Price = 25
            };
            game3 = new Game()
            {
                Id = 3,
                Name = "Portal",
                Price = 25
            };
            game4 = new Game()
            {
                Id = 4,
                Name = "Left 4 Dead",
                Price = 125
            };
            game5 = new Game()
            {
                Id = 1,
                Name = "Garry's Mod",
                Price = 125
            };

            game6 = new Game()
            {
                Id = 6,
                Name = "Half Life 3",
                Price = 99999
            };
        }

        private static void GamerMethod(out Gamer Reena, out Gamer Reena2, out Gamer Reena3)
        {
            Reena = new Gamer()
            {
                FirstName = "Oğuzhan",
                LastName = "Sadıkoğlu",
                DateOfBirth = new DateTime(1999, 10, 13),
                Id = 1,
                NationaltyId = "11111111111"
            };
            Reena2 = new Gamer()
            {
                FirstName = "Ahmet",
                LastName = "Sadıkoğlu",
                DateOfBirth = new DateTime(1997, 10, 13),
                Id = 2,
                NationaltyId = "11111111111"
            };
            Reena3 = new Gamer()
            {
                FirstName = "Meryem",
                LastName = "Sadıkoğlu",
                DateOfBirth = new DateTime(1971, 10, 13),
                Id = 3,
                NationaltyId = "11111111111"
            };
        }
    }
}
