﻿using System.Collections.Generic;
using Windows.Devices.Geolocation;
using Turf_Wars.Powers;
using Turf_Wars.Teams;

namespace Turf_Wars
{
    public class Player
    {
        public string Name;
        public string Email;
        private readonly string _password;
        
        public int Level;
        public int Coinz;
        public Team Team;

        public int Experience;
        public double ExpToNextLvl;

        public static List<PowerUp> Powers = new List<PowerUp>();

        public BasicGeoposition Geoposition { get; set; }

        public Player(string name, string password, string email)
        {
            Name = name;
            Email = email;
            _password = password;

            Level = 1;
            Coinz = 0;
            Experience = 0;
            ExpToNextLvl = 100;

            Team = new NoTeam(0);
        }

        public bool CheckLogin(string name, string password)
        {
            return Name == name && _password == password;
        }

        public void AddExperience(int exp)
        {
            Experience += exp;
            if (!(Experience >= ExpToNextLvl)) return;

            Level++;
            Experience = Experience - (int)ExpToNextLvl;
            ExpToNextLvl *= 1.5;
        }
    }
}
