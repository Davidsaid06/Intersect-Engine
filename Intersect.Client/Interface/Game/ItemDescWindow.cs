using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Enums;
using Intersect.GameObjects;

namespace Intersect.Client.Interface.Game
{

    public class ItemDescWindow
    {

        ImagePanel mDescWindow;

        public ItemDescWindow(
            ItemBase item,
            int amount,
            int x,
            int y,
            int[] statBuffs,
            string titleOverride = "",
            string valueLabel = "",
            bool centerHorizontally = false
        )
        {
            var title = titleOverride;
            if (string.IsNullOrWhiteSpace(title))
            {
                title = item.Name;
            }

            mDescWindow = new ImagePanel(Interface.GameUi.GameCanvas, "ItemDescWindow");
            if (item != null && item.ItemType == ItemTypes.Equipment)
            {
                mDescWindow.Name = "ItemDescWindowExpanded";
            }

            if (item != null)
            {
                var icon = new ImagePanel(mDescWindow, "ItemIcon");

                var itemName = new Label(mDescWindow, "ItemNameLabel");
                itemName.Text = title;

                var itemQuantity = new Label(mDescWindow, "ItemQuantityLabel");

                if (amount > 1)
                {
                    itemQuantity.Text += amount.ToString("N0").Replace(",", Strings.Numbers.comma);
                }

                itemName.AddAlignment(Alignments.CenterH);

                var itemType = new Label(mDescWindow, "ItemTypeLabel");
                var itemValue = new Label(mDescWindow, "ItemValueLabel");

                itemType.Text = Strings.ItemDesc.itemtypes[(int) item.ItemType];
                itemValue.SetText(valueLabel);

                var durability = new Label(mDescWindow, "durabilityLabel");
                durability.Text = Strings.ItemDesc.durability.ToString(item.Durability, item.Durability);
                var weaponSkill = new Label(mDescWindow, "weaponSkillLabel");
                weaponSkill.Text = Strings.ItemDesc.weaponskill.ToString(item.WeaponSkill, item.WeaponSkill);

                if (item.ItemType == ItemTypes.Equipment &&
                    item.EquipmentSlot >= 0 &&
                    item.EquipmentSlot < Options.EquipmentSlots.Count)
                {
                    itemType.Text = Options.EquipmentSlots[item.EquipmentSlot];
                    if (item.EquipmentSlot == Options.WeaponIndex && item.TwoHanded)
                    {
                        itemType.Text += " - " + Strings.ItemDesc.twohand;
                    }
                }

                if (item.Rarity > 0)
                {
                    itemType.Text += " - " + Strings.ItemDesc.rarity[item.Rarity];
                    var rarity = CustomColors.Items.Rarities.ContainsKey(item.Rarity)
                        ? CustomColors.Items.Rarities[item.Rarity]
                        : Color.White;

                    itemType.TextColorOverride.R = rarity.R;
                    itemType.TextColorOverride.G = rarity.G;
                    itemType.TextColorOverride.B = rarity.B;
                    itemType.TextColorOverride.A = rarity.A;
                }

                var itemDesc = new RichLabel(mDescWindow, "ItemDescription");
                var itemDescText = new Label(mDescWindow, "ItemDescText");
                itemDescText.Font = itemDescText.Parent.Skin.DefaultFont;
                var itemStatsText = new Label(mDescWindow, item.ItemType == ItemTypes.Equipment ? "ItemStatsText" : "");
                itemStatsText.Font = itemStatsText.Parent.Skin.DefaultFont;
                var itemStats = new RichLabel(mDescWindow, item.ItemType == ItemTypes.Equipment ? "ItemStats" : "");
                itemDescText.IsHidden = true;
                itemStatsText.IsHidden = true;

                //Load this up now so we know what color to make the text when filling out the desc
                mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                if (item.Description.Length > 0)
                {
                    itemDesc.AddText(
                        Strings.ItemDesc.desc.ToString(item.Description), itemDesc.RenderColor,
                        itemDescText.CurAlignments.Count > 0 ? itemDescText.CurAlignments[0] : Alignments.Left,
                        itemDescText.Font
                    );

                    itemDesc.AddLineBreak();
                    itemDesc.AddLineBreak();
                }

                var stats = "";
                if (item.ItemType == ItemTypes.Equipment)
                {
                    stats = Strings.ItemDesc.bonuses;
                    itemStats.AddText(
                        stats, itemStats.RenderColor,
                        itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                        itemDescText.Font
                    );

                    itemStats.AddLineBreak();
                    if (item.ItemType == ItemTypes.Equipment && item.EquipmentSlot == Options.WeaponIndex)
                    {
                        stats = Strings.ItemDesc.damage.ToString(item.Damage);
                        itemStats.AddText(
                            stats, itemStats.RenderColor,
                            itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                            itemDescText.Font
                        );

                        itemStats.AddLineBreak();
                    }

                    for (var i = 0; i < (int) Vitals.VitalCount; i++)
                    {
                        var bonus = item.VitalsGiven[i].ToString();
                        if (item.PercentageVitalsGiven[i] > 0)
                        {
                            if (item.VitalsGiven[i] > 0)
                            {
                                bonus += " + ";
                            }
                            else
                            {
                                bonus = "";
                            }

                            bonus += item.PercentageVitalsGiven[i] + "%";
                        }

                        var vitals = Strings.ItemDesc.vitals[i].ToString(bonus);
                        itemStats.AddText(
                            vitals, itemStats.RenderColor,
                            itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                            itemDescText.Font
                        );

                        itemStats.AddLineBreak();
                    }

                    if (statBuffs != null)
                    {
                        for (var i = 0; i < Options.MaxStats; i++)
                        {
                            var flatStat = item.StatsGiven[i] + statBuffs[i];
                            var bonus = flatStat.ToString();

                            if (item.PercentageStatsGiven[i] > 0)
                            {
                                if (flatStat > 0)
                                {
                                    bonus += " + ";
                                }
                                else
                                {
                                    bonus = "";
                                }

                                bonus += item.PercentageStatsGiven[i] + "%";
                            }

                            stats = Strings.ItemDesc.stats[i].ToString(bonus);
                            itemStats.AddText(
                                stats, itemStats.RenderColor,
                                itemStatsText.CurAlignments.Count > 0
                                    ? itemStatsText.CurAlignments[0]
                                    : Alignments.Left, itemDescText.Font
                            );

                            itemStats.AddLineBreak();
                        }
                    }
                }

                if (item.ItemType == ItemTypes.Equipment &&
                    item.Effect.Type != EffectType.None &&
                    item.Effect.Percentage > 0)
                {
                    itemStats.AddText(
                        Strings.ItemDesc.effect.ToString(
                            item.Effect.Percentage, Strings.ItemDesc.effects[(int) item.Effect.Type - 1]
                        ), itemStats.RenderColor,
                        itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                        itemDescText.Font
                    );
                }

                //Load Again for positioning purposes.
                mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                var itemTex = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Item, item.Icon);
                if (itemTex != null)
                {
                    icon.Texture = itemTex;
                    icon.RenderColor = item.Color;
                }

                itemDesc.SizeToChildren(false, true);
                itemStats.SizeToChildren(false, true);
                itemDescText.IsHidden = true;
                itemStatsText.IsHidden = true;
                if (centerHorizontally)
                {
                    mDescWindow.MoveTo(x - mDescWindow.Width / 2, y + mDescWindow.Padding.Top);
                }
                else
                {
                    mDescWindow.MoveTo(x - mDescWindow.Width - mDescWindow.Padding.Right, y + mDescWindow.Padding.Top);
                }
            }
        }


