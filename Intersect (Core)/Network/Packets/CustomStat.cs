using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Network.Packets
{
    public class CustomStat
    {
        public string StatName { get; set; }

        public string StatValue { get; set; }

        public int CurrentExp { get; set; }

        public int NextExp { get; set; }

        public int StatType { get; set; }

        public enum PrimaryJobs
        {
            Mining = 0,
            Fishing,
            Woodcutting,
            Count
        }

        public enum SecondaryJobs
        {
            Cooking = 0,
            Crafting,
            Alchemy,
            Forging,
            Lockpicking,
            Count
        }

        public enum ShortRangeWeapons
        {
            Blade = 0,
            Dagger,
            Rapier,
            Saber,
            Count
        }

        public enum LargeRangeWeapons
        {
            Bow = 0,
            Book,
            Projectile,
            Staff,
            Count
        }

        public enum SystemStats
        {
            Hunger=0,
            Activity,
            Time,
            RoyalAlignment,
            NaturalAlignment,
            Count
        }

        public CustomStat(string statName, string statValue, int currentExp, int nextExp,int statType)
        {
            StatName = statName;
            StatValue = statValue;
            CurrentExp = currentExp;
            NextExp = nextExp;
            StatType = statType;
        }

        public static int getCountStats()
        {
            return (int)PrimaryJobs.Count + (int)SecondaryJobs.Count + (int)ShortRangeWeapons.Count + (int)LargeRangeWeapons.Count;
        }

        public static int getCountStatsSystem()
        {
            return (int)PrimaryJobs.Count + (int)SecondaryJobs.Count + (int)ShortRangeWeapons.Count + (int)LargeRangeWeapons.Count+(int)SystemStats.Count;
        }

    }
}
