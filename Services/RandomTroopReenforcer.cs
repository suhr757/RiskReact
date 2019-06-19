﻿using System;
using RiskReact.Models.Entities;
using RiskReact.Services.Interfaces;

namespace RiskReact.Services
{
    public class RandomTroopReenforcer : ITroopReenforcer
    {
        public bool Reenforce(Player player, int armiesToDrop)
        {
            if (player.ArmiesToDistribute < armiesToDrop)
                throw new Exception($"Unable to reenforce {armiesToDrop} armies because {player.Name} only have {player.ArmiesToDistribute}.");
            if (player.Countries.Count == 0)
                return false;

            var chosenCountry = player.Countries[0];

            player.DropArmies(chosenCountry, armiesToDrop);
        }
    }
}
