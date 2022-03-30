using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.GetDataFromDataBase
{
    public class GetEverythingFromDataBase
    {
        public static Save GetEverythingFromDataBaseCommand(SaveContext saveContext)
        {
            List<Save> saves = saveContext.Saves.ToList();
            Save save = saves.Where(x => x.SaveName == "a").FirstOrDefault();
            save.Clubs = saveContext.Clubs.Where(x => x.SaveId == save.Id).ToList();
            foreach (Squad squad in saveContext.Squads.ToList())
            {
                foreach (Club club in save.Clubs)
                {
                    if (club.Id == squad.ClubId)
                    {
                        save.Clubs[club.Id - 1].Squad = squad;
                    }
                }
            }
            foreach (StartingEleven startingEleven in saveContext.StartingElevens.ToList())
            {
                foreach (Club club in save.Clubs)
                {
                    if (club.Squad.Id == startingEleven.SquadId)
                    {
                        save.Clubs[club.Id - 1].Squad.StartingEleven = startingEleven;
                    }
                }
            }
            foreach (Bench bench in saveContext.Benches.ToList())
            {
                foreach (Club club in save.Clubs)
                {
                    if (club.Squad.Id == bench.SquadId)
                    {
                        save.Clubs[club.Id - 1].Squad.Bench = bench;
                    }
                }
            }
            foreach (Reserves reserves in saveContext.Reserves.ToList())
            {
                foreach (Club club in save.Clubs)
                {
                    if (club.Squad.Id == reserves.SquadId)
                    {
                        save.Clubs[club.Id - 1].Squad.Reserves = reserves;
                    }
                }
            }
            foreach (Player player in saveContext.Players.ToList())
            {
                foreach (Club club in save.Clubs)
                {
                    if (club.Squad.StartingEleven.Id == player.StartingElevenId)
                    {
                        save.Clubs[club.Id - 1].Squad.StartingEleven.Players.Add(player);
                    }
                    if (club.Squad.Bench.Id == player.BenchId)
                    {
                        save.Clubs[club.Id - 1].Squad.Bench.Players.Add(player);
                    }
                    if (club.Squad.Reserves.Id == player.ReservesId)
                    {
                        save.Clubs[club.Id - 1].Squad.Reserves.Players.Add(player);
                    }
                }
            }
            foreach (Stats stats in saveContext.Stats.ToList())
            {
                foreach (Club club in save.Clubs)
                {
                    if (club.Squad.StartingEleven.Players != null)
                    {
                        foreach (Player player in club.Squad.StartingEleven.Players.ToList())
                        {
                            if (player.Id == stats.PlayerId)
                            {
                                player.Stats = stats;
                            }
                        }
                    }
                    if (club.Squad.Bench.Players != null)
                    {
                        foreach (Player player in club.Squad.Bench.Players.ToList())
                        {
                            if (player.Id == stats.PlayerId)
                            {
                                player.Stats = stats;
                            }
                        }
                    }
                    if (club.Squad.Reserves.Players != null)
                    {
                        foreach (Player player in club.Squad.Reserves.Players.ToList())
                        {
                            if (player.Id == stats.PlayerId)
                            {
                                player.Stats = stats;
                            }
                        }
                    }
                }
            }
            return save;
        }
    }
}
