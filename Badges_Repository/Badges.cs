﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges_Repository
{
    public class Badges
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; }  
        public string BadgeName { get; set; }

        public Badges() { }
        public Badges(int badgeID, List<string> doorNames, string badgeName)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
            BadgeName = badgeName;
        }
    }
}