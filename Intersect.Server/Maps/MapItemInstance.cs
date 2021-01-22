using System;

using Intersect.Server.Database;
using Intersect.Server.Database.PlayerData.Players;

using Newtonsoft.Json;

namespace Intersect.Server.Maps
{

    public class MapItem : Item
    {

        [JsonIgnore] public int AttributeSpawnX = -1;

        [JsonIgnore] public int AttributeSpawnY = -1;

        [JsonIgnore] public long DespawnTime;

        /// <summary>
        /// The Unique Id of this particular MapItemInstance so we can refer to it elsewhere.
        /// </summary>
        public Guid UniqueId { get; private set; }

        public Guid Owner;

        [JsonIgnore] public long OwnershipTime;

        // We need this mostly for the client-side.. They can't keep track of our timer after all!
        public bool VisibleToAll = true;

        public MapItem(Guid itemId, int quantity) : base(itemId, quantity, null, null)
        {
            UniqueId = Guid.NewGuid();

        public int X = 0;

        public int Y = 0;

        public int MaxDurability { get; private set; }

        public int CurrentDurability { get; private set; }

        public int MaxWeaponSkillsPoint { get; private set; }

        public int CurrentWeaponSkillPoint { get; private set; }

        public MapItem(Guid itemId, int quantity) : base(itemId, quantity, null, null)
        {
            this.MaxDurability = Descriptor.Durability;
            this.MaxWeaponSkillsPoint = Descriptor.WeaponSkill;
            this.CurrentDurability = MaxDurability;
            this.CurrentWeaponSkillPoint = 0;
        }

        public MapItem(Guid itemId, int quantity,int currentDurability,int currentWeaponSkill) : base(itemId, quantity, null, null)
        {
            this.MaxDurability = Descriptor.Durability;
            this.MaxWeaponSkillsPoint = Descriptor.WeaponSkill;
            this.CurrentDurability = currentDurability;
            this.CurrentWeaponSkillPoint = currentWeaponSkill;
        }


        public MapItem(Guid itemId, int quantity, Guid? bagId, Bag bag) : base(itemId, quantity, bagId, bag)
        {
            UniqueId = Guid.NewGuid();

            this.MaxDurability = Descriptor.Durability;
            this.MaxWeaponSkillsPoint = Descriptor.WeaponSkill;
            this.CurrentDurability = MaxDurability;
            this.CurrentWeaponSkillPoint = 0;

        }

        public MapItem(Guid itemId, int quantity, Guid? bagId, Bag bag, int currentDurability, int currentWeaponSkill) : base(itemId, quantity, bagId, bag)
        {
            this.MaxDurability = Descriptor.Durability;
            this.MaxWeaponSkillsPoint = Descriptor.WeaponSkill;
            this.CurrentDurability = currentDurability;
            this.CurrentWeaponSkillPoint = currentWeaponSkill;

        }

        public string Data()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Sets up the Stat Buffs on this map item from a supplied item.
        /// </summary>
        /// <param name="item">The item to take the Stat Buffs from and apply them to this MapItem.</param>
        public void SetupStatBuffs(Item item)
        {
            if (StatBuffs != null && item.StatBuffs != null)
            {
                for (var i = 0; i < StatBuffs.Length; ++i)
                {
                    StatBuffs[i] = item.StatBuffs.Length > i ? item.StatBuffs[i] : 0;
                }
            }
        }

    }

}
