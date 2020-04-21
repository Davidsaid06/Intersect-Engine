using System;

namespace Intersect.Network.Packets.Server
{

    public class InventoryUpdatePacket : CerasPacket
    {

        public InventoryUpdatePacket(int slot, Guid id, int quantity, Guid? bagId, int[] statBuffs)
        {
            Slot = slot;
            ItemId = id;
            BagId = bagId;
            Quantity = quantity;
            StatBuffs = statBuffs;
        }


        public InventoryUpdatePacket(int slot, Guid id, int quantity, Guid? bagId, int[] statBuffs,int maxDurability, int maxWeaponSkill, int currentDurability,int currentWeaponPoints)
        {
            Slot = slot;
            ItemId = id;
            BagId = bagId;
            Quantity = quantity;
            StatBuffs = statBuffs;
            MaxDurability = maxDurability;
            MaxWeaponSkillsPoint = maxWeaponSkill;
            CurrentDurability = currentDurability;
            CurrentWeaponSkillPoint = currentWeaponPoints;
        }

        public int Slot { get; set; }

        public Guid ItemId { get; set; }

        public Guid? BagId { get; set; }

        public int Quantity { get; set; }

        public int[] StatBuffs { get; set; }

        public int MaxDurability { get; private set; }

        public int CurrentDurability { get; private set; }

        public int MaxWeaponSkillsPoint { get; private set; }

        public int CurrentWeaponSkillPoint { get; private set; }
    

    }

}
