using System;
using System.ComponentModel.DataAnnotations.Schema;

using Intersect.Server.Entities;

using Newtonsoft.Json;

// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Local

namespace Intersect.Server.Database.PlayerData.Players
{

    public class InventorySlot : Item, ISlot, IPlayerOwned
    {

        public InventorySlot()
        {
            MaxDurability = Durability;
            currentDurability = MaxDurability;
        }

        public InventorySlot(int slot)
        {
            MaxDurability = Durability;
            currentDurability = MaxDurability;
            Slot = slot;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), JsonIgnore]
        public Guid Id { get; private set; }

        [JsonIgnore]
        public Guid PlayerId { get; private set; }

        [JsonIgnore]
        public virtual Player Player { get; private set; }

        public int Slot { get; private set; }

        public int MaxDurability { get; private set; }

        public int currentDurability { get; private set; }

        public int MaxWeaponSkillsPoint { get; private set; }

        public int currentWeaponSkillPoint { get; private set; }


    }

}
