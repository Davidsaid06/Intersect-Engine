using System;

using Intersect.Enums;
using Intersect.GameObjects;

namespace Intersect.Client.Items
{

    public class Item
    {

        public Guid? BagId;

        public Guid ItemId;

        public int Quantity;

        public int[] StatBuffs = new int[(int) Stats.StatCount];

        public int MaxDurability { get; private set; }

        public int CurrentDurability { get; private set; }

        public int MaxWeaponSkillsPoint { get; private set; }

        public int CurrentWeaponSkillPoint { get; private set; }
        public ItemBase Base => ItemBase.Get(ItemId);

        public void Load(Guid id, int quantity, Guid? bagId, int[] statBuffs)
        {
            ItemId = id;
            Quantity = quantity;
            BagId = bagId;
            StatBuffs = statBuffs;
        }

        public void Load(Guid id, int quantity, Guid? bagId, int[] statBuffs,int maxDurability,int maxWeaponSkill,int currentDurability, int currentWeaponSkill)
        {
            ItemId = id;
            Quantity = quantity;
            BagId = bagId;
            StatBuffs = statBuffs;
            MaxWeaponSkillsPoint = maxWeaponSkill;
            MaxDurability = maxDurability;
            CurrentWeaponSkillPoint = currentWeaponSkill;
            CurrentDurability = currentDurability;
        }

        public Item Clone()
        {
            var newItem = new Item()
            {
                ItemId = ItemId,
                Quantity = Quantity,
                BagId = BagId,
                MaxDurability = MaxDurability,
                MaxWeaponSkillsPoint = MaxWeaponSkillsPoint,
                CurrentDurability = CurrentDurability,
                CurrentWeaponSkillPoint=CurrentWeaponSkillPoint
                
                

            };

            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                newItem.StatBuffs[i] = StatBuffs[i];
            }

            return newItem;
        }

    }

}