        public ItemDescWindow(
            Client.Items.Item item,
            int amount,
            int x,
            int y,
            int[] statBuffs,
            string titleOverride = "",
            string valueLabel = "",
            bool centerHorizontally = false
        )
        {
            var title = titleOverride;
            if (string.IsNullOrWhiteSpace(title))
            {
                title = item.Base.Name;
            }

            mDescWindow = new ImagePanel(Interface.GameUi.GameCanvas, "ItemDescWindow");
            if (item != null && item.Base.ItemType == ItemTypes.Equipment)
            {
                mDescWindow.Name = "ItemDescWindowExpanded";
            }

            if (item != null)
            {
                var icon = new ImagePanel(mDescWindow, "ItemIcon");

                var itemName = new Label(mDescWindow, "ItemNameLabel");
                itemName.Text = title;

                var itemQuantity = new Label(mDescWindow, "ItemQuantityLabel");

                if (amount > 1)
                {
                    itemQuantity.Text += amount.ToString("N0").Replace(",", Strings.Numbers.comma);
                }

                itemName.AddAlignment(Alignments.CenterH);

                var itemType = new Label(mDescWindow, "ItemTypeLabel");
                var itemValue = new Label(mDescWindow, "ItemValueLabel");

                var durability = new Label(mDescWindow, "durabilityLabel");
                durability.Text = Strings.ItemDesc.durability.ToString(item.CurrentDurability, item.MaxDurability);
                var weaponSkill = new Label(mDescWindow, "weaponSkillLabel");
                weaponSkill.Text = Strings.ItemDesc.weaponskill.ToString(item.CurrentWeaponSkillPoint, item.MaxWeaponSkillsPoint);
                itemType.Text = Strings.ItemDesc.itemtypes[(int)item.Base.ItemType];
                itemValue.SetText(valueLabel);

                if (item.Base.ItemType == ItemTypes.Equipment &&
                    item.Base.EquipmentSlot >= 0 &&
                    item.Base.EquipmentSlot < Options.EquipmentSlots.Count)
                {
                    itemType.Text = Options.EquipmentSlots[item.Base.EquipmentSlot];
                    if (item.Base.EquipmentSlot == Options.WeaponIndex && item.Base.TwoHanded)
                    {
                        itemType.Text += " - " + Strings.ItemDesc.twohand;
                    }
                }

                if (item.Base.Rarity > 0)
                {
                    itemType.Text += " - " + Strings.ItemDesc.rarity[item.Base.Rarity];
                    var rarity = CustomColors.Items.Rarities.ContainsKey(item.Base.Rarity)
                        ? CustomColors.Items.Rarities[item.Base.Rarity]
                        : Color.White;

                    itemType.TextColorOverride.R = rarity.R;
                    itemType.TextColorOverride.G = rarity.G;
                    itemType.TextColorOverride.B = rarity.B;
                    itemType.TextColorOverride.A = rarity.A;
                }

                var itemDesc = new RichLabel(mDescWindow, "ItemDescription");
                var itemDescText = new Label(mDescWindow, "ItemDescText");
                itemDescText.Font = itemDescText.Parent.Skin.DefaultFont;
                var itemStatsText = new Label(mDescWindow, item.Base.ItemType == ItemTypes.Equipment ? "ItemStatsText" : "");
                itemStatsText.Font = itemStatsText.Parent.Skin.DefaultFont;
                var itemStats = new RichLabel(mDescWindow, item.Base.ItemType == ItemTypes.Equipment ? "ItemStats" : "");
                itemDescText.IsHidden = true;
                itemStatsText.IsHidden = true;

                //Load this up now so we know what color to make the text when filling out the desc
                mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                if (item.Base.Description.Length > 0)
                {
                    itemDesc.AddText(
                        Strings.ItemDesc.desc.ToString(item.Base.Description), itemDesc.RenderColor,
                        itemDescText.CurAlignments.Count > 0 ? itemDescText.CurAlignments[0] : Alignments.Left,
                        itemDescText.Font
                    );

                    itemDesc.AddLineBreak();
                    itemDesc.AddLineBreak();
                }

                var stats = "";
                if (item.Base.ItemType == ItemTypes.Equipment)
                {
                    stats = Strings.ItemDesc.bonuses;
                    itemStats.AddText(
                        stats, itemStats.RenderColor,
                        itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                        itemDescText.Font
                    );

                    itemStats.AddLineBreak();
                    if (item.Base.ItemType == ItemTypes.Equipment && item.Base.EquipmentSlot == Options.WeaponIndex)
                    {
                        stats = Strings.ItemDesc.damage.ToString(item.Base.Damage);
                        itemStats.AddText(
                            stats, itemStats.RenderColor,
                            itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                            itemDescText.Font
                        );

                        itemStats.AddLineBreak();
                    }

                    for (var i = 0; i < (int)Vitals.VitalCount; i++)
                    {
                        var bonus = item.Base.VitalsGiven[i].ToString();
                        if (item.Base.PercentageVitalsGiven[i] > 0)
                        {
                            if (item.Base.VitalsGiven[i] > 0)
                            {
                                bonus += " + ";
                            }
                            else
                            {
                                bonus = "";
                            }

                            bonus += item.Base.PercentageVitalsGiven[i] + "%";
                        }

                        var vitals = Strings.ItemDesc.vitals[i].ToString(bonus);
                        itemStats.AddText(
                            vitals, itemStats.RenderColor,
                            itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                            itemDescText.Font
                        );

                        itemStats.AddLineBreak();
                    }

                    if (statBuffs != null)
                    {
                        for (var i = 0; i < Options.MaxStats; i++)
                        {
                            var flatStat = item.Base.StatsGiven[i] + statBuffs[i];
                            var bonus = flatStat.ToString();

                            if (item.Base.PercentageStatsGiven[i] > 0)
                            {
                                if (flatStat > 0)
                                {
                                    bonus += " + ";
                                }
                                else
                                {
                                    bonus = "";
                                }

                                bonus += item.Base.PercentageStatsGiven[i] + "%";
                            }

                            stats = Strings.ItemDesc.stats[i].ToString(bonus);
                            itemStats.AddText(
                                stats, itemStats.RenderColor,
                                itemStatsText.CurAlignments.Count > 0
                                    ? itemStatsText.CurAlignments[0]
                                    : Alignments.Left, itemDescText.Font
                            );

                            itemStats.AddLineBreak();
                        }
                    }
                }

                if (item.Base.ItemType == ItemTypes.Equipment &&
                    item.Base.Effect.Type != EffectType.None &&
                    item.Base.Effect.Percentage > 0)
                {
                    itemStats.AddText(
                        Strings.ItemDesc.effect.ToString(
                            item.Base.Effect.Percentage, Strings.ItemDesc.effects[(int)item.Base.Effect.Type - 1]
                        ), itemStats.RenderColor,
                        itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                        itemDescText.Font
                    );
                }

                //Load Again for positioning purposes.
                mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                var itemTex = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Item, item.Base.Icon);
                if (itemTex != null)
                {
                    icon.Texture = itemTex;
                }

                itemDesc.SizeToChildren(false, true);
                itemStats.SizeToChildren(false, true);
                itemDescText.IsHidden = true;
                itemStatsText.IsHidden = true;
                if (centerHorizontally)
                {
                    mDescWindow.MoveTo(x - mDescWindow.Width / 2, y + mDescWindow.Padding.Top);
                }
                else
                {
                    mDescWindow.MoveTo(x - mDescWindow.Width - mDescWindow.Padding.Right, y + mDescWindow.Padding.Top);
                }
            }
        }

        public void Dispose()
        {
            Interface.GameUi?.GameCanvas?.RemoveChild(mDescWindow, false);
            mDescWindow.Dispose();
        }

    }

}
