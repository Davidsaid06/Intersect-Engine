using System;


namespace Intersect.Network.Packets.Server
{
    public class StatsPacket : CerasPacket
    {
    

    public StatsPacket(CustomStat[] stats)
    {
            Stats = stats;
    }
    public CustomStat[] Stats { get; set; }

    }

}
