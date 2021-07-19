using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges_Repository
{
    class DictionaryBadgeID
    {

        private Dictionary<int, Badges> allBadges = new Dictionary<int, Badges>();

        // Create
        public void CreateNewBadge(int badgeID, Badges newBadge)
        {
            allBadges.Add(badgeID, newBadge);
        }

        // Read
        public Dictionary<int, Badges> GetBadgeList()
        {
            return allBadges;
        }
        public Badges GetBadgeByID(int badgeID)
        {
            return allBadges[badgeID];
        }


        // Update
        public void UpdateBadge(int badgeNumber, List<string> updatedDoors)
        {
            Badges oldBadge = GetBadgeByID(badgeNumber);

            if (oldBadge != null)
            {
                oldBadge.BadgeID = badgeNumber;
            }

        }

        // Delete
        public bool RemoveBadgeFromList(int badgeID)
        {
            Badges badges = GetBadgeByID(badgeID);
            if (badges == null)
            {
                return false;
            }

            int initialCount = allBadges.Count;
            allBadges.Remove(badgeID);

            if (initialCount > allBadges.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper
        //public Badges GetBadgesByName(string badgeName)
        //{
        //    foreach (Badges badges in allBadges)
        //    {
        //        if (badges.BadgeName == badgeName)
        //        {
        //            return badges;
        //        }
        //    }
        //    return null;
        //}
        
    }
}
