﻿using System;

namespace Turf_Wars.Powers
{
    public class Attacker : PowerUp
    {
        public Attacker(int cost, string description) : base(cost, description)
        {
            Name = "Attacker";
            CoolDown = TimeSpan.FromSeconds(7);
            LevelRestriction = 5;
            PowerUpType = PowerUps.Attacker;
        }

        public override void Activate()
        {
            throw new System.NotImplementedException();
        }

        public override void Buy()
        {
            IsBought = true;
        }
    }
}