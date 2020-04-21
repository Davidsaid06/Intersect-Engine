using Newtonsoft.Json;

namespace Intersect.Client.Items
{

    public class MapItemInstance : Item
    {

        public int X;

        public int Y;

        public int MaxDurability { get; private set; }

        public int CurrentDurability { get; private set; }

        public int MaxWeaponSkillsPoint { get; private set; }

        public int CurrentWeaponSkillPoint { get; private set; }

        public MapItemInstance() : base()
        {
        }

        public MapItemInstance(string data) : base()
        {
            JsonConvert.PopulateObject(data, this);

        }

    }

}
