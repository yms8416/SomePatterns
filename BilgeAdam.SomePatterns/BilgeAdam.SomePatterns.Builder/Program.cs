using BilgeAdam.SomePatterns.Builder.Models;
using System;

namespace BilgeAdam.SomePatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDD => Infrastructure Driven Design
            //DDD => Domain Driven Design
            //TDD => Test Driven Design
            //EDD => Event Driven Design

            var gs = new Team { Name = "Galatasaray" };
            var bjk = new Team { Name = "Beşiktaş" };
            var mrs = new Team { Name = "Marseille" };
            var sws = new Team { Name = "Swensea" };
            var laz = new Team { Name = "Lazio" };
            var prt = new Team { Name = "Porto" };
            var lyon = new Team { Name = "Lyon" };

            #region Oyuncular
            var muslera = new Player
            {
                FirstName = "Fernando",
                LastName = "Muslera",
                Number = 1
            };

            var gomis = new Player
            {
                FirstName = "Bafetimbi",
                LastName = "Gomis",
                Number = 18
            };

            var player3 = new Player
            {
                FirstName = "Younnes",
                LastName = "Belhanda",
                Number = 10
            };

            var quaresma = new Player
            {
                FirstName = "Ricardo",
                LastName = "Quaresma",
                Number = 7
            };

            var player5 = new Player
            {
                FirstName = "Oğuzhan",
                LastName = "Özyakup",
                Number = 10
            };

            var player6 = new Player
            {
                FirstName = "Luis",
                LastName = "Fabricio",
                Number = 23
            };

            var player7 = new Player
            {
                FirstName = "Selçuk",
                LastName = "İnan",
                Number = 8
            };
            #endregion

            mrs.AddPlayer(gomis);
            sws.AddPlayer(gomis);
            lyon.AddPlayer(gomis);
            prt.AddPlayer(quaresma);

            laz.AddPlayer(muslera);

            gs.AddPlayer(muslera)
              .AddPlayer(gomis)
              .AddPlayer(player3)
              .AddPlayer(player7);

            bjk.AddPlayer(quaresma)
               .AddPlayer(player5)
               .AddPlayer(player6);

            WriteSummary(gs);
            WriteSummary(bjk);

            Console.ReadKey();
        }

        private static void WriteSummary(Team team)
        {
            Console.WriteLine($"{team.Name} takımındaki oyuncu sayısı : {team.Players.Count}");
        }
    }
}
